namespace AzureTokenMaker.App {
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lnkCopyToDecode = new System.Windows.Forms.LinkLabel();
            this.lnkCopyToClip = new System.Windows.Forms.LinkLabel();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpConfiguration = new System.Windows.Forms.GroupBox();
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
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpConfiguration.SuspendLayout();
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
            this.tabMain.Location = new System.Drawing.Point(10, 13);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(589, 635);
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lnkCopyToDecode);
            this.tabPage1.Controls.Add(this.lnkCopyToClip);
            this.tabPage1.Controls.Add(this.grpOutput);
            this.tabPage1.Controls.Add(this.grpConfiguration);
            this.tabPage1.Controls.Add(this.grpProfiles);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generate Token";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lnkCopyToDecode
            // 
            this.lnkCopyToDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCopyToDecode.AutoSize = true;
            this.lnkCopyToDecode.Location = new System.Drawing.Point(345, 574);
            this.lnkCopyToDecode.Name = "lnkCopyToDecode";
            this.lnkCopyToDecode.Size = new System.Drawing.Size(101, 19);
            this.lnkCopyToDecode.TabIndex = 5;
            this.lnkCopyToDecode.TabStop = true;
            this.lnkCopyToDecode.Text = "Decode output";
            this.lnkCopyToDecode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyToDecode_LinkClicked);
            // 
            // lnkCopyToClip
            // 
            this.lnkCopyToClip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCopyToClip.AutoSize = true;
            this.lnkCopyToClip.Location = new System.Drawing.Point(457, 574);
            this.lnkCopyToClip.Name = "lnkCopyToClip";
            this.lnkCopyToClip.Size = new System.Drawing.Size(104, 19);
            this.lnkCopyToClip.TabIndex = 4;
            this.lnkCopyToClip.TabStop = true;
            this.lnkCopyToClip.Text = "Copy as header";
            this.lnkCopyToClip.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyToClip_LinkClicked);
            // 
            // grpOutput
            // 
            this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Location = new System.Drawing.Point(6, 357);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(569, 214);
            this.grpOutput.TabIndex = 3;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(10, 24);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(550, 179);
            this.txtOutput.TabIndex = 0;
            // 
            // grpConfiguration
            // 
            this.grpConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grpConfiguration.Location = new System.Drawing.Point(6, 99);
            this.grpConfiguration.Name = "grpConfiguration";
            this.grpConfiguration.Size = new System.Drawing.Size(571, 252);
            this.grpConfiguration.TabIndex = 2;
            this.grpConfiguration.TabStop = false;
            this.grpConfiguration.Text = "Configuration";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(104, 209);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(456, 25);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 209);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 19);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(104, 178);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(456, 25);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 178);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 19);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Visible = false;
            // 
            // txtAppId
            // 
            this.txtAppId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppId.Location = new System.Drawing.Point(104, 84);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(456, 25);
            this.txtAppId.TabIndex = 9;
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.Location = new System.Drawing.Point(22, 84);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(53, 19);
            this.lblAppId.TabIndex = 8;
            this.lblAppId.Text = "App Id:";
            // 
            // txtClientKey
            // 
            this.txtClientKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientKey.Location = new System.Drawing.Point(104, 147);
            this.txtClientKey.Name = "txtClientKey";
            this.txtClientKey.Size = new System.Drawing.Size(456, 25);
            this.txtClientKey.TabIndex = 5;
            // 
            // lblClientKey
            // 
            this.lblClientKey.AutoSize = true;
            this.lblClientKey.Location = new System.Drawing.Point(12, 147);
            this.lblClientKey.Name = "lblClientKey";
            this.lblClientKey.Size = new System.Drawing.Size(73, 19);
            this.lblClientKey.TabIndex = 4;
            this.lblClientKey.Text = "Client Key:";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(12, 118);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(63, 19);
            this.lblClientId.TabIndex = 3;
            this.lblClientId.Text = "Client Id:";
            // 
            // txtClientId
            // 
            this.txtClientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientId.Location = new System.Drawing.Point(104, 115);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(456, 25);
            this.txtClientId.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(485, 42);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 28);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.radUser);
            this.grpType.Controls.Add(this.radClient);
            this.grpType.Location = new System.Drawing.Point(10, 24);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(149, 54);
            this.grpType.TabIndex = 0;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type";
            // 
            // radUser
            // 
            this.radUser.AutoSize = true;
            this.radUser.Location = new System.Drawing.Point(82, 23);
            this.radUser.Name = "radUser";
            this.radUser.Size = new System.Drawing.Size(58, 23);
            this.radUser.TabIndex = 1;
            this.radUser.Text = "User";
            this.radUser.UseVisualStyleBackColor = true;
            this.radUser.CheckedChanged += new System.EventHandler(this.handleTypeSelection);
            // 
            // radClient
            // 
            this.radClient.AutoSize = true;
            this.radClient.Checked = true;
            this.radClient.Location = new System.Drawing.Point(6, 23);
            this.radClient.Name = "radClient";
            this.radClient.Size = new System.Drawing.Size(65, 23);
            this.radClient.TabIndex = 0;
            this.radClient.TabStop = true;
            this.radClient.Text = "Client";
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
            this.grpProfiles.Location = new System.Drawing.Point(6, 7);
            this.grpProfiles.Name = "grpProfiles";
            this.grpProfiles.Size = new System.Drawing.Size(571, 86);
            this.grpProfiles.TabIndex = 1;
            this.grpProfiles.TabStop = false;
            this.grpProfiles.Text = "Profiles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Load from profile:";
            // 
            // lnkNew
            // 
            this.lnkNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkNew.AutoSize = true;
            this.lnkNew.Location = new System.Drawing.Point(407, 19);
            this.lnkNew.Name = "lnkNew";
            this.lnkNew.Size = new System.Drawing.Size(36, 19);
            this.lnkNew.TabIndex = 6;
            this.lnkNew.TabStop = true;
            this.lnkNew.Text = "New";
            this.lnkNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNew_LinkClicked);
            // 
            // lnkSave
            // 
            this.lnkSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSave.AutoSize = true;
            this.lnkSave.Location = new System.Drawing.Point(460, 19);
            this.lnkSave.Name = "lnkSave";
            this.lnkSave.Size = new System.Drawing.Size(37, 19);
            this.lnkSave.TabIndex = 5;
            this.lnkSave.TabStop = true;
            this.lnkSave.Text = "Save";
            this.lnkSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSave_LinkClicked);
            // 
            // lnkDelete
            // 
            this.lnkDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Location = new System.Drawing.Point(512, 19);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(48, 19);
            this.lnkDelete.TabIndex = 4;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "Delete";
            this.lnkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelete_LinkClicked);
            // 
            // cboProfile
            // 
            this.cboProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfile.FormattingEnabled = true;
            this.cboProfile.Location = new System.Drawing.Point(10, 41);
            this.cboProfile.Name = "cboProfile";
            this.cboProfile.Size = new System.Drawing.Size(550, 25);
            this.cboProfile.TabIndex = 0;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decode Token";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecode.Location = new System.Drawing.Point(470, 6);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(105, 32);
            this.btnDecode.TabIndex = 8;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtSignature
            // 
            this.txtSignature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSignature.Location = new System.Drawing.Point(337, 345);
            this.txtSignature.Multiline = true;
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSignature.Size = new System.Drawing.Size(238, 254);
            this.txtSignature.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Signature";
            // 
            // txtHeader
            // 
            this.txtHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeader.Location = new System.Drawing.Point(337, 95);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHeader.Size = new System.Drawing.Size(238, 219);
            this.txtHeader.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Header";
            // 
            // txtClaims
            // 
            this.txtClaims.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClaims.Location = new System.Drawing.Point(11, 95);
            this.txtClaims.Multiline = true;
            this.txtClaims.Name = "txtClaims";
            this.txtClaims.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClaims.Size = new System.Drawing.Size(320, 504);
            this.txtClaims.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Claims (or Error Output)";
            // 
            // txtToken
            // 
            this.txtToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToken.Location = new System.Drawing.Point(15, 41);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(560, 25);
            this.txtToken.TabIndex = 1;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(7, 18);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(138, 19);
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
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.tstat});
            this.statusStrip.Location = new System.Drawing.Point(0, 660);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(610, 25);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 685);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(628, 700);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Azure Token Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpConfiguration.ResumeLayout(false);
            this.grpConfiguration.PerformLayout();
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
    }
}

