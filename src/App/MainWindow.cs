using System;
using System.Globalization;
using System.Windows.Forms;
using AzureTokenMaker.Service;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;

namespace AzureTokenMaker.App {
    public partial class MainWindow : Form {

        private ProfileService _profileService;
        private TokenService _tokenService;
        private Profile _currentProfile;

        public MainWindow () {
            InitializeComponent();
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

        private void toggleConfigurationGroup(bool isEnabled) {
            grpConfiguration.Enabled = isEnabled;
        }

        private void toggleSaveAndDelete(bool isEnabled) {
            lnkSave.Enabled = isEnabled;
            lnkDelete.Enabled = isEnabled;
        }

        private void lnkDelete_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e ) {
            var confirmation = MessageBox.Show(this, String.Format("Are you sure you would like to delete the profile '{0}'", cboProfile.Text), "Are you sure you want to delete?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirmation == DialogResult.No) {
                return;
            }
            _profileService.Delete((Profile)cboProfile.SelectedItem);
            loadProfiles();
            toggleConfigurationGroup(false);

            if (cboProfile.Items.Count < 1) {
                toggleSaveAndDelete( false );
            }
            tstat.Text = "Profile deleted";
            _currentProfile = null;
        }

        private void loadProfiles() {
            var profiles = _profileService.GetProfiles();

            cboProfile.Items.Clear();
            
            foreach ( var profile in profiles ) {
                cboProfile.Items.Add( profile );
            }
            
            cboProfile.DisplayMember = "Name";
        }

        private void Main_Load ( object sender, EventArgs e ) {
            _profileService = ProfileService.Init();
            _tokenService = new TokenService();
            toggleConfigurationGroup(false);
            toggleSaveAndDelete(false);
            loadProfiles();
        }

        private void cboProfile_SelectedIndexChanged ( object sender, EventArgs e ) {
            var selectedProfile = cboProfile.SelectedItem as Profile;
            if (selectedProfile != null) {
                populateControls(selectedProfile);
                toggleSaveAndDelete( true );
                tstat.Text = String.Concat("Loaded profile '", selectedProfile.Name, "'");
                _currentProfile = selectedProfile;
            }
        }

        private void populateControls(Profile selectedProfile) {
            if (selectedProfile.Data != null) {
                txtAppId.Text = selectedProfile.Data.ResourceId;
                txtClientId.Text = selectedProfile.Data.ClientId;
                txtClientKey.Text = selectedProfile.Data.ClientKey;
                txtUsername.Text = selectedProfile.Data.Username;
                txtPassword.Text = selectedProfile.Data.Password;
            }
            if (selectedProfile.Type == ProfileType.Client) {
                radClient.Checked = true;
            } else {
                radUser.Checked = true;
            }
            toggleConfigurationGroup(true);
        }

        private void lnkSave_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e ) {
            Profile targetProfile = getProposedProfile();

            _profileService.Save( targetProfile );
            loadProfiles();
            populateControls( targetProfile );
            cboProfile.SelectedItem = targetProfile;
            tstat.Text = String.Concat( "Saved profile '", targetProfile.Name, "'" );
            _currentProfile = targetProfile;
        }

        private void lnkNew_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e ) {

            var name = Prompt.ShowDialog("What would you like to call this profile?", "New Profile");

            if (String.IsNullOrWhiteSpace(name)) {
                return;
            }
            reset();

            var profile = new Profile
                {
                    Name = name
                };
            _profileService.Save( profile );
            loadProfiles();
            var index = cboProfile.Items.IndexOf(profile);

            cboProfile.SelectedIndex = index;
            toggleSaveAndDelete( true );
            tstat.Text = String.Concat( "Created profile '", profile.Name, "'" );
        }

        private void reset(bool keepOutput = true) {
            cboProfile.SelectedItem = null;
            radClient.Checked = true;
            txtAppId.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtClientKey.Text = String.Empty;
            txtClientId.Text = String.Empty;
            txtUsername.Text = String.Empty;

            if (!keepOutput) {
                txtOutput.Text = String.Empty;
            }
        }

        private Profile getProposedProfile() {
            //populate a profile from the controls
            var profile = new Profile
                {
                    Name = cboProfile.Text,
                    Data = createTokenParametersFromInput(),
                    Type = radClient.Checked ? ProfileType.Client : ProfileType.User
                };

            return profile;
        }

        private void btnGenerate_Click ( object sender, EventArgs e ) {
            TokenParameters tokenParameters = null;
            if (radClient.Checked) {
                if (!validateForClient()) {
                    return;
                }

                tokenParameters =  populateTokenForClient(new TokenParameters());
            }

            if (radUser.Checked) {
                if (!validateForUser()) {
                    return;
                }
                tokenParameters = populateTokenForUser(populateTokenForClient(new TokenParameters()));
            }
            tstat.Text = "Generating token...";
            toggleGenerate(false);
            bgwMain.RunWorkerAsync(tokenParameters);
        }

        private void toggleGenerate(bool isEnabled) {
            btnGenerate.Enabled = isEnabled;
        }

        private TokenParameters populateTokenForUser(TokenParameters tokenParameters) {
            tokenParameters.Username = txtUsername.Text.Trim();
            tokenParameters.Password = txtPassword.Text.Trim();
            return tokenParameters;
        }

        private TokenParameters populateTokenForClient(TokenParameters tokenParameters) {
            tokenParameters.ClientId = txtClientId.Text.Trim();
            tokenParameters.ClientKey = txtClientKey.Text.Trim();
            tokenParameters.ResourceId = txtAppId.Text.Trim();
            return tokenParameters;
        }

        private bool validateForUser() {
            bool isValid = true;

            if ( String.IsNullOrWhiteSpace( txtClientId.Text ) ) {
                erpConfiguration.SetError( txtClientId, "Please enter a client id." );
                isValid = false;
            }

            if ( String.IsNullOrWhiteSpace( txtAppId.Text ) ) {
                erpConfiguration.SetError( txtAppId, "Please enter a app id." );
                isValid = false;
            }

            if ( String.IsNullOrWhiteSpace( txtUsername.Text ) ) {
                erpConfiguration.SetError( txtUsername, "Please enter a username." );
                isValid = false;
            }
            if ( String.IsNullOrWhiteSpace( txtPassword.Text ) ) {
                erpConfiguration.SetError( txtPassword, "Please enter a password." );
                isValid = false;
            }
            return isValid;
        }

        private bool validateForClient () {
            bool isValid = true;

            if (String.IsNullOrWhiteSpace(txtClientId.Text)) {
                erpConfiguration.SetError(txtClientId, "Please enter a client id.");
                isValid = false;
            }
            if ( String.IsNullOrWhiteSpace( txtClientKey.Text ) ) {
                erpConfiguration.SetError( txtClientKey, "Please enter a client key." );
                isValid = false;
            }
            if ( String.IsNullOrWhiteSpace( txtAppId.Text ) ) {
                erpConfiguration.SetError( txtAppId, "Please enter a app id." );
                isValid = false;
            }
            return isValid;
        }

        private void bgwMain_DoWork ( object sender, System.ComponentModel.DoWorkEventArgs e ) {
            var data = (TokenParameters) e.Argument;
            string token = !String.IsNullOrWhiteSpace(data.Username) ? _tokenService.GetUserToken(data) : _tokenService.GetClientToken(data);
            e.Result = token;
        }

        private void bgwMain_RunWorkerCompleted ( object sender, System.ComponentModel.RunWorkerCompletedEventArgs e ) {
            if (e.Error != null) {
                var errorJson = JsonConvert.SerializeObject( e.Error, Formatting.Indented );
                string text = errorJson;
                if (e.Error is AdalServiceException) {
                    var ex = (AdalServiceException) e.Error;
                    if (ex.ErrorCode == "invalid_request") {
                        text = String.Format(CultureInfo.InvariantCulture,
                                             "Unable to generate the token. If you are trying to generate a user token, make sure that the client id references a 'Native Application' in Azure Active Directory. The user token generation flow only supports the client being a 'Native Application'.\r\n\r\n{0}",
                                             errorJson);
                    }
                }
                txtOutput.Text = text;
                tstat.Text = "ATTENTION: There was an error. See Output box for details.";
            } else {
                txtOutput.Text = (string) e.Result;
                tstat.Text = "Generated token.";
            }
            toggleGenerate(true);
        }

        private void lnkCopyToClip_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e ) {
            if (String.IsNullOrWhiteSpace(txtOutput.Text)) {
                return;
            }
            Clipboard.SetText("Authorization: Bearer " + txtOutput.Text.Trim());
        }

        private void handleTypeSelection ( object sender, EventArgs e ) {
            if ( radClient.Checked) {
                txtClientKey.Visible = true;
                lblClientKey.Visible = true;
                txtUsername.Visible = false;
                lblUsername.Visible = false;
                txtPassword.Visible = false;
                lblPassword.Visible = false;
            }else if (radUser.Checked) {
                txtClientKey.Visible = false;
                lblClientKey.Visible = false;
                txtUsername.Visible = true;
                lblUsername.Visible = true;
                txtPassword.Visible = true;
                lblPassword.Visible = true;
            }
        }

        private void btnDecode_Click ( object sender, EventArgs e ) {
            if (String.IsNullOrWhiteSpace(txtToken.Text)) {
                erpDecode.SetError(txtToken, "Please enter a valid Json Web Token.");
                return;
            }
            try {
                var decodedToken = _tokenService.DecodeToken(txtToken.Text);
                txtClaims.Text = decodedToken.Claims;
                txtSignature.Text = decodedToken.Signature;
                txtHeader.Text = decodedToken.Header;
                tstat.Text = "Json Web Token was decoded";
            } catch (Exception ex) {
                var exceptionJson = JsonConvert.SerializeObject(ex, Formatting.Indented);
                txtSignature.Text = String.Empty;
                txtHeader.Text = String.Empty;
                txtClaims.Text = exceptionJson;
                tstat.Text = "ATTENTION: There was an error decoding. See claims box for details.";
            }
        }

        private void lnkCopyToDecode_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e ) {
            tabMain.SelectedIndex = 1;
            txtToken.Text = txtOutput.Text;
            btnDecode_Click(sender, EventArgs.Empty);
        }

        private bool isDirty(Profile target) {

            if (_currentProfile == null || target == null)
                return false;

            if (String.Compare(target.Name, _currentProfile.Name, StringComparison.InvariantCultureIgnoreCase) != 0)
                return true;

            if (target.Type != _currentProfile.Type)
                return true;

            if (target.Data == null || _currentProfile.Data == null)
                return true;

            if (target.Data.ClientId != _currentProfile.Data.ClientId)
                return true;

            if (target.Type == ProfileType.Client && (target.Data.ClientKey != _currentProfile.Data.ClientKey))
                return true;

            if (target.Type == ProfileType.User && (target.Data.Username != _currentProfile.Data.Username))
                return true;

            if (target.Type == ProfileType.User && (target.Data.Password != _currentProfile.Data.Password))
                return true;

            if (target.Data.ResourceId != _currentProfile.Data.ResourceId)
                return true;

            return false;
        }

        private void MainWindow_FormClosing ( object sender, FormClosingEventArgs e ) {
            var target = getProposedProfile();
            if (isDirty(target)) {
                if (
                    MessageBox.Show(this,
                                    "You have pending changes. Are you sure you want to exit and lose the changes?",
                                    "Exit without saving?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2) == DialogResult.Cancel) {
                    e.Cancel = true;
                }
            }
        }
    }
}
