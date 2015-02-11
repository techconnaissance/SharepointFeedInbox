namespace SPWinForms
{
    partial class frmNotification
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
                this.notifyIcon.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pollTimer = new System.Windows.Forms.Timer(this.components);
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbPageFeed = new System.Windows.Forms.TabPage();
            this.btnCoPRead = new System.Windows.Forms.Button();
            this.dgvInbox = new System.Windows.Forms.DataGridView();
            this.tbPageSearch = new System.Windows.Forms.TabPage();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbLists = new System.Windows.Forms.ComboBox();
            this.lblListName = new System.Windows.Forms.Label();
            this.lblPortal = new System.Windows.Forms.Label();
            this.cmbPortal = new System.Windows.Forms.ComboBox();
            this.portalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.linkUrlDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notificationFeedDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.portalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.linkUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReadDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.feedDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbControl.SuspendLayout();
            this.tbPageFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInbox)).BeginInit();
            this.tbPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationFeedDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pollTimer
            // 
            this.pollTimer.Interval = 5000;
            this.pollTimer.Tick += new System.EventHandler(this.pollTimer_Tick);
            // 
            // tbControl
            // 
            this.tbControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbControl.Controls.Add(this.tbPageFeed);
            this.tbControl.Controls.Add(this.tbPageSearch);
            this.tbControl.Location = new System.Drawing.Point(13, 7);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(759, 443);
            this.tbControl.TabIndex = 2;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // tbPageFeed
            // 
            this.tbPageFeed.Controls.Add(this.btnCoPRead);
            this.tbPageFeed.Controls.Add(this.dgvInbox);
            this.tbPageFeed.Location = new System.Drawing.Point(4, 22);
            this.tbPageFeed.Name = "tbPageFeed";
            this.tbPageFeed.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageFeed.Size = new System.Drawing.Size(751, 417);
            this.tbPageFeed.TabIndex = 1;
            this.tbPageFeed.Text = "Feeds";
            this.tbPageFeed.UseVisualStyleBackColor = true;
            // 
            // btnCoPRead
            // 
            this.btnCoPRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCoPRead.Location = new System.Drawing.Point(636, 21);
            this.btnCoPRead.Name = "btnCoPRead";
            this.btnCoPRead.Size = new System.Drawing.Size(108, 23);
            this.btnCoPRead.TabIndex = 1;
            this.btnCoPRead.Text = "Mark All as Read";
            this.btnCoPRead.UseVisualStyleBackColor = true;
            this.btnCoPRead.Click += new System.EventHandler(this.btnCoPRead_Click);
            // 
            // dgvInbox
            // 
            this.dgvInbox.AllowUserToAddRows = false;
            this.dgvInbox.AllowUserToDeleteRows = false;
            this.dgvInbox.AllowUserToOrderColumns = true;
            this.dgvInbox.AllowUserToResizeRows = false;
            this.dgvInbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInbox.AutoGenerateColumns = false;
            this.dgvInbox.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInbox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.portalDataGridViewTextBoxColumn,
            this.listNameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publishedDateDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn,
            this.linkUrlDataGridViewTextBoxColumn1,
            this.isReadDataGridViewCheckBoxColumn});
            this.dgvInbox.DataSource = this.notificationFeedDtoBindingSource;
            this.dgvInbox.Location = new System.Drawing.Point(6, 50);
            this.dgvInbox.Name = "dgvInbox";
            this.dgvInbox.Size = new System.Drawing.Size(744, 361);
            this.dgvInbox.TabIndex = 0;
            this.dgvInbox.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInbox_CellFormatting);
            // 
            // tbPageSearch
            // 
            this.tbPageSearch.Controls.Add(this.lblInfo);
            this.tbPageSearch.Controls.Add(this.dgvSearchResult);
            this.tbPageSearch.Controls.Add(this.btnSearch);
            this.tbPageSearch.Controls.Add(this.cmbLists);
            this.tbPageSearch.Controls.Add(this.lblListName);
            this.tbPageSearch.Controls.Add(this.lblPortal);
            this.tbPageSearch.Controls.Add(this.cmbPortal);
            this.tbPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tbPageSearch.Name = "tbPageSearch";
            this.tbPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageSearch.Size = new System.Drawing.Size(751, 417);
            this.tbPageSearch.TabIndex = 0;
            this.tbPageSearch.Text = "Search";
            this.tbPageSearch.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(7, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(136, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Search other updates here.";
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.AllowUserToAddRows = false;
            this.dgvSearchResult.AllowUserToDeleteRows = false;
            this.dgvSearchResult.AllowUserToOrderColumns = true;
            this.dgvSearchResult.AllowUserToResizeRows = false;
            this.dgvSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchResult.AutoGenerateColumns = false;
            this.dgvSearchResult.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.portalDataGridViewTextBoxColumn1,
            this.listNameDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn1,
            this.publishedDateDataGridViewTextBoxColumn1,
            this.linkDataGridViewTextBoxColumn1,
            this.linkUrlDataGridViewTextBoxColumn,
            this.isReadDataGridViewCheckBoxColumn1});
            this.dgvSearchResult.DataSource = this.notificationFeedDtoBindingSource;
            this.dgvSearchResult.Location = new System.Drawing.Point(6, 150);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.Size = new System.Drawing.Size(743, 263);
            this.dgvSearchResult.TabIndex = 5;
            this.dgvSearchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResult_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(492, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbLists
            // 
            this.cmbLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLists.FormattingEnabled = true;
            this.cmbLists.Location = new System.Drawing.Point(127, 70);
            this.cmbLists.Name = "cmbLists";
            this.cmbLists.Size = new System.Drawing.Size(434, 21);
            this.cmbLists.TabIndex = 3;
            // 
            // lblListName
            // 
            this.lblListName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListName.AutoSize = true;
            this.lblListName.Location = new System.Drawing.Point(44, 78);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(52, 13);
            this.lblListName.TabIndex = 2;
            this.lblListName.Text = "List name";
            // 
            // lblPortal
            // 
            this.lblPortal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPortal.AutoSize = true;
            this.lblPortal.Location = new System.Drawing.Point(44, 39);
            this.lblPortal.Name = "lblPortal";
            this.lblPortal.Size = new System.Drawing.Size(34, 13);
            this.lblPortal.TabIndex = 1;
            this.lblPortal.Text = "Portal";
            // 
            // cmbPortal
            // 
            this.cmbPortal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPortal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortal.FormattingEnabled = true;
            this.cmbPortal.Location = new System.Drawing.Point(127, 36);
            this.cmbPortal.Name = "cmbPortal";
            this.cmbPortal.Size = new System.Drawing.Size(434, 21);
            this.cmbPortal.TabIndex = 0;
            this.cmbPortal.SelectedIndexChanged += new System.EventHandler(this.cmbPortal_SelectedIndexChanged);
            // 
            // portalDataGridViewTextBoxColumn
            // 
            this.portalDataGridViewTextBoxColumn.DataPropertyName = "Portal";
            this.portalDataGridViewTextBoxColumn.HeaderText = "Portal";
            this.portalDataGridViewTextBoxColumn.Name = "portalDataGridViewTextBoxColumn";
            this.portalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listNameDataGridViewTextBoxColumn
            // 
            this.listNameDataGridViewTextBoxColumn.DataPropertyName = "ListName";
            this.listNameDataGridViewTextBoxColumn.HeaderText = "ListName";
            this.listNameDataGridViewTextBoxColumn.Name = "listNameDataGridViewTextBoxColumn";
            this.listNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishedDateDataGridViewTextBoxColumn
            // 
            this.publishedDateDataGridViewTextBoxColumn.DataPropertyName = "PublishedDate";
            this.publishedDateDataGridViewTextBoxColumn.HeaderText = "PublishedDate";
            this.publishedDateDataGridViewTextBoxColumn.Name = "publishedDateDataGridViewTextBoxColumn";
            this.publishedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            this.linkDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.linkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // linkUrlDataGridViewTextBoxColumn1
            // 
            this.linkUrlDataGridViewTextBoxColumn1.DataPropertyName = "LinkUrl";
            this.linkUrlDataGridViewTextBoxColumn1.HeaderText = "LinkUrl";
            this.linkUrlDataGridViewTextBoxColumn1.Name = "linkUrlDataGridViewTextBoxColumn1";
            this.linkUrlDataGridViewTextBoxColumn1.Visible = false;
            // 
            // isReadDataGridViewCheckBoxColumn
            // 
            this.isReadDataGridViewCheckBoxColumn.DataPropertyName = "isRead";
            this.isReadDataGridViewCheckBoxColumn.HeaderText = "isRead";
            this.isReadDataGridViewCheckBoxColumn.Name = "isReadDataGridViewCheckBoxColumn";
            this.isReadDataGridViewCheckBoxColumn.Visible = false;
            // 
            // notificationFeedDtoBindingSource
            // 
            this.notificationFeedDtoBindingSource.DataSource = typeof(SPConsole.NotificationFeedDto);
            // 
            // portalDataGridViewTextBoxColumn1
            // 
            this.portalDataGridViewTextBoxColumn1.DataPropertyName = "Portal";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.portalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.portalDataGridViewTextBoxColumn1.HeaderText = "Portal";
            this.portalDataGridViewTextBoxColumn1.Name = "portalDataGridViewTextBoxColumn1";
            this.portalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // listNameDataGridViewTextBoxColumn1
            // 
            this.listNameDataGridViewTextBoxColumn1.DataPropertyName = "ListName";
            this.listNameDataGridViewTextBoxColumn1.HeaderText = "ListName";
            this.listNameDataGridViewTextBoxColumn1.Name = "listNameDataGridViewTextBoxColumn1";
            this.listNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn1.Width = 200;
            // 
            // authorDataGridViewTextBoxColumn1
            // 
            this.authorDataGridViewTextBoxColumn1.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn1.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn1.Name = "authorDataGridViewTextBoxColumn1";
            this.authorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // publishedDateDataGridViewTextBoxColumn1
            // 
            this.publishedDateDataGridViewTextBoxColumn1.DataPropertyName = "PublishedDate";
            this.publishedDateDataGridViewTextBoxColumn1.HeaderText = "PublishedDate";
            this.publishedDateDataGridViewTextBoxColumn1.Name = "publishedDateDataGridViewTextBoxColumn1";
            this.publishedDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // linkDataGridViewTextBoxColumn1
            // 
            this.linkDataGridViewTextBoxColumn1.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn1.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn1.Name = "linkDataGridViewTextBoxColumn1";
            this.linkDataGridViewTextBoxColumn1.ReadOnly = true;
            this.linkDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.linkDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // linkUrlDataGridViewTextBoxColumn
            // 
            this.linkUrlDataGridViewTextBoxColumn.DataPropertyName = "LinkUrl";
            this.linkUrlDataGridViewTextBoxColumn.HeaderText = "LinkUrl";
            this.linkUrlDataGridViewTextBoxColumn.Name = "linkUrlDataGridViewTextBoxColumn";
            this.linkUrlDataGridViewTextBoxColumn.Visible = false;
            // 
            // isReadDataGridViewCheckBoxColumn1
            // 
            this.isReadDataGridViewCheckBoxColumn1.DataPropertyName = "isRead";
            this.isReadDataGridViewCheckBoxColumn1.HeaderText = "isRead";
            this.isReadDataGridViewCheckBoxColumn1.Name = "isReadDataGridViewCheckBoxColumn1";
            this.isReadDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // feedDtoBindingSource
            // 
            this.feedDtoBindingSource.DataSource = typeof(SPConsole.FeedDto);
            // 
            // frmNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.tbControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.Name = "frmNotification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification Inbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notification_FormClosing);
            this.tbControl.ResumeLayout(false);
            this.tbPageFeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInbox)).EndInit();
            this.tbPageSearch.ResumeLayout(false);
            this.tbPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationFeedDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer pollTimer;
        //private System.Windows.Forms.GroupBox grpBox;
        //private System.Windows.Forms.DataGridView grdData;
        //private System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbPageSearch;
        private System.Windows.Forms.TabPage tbPageFeed;
        private System.Windows.Forms.BindingSource feedDtoBindingSource;
        private System.Windows.Forms.DataGridView dgvInbox;
        private System.Windows.Forms.BindingSource notificationFeedDtoBindingSource;
        private System.Windows.Forms.ComboBox cmbLists;
        private System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.Label lblPortal;
        private System.Windows.Forms.ComboBox cmbPortal;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn portalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkUrlDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReadDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn listNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn linkDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReadDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnCoPRead;
    }
}

