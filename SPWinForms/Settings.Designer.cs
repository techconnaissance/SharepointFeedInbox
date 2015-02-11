namespace SPWinForms
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvListCollection = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlListSelection = new System.Windows.Forms.Panel();
            this.pnlUrlAdd = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstboxSites = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAddedSites = new System.Windows.Forms.Label();
            this.gbxCredential = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCredentialUpdate = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lnkSite = new System.Windows.Forms.LinkLabel();
            this.lnkListSelection = new System.Windows.Forms.LinkLabel();
            this.pnlLinks = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlListSelection.SuspendLayout();
            this.pnlUrlAdd.SuspendLayout();
            this.gbxCredential.SuspendLayout();
            this.pnlLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvListCollection
            // 
            this.tvListCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvListCollection.Location = new System.Drawing.Point(3, 43);
            this.tvListCollection.Name = "tvListCollection";
            this.tvListCollection.Size = new System.Drawing.Size(176, 66);
            this.tvListCollection.TabIndex = 0;
            this.tvListCollection.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvListCollection_AfterCheck);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(340, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlListSelection
            // 
            this.pnlListSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListSelection.Controls.Add(this.tvListCollection);
            this.pnlListSelection.Location = new System.Drawing.Point(436, 345);
            this.pnlListSelection.Name = "pnlListSelection";
            this.pnlListSelection.Size = new System.Drawing.Size(202, 92);
            this.pnlListSelection.TabIndex = 0;
            // 
            // pnlUrlAdd
            // 
            this.pnlUrlAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUrlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUrlAdd.Controls.Add(this.lblStatus);
            this.pnlUrlAdd.Controls.Add(this.btnRemove);
            this.pnlUrlAdd.Controls.Add(this.lstboxSites);
            this.pnlUrlAdd.Controls.Add(this.lblInfo);
            this.pnlUrlAdd.Controls.Add(this.lblAddedSites);
            this.pnlUrlAdd.Controls.Add(this.gbxCredential);
            this.pnlUrlAdd.Controls.Add(this.lblUrl);
            this.pnlUrlAdd.Controls.Add(this.txtUrl);
            this.pnlUrlAdd.Controls.Add(this.btnAdd);
            this.pnlUrlAdd.Location = new System.Drawing.Point(207, 12);
            this.pnlUrlAdd.Name = "pnlUrlAdd";
            this.pnlUrlAdd.Size = new System.Drawing.Size(469, 442);
            this.pnlUrlAdd.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(95, 207);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "label1";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(344, 316);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstboxSites
            // 
            this.lstboxSites.FormattingEnabled = true;
            this.lstboxSites.Location = new System.Drawing.Point(27, 316);
            this.lstboxSites.Name = "lstboxSites";
            this.lstboxSites.Size = new System.Drawing.Size(307, 108);
            this.lstboxSites.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(92, 253);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(232, 26);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "eg: http://{mainsite}/sites/{sub_site}/{sub_site}\r\nDo not include defaultpage.asp" +
    "x";
            // 
            // lblAddedSites
            // 
            this.lblAddedSites.AutoSize = true;
            this.lblAddedSites.Location = new System.Drawing.Point(24, 291);
            this.lblAddedSites.Name = "lblAddedSites";
            this.lblAddedSites.Size = new System.Drawing.Size(67, 13);
            this.lblAddedSites.TabIndex = 11;
            this.lblAddedSites.Text = "Added Sites:";
            // 
            // gbxCredential
            // 
            this.gbxCredential.Controls.Add(this.label1);
            this.gbxCredential.Controls.Add(this.btnClear);
            this.gbxCredential.Controls.Add(this.btnCredentialUpdate);
            this.gbxCredential.Controls.Add(this.lblUsername);
            this.gbxCredential.Controls.Add(this.txtUsername);
            this.gbxCredential.Controls.Add(this.txtDomain);
            this.gbxCredential.Controls.Add(this.lblPassword);
            this.gbxCredential.Controls.Add(this.lblDomain);
            this.gbxCredential.Controls.Add(this.txtPassword);
            this.gbxCredential.ForeColor = System.Drawing.Color.Black;
            this.gbxCredential.Location = new System.Drawing.Point(5, 8);
            this.gbxCredential.Name = "gbxCredential";
            this.gbxCredential.Size = new System.Drawing.Size(459, 196);
            this.gbxCredential.TabIndex = 10;
            this.gbxCredential.TabStop = false;
            this.gbxCredential.Text = "Credential";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Credential is optional as by default system login will be taken";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(182, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear stored Credentials";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCredentialUpdate
            // 
            this.btnCredentialUpdate.Location = new System.Drawing.Point(335, 156);
            this.btnCredentialUpdate.Name = "btnCredentialUpdate";
            this.btnCredentialUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCredentialUpdate.TabIndex = 9;
            this.btnCredentialUpdate.Text = "Update";
            this.btnCredentialUpdate.UseVisualStyleBackColor = true;
            this.btnCredentialUpdate.Click += new System.EventHandler(this.btnCredentialUpdate_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 56);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(90, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(90, 130);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(350, 20);
            this.txtDomain.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 96);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(16, 133);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(43, 13);
            this.lblDomain.TabIndex = 5;
            this.lblDomain.Text = "Domain";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(90, 93);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(350, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(21, 230);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(41, 13);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "Site Url";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(93, 226);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(241, 20);
            this.txtUrl.TabIndex = 0;
            // 
            // lnkSite
            // 
            this.lnkSite.AutoSize = true;
            this.lnkSite.Location = new System.Drawing.Point(20, 14);
            this.lnkSite.Name = "lnkSite";
            this.lnkSite.Size = new System.Drawing.Size(44, 13);
            this.lnkSite.TabIndex = 0;
            this.lnkSite.TabStop = true;
            this.lnkSite.Text = "General";
            this.lnkSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSite_LinkClicked);
            // 
            // lnkListSelection
            // 
            this.lnkListSelection.AutoSize = true;
            this.lnkListSelection.Location = new System.Drawing.Point(20, 44);
            this.lnkListSelection.Name = "lnkListSelection";
            this.lnkListSelection.Size = new System.Drawing.Size(54, 13);
            this.lnkListSelection.TabIndex = 1;
            this.lnkListSelection.TabStop = true;
            this.lnkListSelection.Text = "Subscribe";
            this.lnkListSelection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkListSelection_LinkClicked);
            // 
            // pnlLinks
            // 
            this.pnlLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinks.Controls.Add(this.lnkListSelection);
            this.pnlLinks.Controls.Add(this.lnkSite);
            this.pnlLinks.Location = new System.Drawing.Point(1, 12);
            this.pnlLinks.Name = "pnlLinks";
            this.pnlLinks.Size = new System.Drawing.Size(200, 471);
            this.pnlLinks.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(601, 476);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 521);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlListSelection);
            this.Controls.Add(this.pnlUrlAdd);
            this.Controls.Add(this.pnlLinks);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(704, 560);
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.pnlListSelection.ResumeLayout(false);
            this.pnlUrlAdd.ResumeLayout(false);
            this.pnlUrlAdd.PerformLayout();
            this.gbxCredential.ResumeLayout(false);
            this.gbxCredential.PerformLayout();
            this.pnlLinks.ResumeLayout(false);
            this.pnlLinks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvListCollection;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlListSelection;
        private System.Windows.Forms.Panel pnlUrlAdd;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.LinkLabel lnkListSelection;
        private System.Windows.Forms.LinkLabel lnkSite;
        private System.Windows.Forms.Panel pnlLinks;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxCredential;
        private System.Windows.Forms.Button btnCredentialUpdate;
        private System.Windows.Forms.Label lblAddedSites;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox lstboxSites;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
    }
}

