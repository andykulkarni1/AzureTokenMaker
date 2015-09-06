using System;
using System.Windows.Forms;
using AzureTokenMaker.Service;

namespace AzureTokenMaker.App {
    public partial class Main : Form {

        private readonly ProfileService _profileService;
        private readonly TokenService _tokenService;

        public Main () {
            InitializeComponent();
            _profileService = ProfileService.Init();
            _tokenService = new TokenService();
        }
        
        private void btnSave_Click ( object sender, System.EventArgs e ) {
            erp.Clear();
            if ( String.IsNullOrWhiteSpace( cboProfile.Text ) ) {
                erp.SetError( cboProfile, "Please enter a name for your profile." );
            }

            var profile = cboProfile.SelectedItem as Profile ?? new Profile();

            profile.Name = cboProfile.Text;
            profile.Data = createTokenParametersFromInput();
            profile.Type = radClient.Checked ? ProfileType.Client : ProfileType.User;
            
            _profileService.Save(profile);
        }

        private TokenParameters createTokenParametersFromInput() {
            var result = new TokenParameters
                {
                    ClientId = txtClientId.Text,
                    ClientKey = txtClientKey.Text,
                    ResourceId = txtAppId.Text
                };

            if (radUser.Checked) {
                result.Password = txtPassword.Text;
                result.Username = txtUsername.Text;
            }
            return result;
        }

        private void lnkDelete_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e ) {
            var confirmation = MessageBox.Show(this, String.Format("Are you sure you would like to delete the profile '{0}'", cboProfile.Text), "Are you sure you want to delete?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirmation == DialogResult.No) {
                return;
            }
        }

        private void loadProfiles() {
            var profiles = _profileService.GetProfiles();

            foreach ( var profile in profiles ) {
                cboProfile.Items.Add( profile );
            }
            
            cboProfile.DisplayMember = "Name";
        }

        private void Main_Load ( object sender, EventArgs e ) {
            loadProfiles();
        }

        private void cboProfile_SelectedIndexChanged ( object sender, EventArgs e ) {
            var selectedProfile = cboProfile.SelectedItem as Profile;
            if (selectedProfile != null) {
                txtAppId.Text = selectedProfile.Data.ResourceId;
                txtClientId.Text = selectedProfile.Data.ClientId;
                txtClientKey.Text = selectedProfile.Data.ClientKey;
                txtUsername.Text = selectedProfile.Data.Username;
                txtPassword.Text = selectedProfile.Data.Password;

                if (selectedProfile.Type == ProfileType.Client) {
                    radClient.Checked = true;
                } else {
                    radUser.Checked = true;
                }
            }
        }
    }
}
