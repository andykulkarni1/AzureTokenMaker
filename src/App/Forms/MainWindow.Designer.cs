namespace AzureTokenMaker.App.Forms {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lnkCopy = new System.Windows.Forms.LinkLabel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lnkCopyToDecode = new System.Windows.Forms.LinkLabel();
            this.lnkCopyToClip = new System.Windows.Forms.LinkLabel();
            this.grpConfiguration = new System.Windows.Forms.GroupBox();
            this.grpTenant = new System.Windows.Forms.GroupBox();
            this.radSingleTenant = new System.Windows.Forms.RadioButton();
            this.radMultiTenant = new System.Windows.Forms.RadioButton();
            this.txtTenant = new System.Windows.Forms.TextBox();
            this.lblClientIdInstruction = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.lblAppId = new System.Windows.Forms.Label();
            this.txtClientKey = new System.Windows.Forms.TextBox();
            this.lblClientKey = new System.Windows.Forms.Label();
            this.lblClientId = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.radUser = new System.Windows.Forms.RadioButton();
            this.radClient = new System.Windows.Forms.RadioButton();
            this.grpProfiles = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkNew = new System.Windows.Forms.LinkLabel();
            this.lnkSave = new System.Windows.Forms.LinkLabel();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.cboProfile = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaims = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstat = new System.Windows.Forms.ToolStripStatusLabel();
            this.erpConfiguration = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDecode = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpConfiguration.SuspendLayout();
            this.grpTenant.SuspendLayout();
            this.grpType.SuspendLayout();
            this.grpProfiles.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDecode)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(16, 21);
            this.tabMain.Margin = new System.Windows.Forms.Padding(5);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(926, 902);
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpOutput);
            this.tabPage1.Controls.Add(this.grpConfiguration);
            this.tabPage1.Controls.Add(this.grpProfiles);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(918, 861);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generate Token";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpOutput
            // 
            this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutput.Controls.Add(this.lnkCopy);
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Controls.Add(this.lnkCopyToDecode);
            this.grpOutput.Controls.Add(this.lnkCopyToClip);
            this.grpOutput.Location = new System.Drawing.Point(9, 588);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(5);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(5);
            this.grpOutput.Size = new System.Drawing.Size(894, 226);
            this.grpOutput.TabIndex = 3;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // lnkCopy
            // 
            this.lnkCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCopy.AutoSize = true;
            this.lnkCopy.Enabled = false;
            this.lnkCopy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lnkCopy.Location = new System.Drawing.Point(654, 184);
            this.lnkCopy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnkCopy.Name = "lnkCopy";
            this.lnkCopy.Size = new System.Drawing.Size(58, 28);
            this.lnkCopy.TabIndex = 2;
            this.lnkCopy.TabStop = true;
            this.lnkCopy.Text = "Copy";
            this.toolTip.SetToolTip(this.lnkCopy, "Copies the output to the clipboard.");
            this.lnkCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopy_LinkClicked);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOutput.Location = new System.Drawing.Point(16, 40);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(5);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(862, 139);
            this.txtOutput.TabIndex = 0;
            this.toolTip.SetToolTip(this.txtOutput, "The generated token or error details.");
            // 
            // lnkCopyToDecode
            // 
            this.lnkCopyToDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCopyToDecode.AutoSize = true;
            this.lnkCopyToDecode.Enabled = false;
            this.lnkCopyToDecode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lnkCopyToDecode.Location = new System.Drawing.Point(492, 184);
            this.lnkCopyToDecode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnkCopyToDecode.Name = "lnkCopyToDecode";
            this.lnkCopyToDecode.Size = new System.Drawing.Size(144, 28);
            this.lnkCopyToDecode.TabIndex = 1;
            this.lnkCopyToDecode.TabStop = true;
            this.lnkCopyToDecode.Text = "Decode output";
            this.toolTip.SetToolTip(this.lnkCopyToDecode, "Decodes the output so you can view the claims.");
            this.lnkCopyToDecode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyToDecode_LinkClicked);
            // 
            // lnkCopyToClip
            // 
            this.lnkCopyToClip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCopyToClip.AutoSize = true;
            this.lnkCopyToClip.Enabled = false;
            this.lnkCopyToClip.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lnkCopyToClip.Location = new System.Drawing.Point(731, 184);
            this.lnkCopyToClip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnkCopyToClip.Name = "lnkCopyToClip";
            this.lnkCopyToClip.Size = new System.Drawing.Size(146, 28);
            this.lnkCopyToClip.TabIndex = 3;
            this.lnkCopyToClip.TabStop = true;
            this.lnkCopyToClip.Text = "Copy as header";
            this.toolTip.SetToolTip(this.lnkCopyToClip, "Copies the output to the clipboard as an HTTP Authorization header.");
            this.lnkCopyToClip.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyToClip_LinkClicked);
            // 
            // grpConfiguration
            // 
            this.grpConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConfiguration.Controls.Add(this.grpTenant);
            this.grpConfiguration.Controls.Add(this.lblClientIdInstruction);
            this.grpConfiguration.Controls.Add(this.txtPassword);
            this.grpConfiguration.Controls.Add(this.lblPassword);
            this.grpConfiguration.Controls.Add(this.txtUsername);
            this.grpConfiguration.Controls.Add(this.lblUsername);
            this.grpConfiguration.Controls.Add(this.txtAppId);
            this.grpConfiguration.Controls.Add(this.lblAppId);
            this.grpConfiguration.Controls.Add(this.txtClientKey);
            this.grpConfiguration.Controls.Add(this.lblClientKey);
            this.grpConfiguration.Controls.Add(this.lblClientId);
            this.grpConfiguration.Controls.Add(this.txtClientId);
            this.grpConfiguration.Controls.Add(this.btnGenerate);
            this.grpConfiguration.Controls.Add(this.grpType);
            this.grpConfiguration.Location = new System.Drawing.Point(9, 163);
            this.grpConfiguration.Margin = new System.Windows.Forms.Padding(5);
            this.grpConfiguration.Name = "grpConfiguration";
            this.grpConfiguration.Padding = new System.Windows.Forms.Padding(5);
            this.grpConfiguration.Size = new System.Drawing.Size(897, 415);
            this.grpConfiguration.TabIndex = 2;
            this.grpConfiguration.TabStop = false;
            this.grpConfiguration.Text = "Configuration";
            // 
            // grpTenant
            // 
            this.grpTenant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTenant.Controls.Add(this.radSingleTenant);
            this.grpTenant.Controls.Add(this.radMultiTenant);
            this.grpTenant.Controls.Add(this.txtTenant);
            this.grpTenant.Location = new System.Drawing.Point(30, 293);
            this.grpTenant.Name = "grpTenant";
            this.grpTenant.Size = new System.Drawing.Size(847, 100);
            this.grpTenant.TabIndex = 8;
            this.grpTenant.TabStop = false;
            this.grpTenant.Text = "Tenant";
            // 
            // radSingleTenant
            // 
            this.radSingleTenant.AutoSize = true;
            this.radSingleTenant.Location = new System.Drawing.Point(92, 47);
            this.radSingleTenant.Name = "radSingleTenant";
            this.radSingleTenant.Size = new System.Drawing.Size(87, 32);
            this.radSingleTenant.TabIndex = 1;
            this.radSingleTenant.Text = "Single";
            this.toolTip.SetToolTip(this.radSingleTenant, "The service can only be accessed by a specific tenant.");
            this.radSingleTenant.UseVisualStyleBackColor = true;
            this.radSingleTenant.CheckedChanged += new System.EventHandler(this.handleTenantSelection);
            // 
            // radMultiTenant
            // 
            this.radMultiTenant.AutoSize = true;
            this.radMultiTenant.Checked = true;
            this.radMultiTenant.Location = new System.Drawing.Point(7, 47);
            this.radMultiTenant.Name = "radMultiTenant";
            this.radMultiTenant.Size = new System.Drawing.Size(79, 32);
            this.radMultiTenant.TabIndex = 0;
            this.radMultiTenant.TabStop = true;
            this.radMultiTenant.Text = "Multi";
            this.toolTip.SetToolTip(this.radMultiTenant, "The service can be accessed by any tenant.");
            this.radMultiTenant.UseVisualStyleBackColor = true;
            this.radMultiTenant.CheckedChanged += new System.EventHandler(this.handleTenantSelection);
            // 
            // txtTenant
            // 
            this.txtTenant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenant.Location = new System.Drawing.Point(203, 48);
            this.txtTenant.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenant.Name = "txtTenant";
            this.txtTenant.Size = new System.Drawing.Size(632, 34);
            this.txtTenant.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtTenant, "The unique identifier for the tenant i.e. mytenant.onmicrosoft.com or c740abc1-89" +
        "8e-456d-97d1-14f535d7b8b2");
            this.txtTenant.Visible = false;
            // 
            // lblClientIdInstruction
            // 
            this.lblClientIdInstruction.AutoSize = true;
            this.lblClientIdInstruction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClientIdInstruction.ForeColor = System.Drawing.Color.Maroon;
            this.lblClientIdInstruction.Location = new System.Drawing.Point(163, 232);
            this.lblClientIdInstruction.Name = "lblClientIdInstruction";
            this.lblClientIdInstruction.Size = new System.Drawing.Size(423, 23);
            this.lblClientIdInstruction.TabIndex = 14;
            this.lblClientIdInstruction.Text = "Note: Client Id must be for a \'Native Application\' type.";
            this.lblClientIdInstruction.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(163, 344);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(714, 34);
            this.txtPassword.TabIndex = 11;
            this.toolTip.SetToolTip(this.txtPassword, "The password chosen by the user. This cannot be a temporary password.");
            this.txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 344);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 28);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(163, 293);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(714, 34);
            this.txtUsername.TabIndex = 9;
            this.toolTip.SetToolTip(this.txtUsername, "The username as defined in the Azure Active Directory \'Users\' tab.");
            this.txtUsername.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(19, 293);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(103, 28);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Visible = false;
            // 
            // txtAppId
            // 
            this.txtAppId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppId.Location = new System.Drawing.Point(163, 138);
            this.txtAppId.Margin = new System.Windows.Forms.Padding(5);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(714, 34);
            this.txtAppId.TabIndex = 3;
            this.toolTip.SetToolTip(this.txtAppId, "The URI used to identify the token audience.");
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.Location = new System.Drawing.Point(16, 138);
            this.lblAppId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(106, 28);
            this.lblAppId.TabIndex = 2;
            this.lblAppId.Text = "App Id Uri:";
            // 
            // txtClientKey
            // 
            this.txtClientKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientKey.Location = new System.Drawing.Point(163, 242);
            this.txtClientKey.Margin = new System.Windows.Forms.Padding(5);
            this.txtClientKey.Name = "txtClientKey";
            this.txtClientKey.Size = new System.Drawing.Size(714, 34);
            this.txtClientKey.TabIndex = 7;
            this.toolTip.SetToolTip(this.txtClientKey, "The secret given for the Client Id.");
            // 
            // lblClientKey
            // 
            this.lblClientKey.AutoSize = true;
            this.lblClientKey.Location = new System.Drawing.Point(32, 242);
            this.lblClientKey.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClientKey.Name = "lblClientKey";
            this.lblClientKey.Size = new System.Drawing.Size(103, 28);
            this.lblClientKey.TabIndex = 6;
            this.lblClientKey.Text = "Client Key:";
            this.toolTip.SetToolTip(this.lblClientKey, "The key used to read/write data. ");
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(34, 192);
            this.lblClientId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(88, 28);
            this.lblClientId.TabIndex = 4;
            this.lblClientId.Text = "Client Id:";
            // 
            // txtClientId
            // 
            this.txtClientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientId.Location = new System.Drawing.Point(163, 189);
            this.txtClientId.Margin = new System.Windows.Forms.Padding(5);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(714, 34);
            this.txtClientId.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtClientId, "The unique identifier for the client. Note: must be a Native Application if a \'Us" +
        "er\' token.");
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(762, 69);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(118, 46);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.toolTip.SetToolTip(this.btnGenerate, "Generates a token with the given settings.");
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.radUser);
            this.grpType.Controls.Add(this.radClient);
            this.grpType.Location = new System.Drawing.Point(16, 40);
            this.grpType.Margin = new System.Windows.Forms.Padding(5);
            this.grpType.Name = "grpType";
            this.grpType.Padding = new System.Windows.Forms.Padding(5);
            this.grpType.Size = new System.Drawing.Size(234, 89);
            this.grpType.TabIndex = 0;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type";
            // 
            // radUser
            // 
            this.radUser.AutoSize = true;
            this.radUser.Location = new System.Drawing.Point(129, 38);
            this.radUser.Margin = new System.Windows.Forms.Padding(5);
            this.radUser.Name = "radUser";
            this.radUser.Size = new System.Drawing.Size(72, 32);
            this.radUser.TabIndex = 1;
            this.radUser.Text = "User";
            this.toolTip.SetToolTip(this.radUser, "Generate tokens for user-based requests.");
            this.radUser.UseVisualStyleBackColor = true;
            this.radUser.CheckedChanged += new System.EventHandler(this.handleTypeSelection);
            // 
            // radClient
            // 
            this.radClient.AutoSize = true;
            this.radClient.Checked = true;
            this.radClient.Location = new System.Drawing.Point(9, 38);
            this.radClient.Margin = new System.Windows.Forms.Padding(5);
            this.radClient.Name = "radClient";
            this.radClient.Size = new System.Drawing.Size(83, 32);
            this.radClient.TabIndex = 0;
            this.radClient.TabStop = true;
            this.radClient.Text = "Client";
            this.toolTip.SetToolTip(this.radClient, "Generate tokens for machine-to-machine requests.");
            this.radClient.UseVisualStyleBackColor = true;
            this.radClient.CheckedChanged += new System.EventHandler(this.handleTypeSelection);
            // 
            // grpProfiles
            // 
            this.grpProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProfiles.Controls.Add(this.label4);
            this.grpProfiles.Controls.Add(this.lnkNew);
            this.grpProfiles.Controls.Add(this.lnkSave);
            this.grpProfiles.Controls.Add(this.lnkDelete);
            this.grpProfiles.Controls.Add(this.cboProfile);
            this.grpProfiles.Location = new System.Drawing.Point(9, 12);
            this.grpProfiles.Margin = new System.Windows.Forms.Padding(5);
            this.grpProfiles.Name = "grpProfiles";
            this.grpProfiles.Padding = new System.Windows.Forms.Padding(5);
            this.grpProfiles.Size = new System.Drawing.Size(897, 142);
            this.grpProfiles.TabIndex = 1;
            this.grpProfiles.TabStop = false;
            this.grpProfiles.Text = "Profiles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Load from profile:";
            // 
            // lnkNew
            // 
            this.lnkNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkNew.AutoSize = true;
            this.lnkNew.Location = new System.Drawing.Point(632, 31);
            this.lnkNew.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnkNew.Name = "lnkNew";
            this.lnkNew.Size = new System.Drawing.Size(51, 28);
            this.lnkNew.TabIndex = 0;
            this.lnkNew.TabStop = true;
            this.lnkNew.Text = "New";
            this.toolTip.SetToolTip(this.lnkNew, "Creates a new empty Profile.");
            this.lnkNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNew_LinkClicked);
            // 
            // lnkSave
            // 
            this.lnkSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSave.AutoSize = true;
            this.lnkSave.Location = new System.Drawing.Point(715, 31);
            this.lnkSave.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnkSave.Name = "lnkSave";
            this.lnkSave.Size = new System.Drawing.Size(53, 28);
            this.lnkSave.TabIndex = 1;
            this.lnkSave.TabStop = true;
            this.lnkSave.Text = "Save";
            this.toolTip.SetToolTip(this.lnkSave, "Saves the currently loaded profile.");
            this.lnkSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSave_LinkClicked);
            // 
            // lnkDelete
            // 
            this.lnkDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Location = new System.Drawing.Point(797, 31);
            this.lnkDelete.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(68, 28);
            this.lnkDelete.TabIndex = 2;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "Delete";
            this.toolTip.SetToolTip(this.lnkDelete, "Deletes the selected profile.");
            this.lnkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelete_LinkClicked);
            // 
            // cboProfile
            // 
            this.cboProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfile.FormattingEnabled = true;
            this.cboProfile.Location = new System.Drawing.Point(16, 68);
            this.cboProfile.Margin = new System.Windows.Forms.Padding(5);
            this.cboProfile.Name = "cboProfile";
            this.cboProfile.Size = new System.Drawing.Size(862, 36);
            this.cboProfile.TabIndex = 0;
            this.toolTip.SetToolTip(this.cboProfile, "Select a profile or click New to add.");
            this.cboProfile.SelectedIndexChanged += new System.EventHandler(this.cboProfile_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDecode);
            this.tabPage2.Controls.Add(this.txtSignature);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtHeader);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtClaims);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtToken);
            this.tabPage2.Controls.Add(this.lblToken);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(918, 861);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decode Token";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecode.Location = new System.Drawing.Point(739, 10);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(5);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(165, 53);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Decode";
            this.toolTip.SetToolTip(this.btnDecode, "Decodes the given Json Web Token.");
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtSignature
            // 
            this.txtSignature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSignature.Location = new System.Drawing.Point(530, 568);
            this.txtSignature.Margin = new System.Windows.Forms.Padding(5);
            this.txtSignature.Multiline = true;
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSignature.Size = new System.Drawing.Size(372, 261);
            this.txtSignature.TabIndex = 6;
            this.toolTip.SetToolTip(this.txtSignature, "The token\'s signature, if signed.");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 532);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Signature";
            // 
            // txtHeader
            // 
            this.txtHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeader.Location = new System.Drawing.Point(530, 156);
            this.txtHeader.Margin = new System.Windows.Forms.Padding(5);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHeader.Size = new System.Drawing.Size(372, 358);
            this.txtHeader.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtHeader, "The token\'s header information.");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Header";
            // 
            // txtClaims
            // 
            this.txtClaims.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClaims.Location = new System.Drawing.Point(17, 156);
            this.txtClaims.Margin = new System.Windows.Forms.Padding(5);
            this.txtClaims.Multiline = true;
            this.txtClaims.Name = "txtClaims";
            this.txtClaims.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClaims.Size = new System.Drawing.Size(501, 673);
            this.txtClaims.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtClaims, "All of the claims that were found in the token, or error details.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Claims (or Error Output)";
            // 
            // txtToken
            // 
            this.txtToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToken.Location = new System.Drawing.Point(24, 68);
            this.txtToken.Margin = new System.Windows.Forms.Padding(5);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(878, 34);
            this.txtToken.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtToken, "The raw Json Web Token to be decoded.");
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(19, 35);
            this.lblToken.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(195, 28);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "Raw Json Web Token";
            // 
            // bgwMain
            // 
            this.bgwMain.WorkerReportsProgress = true;
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.tstat});
            this.statusStrip.Location = new System.Drawing.Point(0, 888);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(959, 25);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            // 
            // tstat
            // 
            this.tstat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tstat.Name = "tstat";
            this.tstat.Size = new System.Drawing.Size(13, 20);
            this.tstat.Text = " ";
            // 
            // erpConfiguration
            // 
            this.erpConfiguration.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpConfiguration.ContainerControl = this;
            this.erpConfiguration.RightToLeft = true;
            // 
            // erpDecode
            // 
            this.erpDecode.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpDecode.ContainerControl = this;
            this.erpDecode.RightToLeft = true;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 913);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(977, 958);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azure Token Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpConfiguration.ResumeLayout(false);
            this.grpConfiguration.PerformLayout();
            this.grpTenant.ResumeLayout(false);
            this.grpTenant.PerformLayout();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpProfiles.ResumeLayout(false);
            this.grpProfiles.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDecode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpProfiles;
        private System.Windows.Forms.ComboBox cboProfile;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox grpConfiguration;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton radClient;
        private System.Windows.Forms.RadioButton radUser;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.LinkLabel lnkCopyToClip;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblClientKey;
        private System.Windows.Forms.TextBox txtClientKey;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtClaims;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.LinkLabel lnkDelete;
        private System.Windows.Forms.LinkLabel lnkSave;
        private System.Windows.Forms.LinkLabel lnkNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider erpConfiguration;
        private System.Windows.Forms.ToolStripStatusLabel tstat;
        private System.Windows.Forms.LinkLabel lnkCopyToDecode;
        private System.Windows.Forms.ErrorProvider erpDecode;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblClientIdInstruction;
        private System.Windows.Forms.LinkLabel lnkCopy;
        private System.Windows.Forms.GroupBox grpTenant;
        private System.Windows.Forms.RadioButton radSingleTenant;
        private System.Windows.Forms.RadioButton radMultiTenant;
        private System.Windows.Forms.TextBox txtTenant;
    }
}

