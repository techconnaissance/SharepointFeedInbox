using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using SPWinForms;
using SPConsole;
using System.Diagnostics;
using Equin.ApplicationFramework;

namespace SPWinForms
{
    public partial class frmNotification : Form
    {
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private ContextMenu contextMenu;
        private MenuItem exitMenuItem;
        private MenuItem settings;
        private IContainer comp;
        private DateTime currentDateTime = new DateTime();
        private bool isAlertNeeded = false;
        private bool isClose = false;

        Font newNotificationFont = new Font("Arial", 9, FontStyle.Bold);
        Font oldNotificationFont = new Font("Arial", 8, FontStyle.Regular);
        string dateformat = "yyyy/MM/dd HH:mm";

        public frmNotification()
        {
            InitializeComponent();

            comp = new System.ComponentModel.Container();
            contextMenu = new ContextMenu();
            exitMenuItem = new MenuItem();
            settings = new MenuItem();

            ConstructContextMenu();
            LoadPortals();

            #region Initialize Values
            //ClientSize = new Size(292, 266);
            Text = "Notification Inbox";

            notifyIcon = new NotifyIcon(comp);
            notifyIcon.Icon = new Icon("appicon.ico");
            notifyIcon.ContextMenu = contextMenu;

            notifyIcon.Text = "Notification Inbox";
            notifyIcon.Visible = true;

            notifyIcon.DoubleClick += new EventHandler(notifyIcon_DoubleClick);
            this.MinimumSizeChanged += new EventHandler(Form1_MinimumSizeChanged);

            this.FormClosing += new FormClosingEventHandler(Notification_FormClosing);
            this.dgvInbox.RowsAdded += new DataGridViewRowsAddedEventHandler(dgvInbox_RowsAdded);
            this.dgvInbox.CellClick += new DataGridViewCellEventHandler(dgvInbox_CellClick);
            #endregion

            //GetNotification();
            pollTimer.Start();
        }

        #region Events

        void settings_Click(object sender, EventArgs e)
        {
            pollTimer.Stop();
            frmSettings form = new frmSettings();
            form.ShowDialog();
            PopulateFeedGridView(true);
            pollTimer.Start();
        }

        void Notification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClose)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Minimized)
            //{
            this.Show();
            WindowState = FormWindowState.Normal;

            this.StartPosition = FormStartPosition.CenterScreen;
            //ClientSize = new Size(292, 266);
            //}

            this.Activate();
        }

        void menuItem_Click(object sender, EventArgs e)
        {
            isClose = true;
            pollTimer.Stop();
            this.Close();

            //Application.Exit();
        }

        #region FeedTab

        private void pollTimer_Tick(object sender, EventArgs e)
        {
            currentDateTime = DateTime.Now;
            isAlertNeeded = false;
            PopulateFeedGridView();
        }

        private void dgvInbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex > -1)
            {
                string url = ((DataGridView)sender)[6, e.RowIndex].Value.ToString();
                ProcessStartInfo startInfo = new ProcessStartInfo(url);
                Process.Start(startInfo);
            }

            if (e.RowIndex > -1)
            {
                dgvInbox.Rows[e.RowIndex].DefaultCellStyle.Font = oldNotificationFont;

                if (!Convert.ToBoolean(dgvInbox.Rows[e.RowIndex].Cells[7].Value))
                {
                    ((ObjectView<NotificationFeedDto>)dgvInbox.Rows[e.RowIndex].DataBoundItem).Object.isRead = true;
                    dgvInbox.Rows[e.RowIndex].Cells[7].Value = true;
                }
            }
        }

        void dgvInbox_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (!Convert.ToBoolean(dgvInbox.Rows[e.RowIndex].Cells[7].Value))
                dgvInbox.Rows[e.RowIndex].DefaultCellStyle.Font = newNotificationFont;
            else
                dgvInbox.Rows[e.RowIndex].DefaultCellStyle.Font = oldNotificationFont;
        }

        #endregion

        #region SearchTab
        private void cmbPortal_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLists.DataSource = null;
            string url = Convert.ToString(cmbPortal.SelectedItem);
            SPConsole.ListWebService.Lists lists = new SPConsole.ListWebService.Lists();
            lists.Url = url + "/_vti_bin/lists.asmx"; //"http://{sitename}/sites/{sub_site}/_vti_bin/lists.asmx";
            lists.Credentials = Constants.Credentials;

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode listCollection = lists.GetListCollection();
            IList<FeedDto> dataDictionary = new List<FeedDto>();
            FeedDto dto = null;
            foreach (XmlNode node in listCollection)
            {
                if (node.Name == "List")
                {
                    if (node.Attributes.Count > 0)
                    {
                        dto = new FeedDto();
                        dto.Title = node.Attributes["Title"].Value;
                        dto.Link = string.Format("{0}/_layouts/listfeed.aspx?List={1}", url, node.Attributes["ID"].Value.Replace("-", "%2D"));

                        dataDictionary.Add(dto);
                    }
                }
            }

            cmbLists.DataSource = dataDictionary;
            cmbLists.DisplayMember = "Title";
            cmbLists.ValueMember = "Link";
        }

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbControl.SelectedTab == tbPageSearch)
            {
                LoadPortals();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbLists.SelectedIndex > -1)
            {
                FeedDto selectedItem = (FeedDto)cmbLists.SelectedItem;
                string url = cmbPortal.SelectedItem.ToString();
                dgvSearchResult.DataSource = null;

                List<NotificationFeedDto> notificationFeedDtoList = new List<NotificationFeedDto>();
                RetrieveFeeds(notificationFeedDtoList, url, selectedItem.Link, selectedItem.Title, false);

                if (notificationFeedDtoList.Count > 0)
                {
                    BindingListView<NotificationFeedDto> dataList =
                    new Equin.ApplicationFramework.BindingListView<NotificationFeedDto>(notificationFeedDtoList);
                    dgvSearchResult.DataSource = dataList;
                }
            }
        }

        private void dgvSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string url = ((DataGridView)sender)[6, e.RowIndex].Value.ToString();
                ProcessStartInfo startInfo = new ProcessStartInfo(url);
                Process.Start(startInfo);
            }

            
        }
        #endregion
        #endregion

        #region Private Methods
        private void ConstructContextMenu()
        {
            exitMenuItem.Index = 1;
            exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new EventHandler(menuItem_Click);


            settings.Index = 0;
            settings.Text = "Settings";
            this.settings.Click += new EventHandler(settings_Click);

            contextMenu.MenuItems.AddRange(new MenuItem[] { settings, exitMenuItem });
        }

        private void RetrieveFeeds(List<NotificationFeedDto> notificationFeedDtoList, bool isFeedFetch)
        {
            List<SPListDTO> subscribedLists = Constants.SPSettings.Where(p => p.isSubscribed == true).ToList();
            NotificationFeedDto notificationFeedDto = new NotificationFeedDto();
            foreach (SPListDTO spDetail in subscribedLists)
            {

                XmlTextReader reader = new XmlTextReader(spDetail.FeedUrl);
                XmlUrlResolver resolver = new XmlUrlResolver();

                resolver.Credentials = Constants.Credentials;
                reader.XmlResolver = resolver;

                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(reader);

                    bool isRead = false;

                    //FeedDto feedDto = null;
                    foreach (XmlNode xnc in doc.ChildNodes.Cast<XmlNode>().Where(p => p.Name.ToLower() == "rss").FirstOrDefault().ChildNodes)//.Cast<XmlNode>().Where(q=> q.Name.ToLower() == "item")
                    {
                        List<XmlNode> objList = xnc.Cast<XmlNode>().Where(p => p.Name.ToLower() == "item").ToList();
                        if (objList != null && objList.Count > 0)
                        {
                            foreach (XmlNode obj in objList)
                            {
                                //feedDto = new FeedDto();

                                notificationFeedDto = new NotificationFeedDto();
                                notificationFeedDto.ListName = spDetail.Name;

                                

                                notificationFeedDto.Portal = spDetail.Url.Substring(spDetail.Url.LastIndexOf("/") + 1);
                                notificationFeedDto.Url = spDetail.Url;

                                foreach (XmlNode val in obj.ChildNodes)
                                {
                                    if (val.Name == "title")
                                    {
                                        //feedDto.Title = val.InnerText;
                                        notificationFeedDto.Title = val.InnerText;
                                    }

                                    if (val.Name == "link")
                                    {
                                        //feedDto.Link = val.InnerText;
                                        notificationFeedDto.LinkUrl = val.InnerText;
                                        if (isFeedFetch)
                                        {
                                            NotificationFeedDto dto = Constants.PreviousBindedData.Where(p => p.LinkUrl == notificationFeedDto.LinkUrl).FirstOrDefault();
                                            isRead = dto != null ? dto.isRead : false;
                                        }
                                    }

                                    if (val.Name == "author")
                                    {
                                        //feedDto.Author = val.InnerText;
                                        notificationFeedDto.Author = val.InnerText;
                                    }

                                    if (val.Name == "pubDate")
                                    {
                                        //feedDto.PublishedDate = val.InnerText;
                                        DateTime pubDate = Convert.ToDateTime(val.InnerText);
                                        notificationFeedDto.PublishedDate = pubDate.ToString(dateformat);
                                        if (pubDate > Constants.LastRunDateTime)
                                        {
                                            isAlertNeeded = true;
                                            Constants.LastRunDateTime = currentDateTime;
                                        }

                                        //notificationDto.FeedDtoList.Add(feedDto);
                                        notificationFeedDto.Link = "View";
                                        notificationFeedDto.isRead = isRead;
                                        notificationFeedDtoList.Add(notificationFeedDto);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //throw ex;
                }
                finally
                {
                    reader.Close();
                    //notificationDtoList.Add(notificationDto);
                }
            }
        }

        private void RetrieveFeeds(List<NotificationFeedDto> notificationFeedDtoList, string url, string linkUrl, string listName, bool isFeedFetch)
        {
            NotificationFeedDto notificationFeedDto = new NotificationFeedDto();
            {

                XmlTextReader reader = new XmlTextReader(linkUrl);
                XmlUrlResolver resolver = new XmlUrlResolver();

                resolver.Credentials = Constants.Credentials;
                reader.XmlResolver = resolver;

                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(reader);
                    bool isRead = false;

                    foreach (XmlNode xnc in doc.ChildNodes.Cast<XmlNode>().Where(p => p.Name.ToLower() == "rss").FirstOrDefault().ChildNodes)//.Cast<XmlNode>().Where(q=> q.Name.ToLower() == "item")
                    {
                        List<XmlNode> objList = xnc.Cast<XmlNode>().Where(p => p.Name.ToLower() == "item").ToList();
                        if (objList != null && objList.Count > 0)
                        {
                            foreach (XmlNode obj in objList)
                            {
                                notificationFeedDto = new NotificationFeedDto();
                                notificationFeedDto.ListName = listName;

                                notificationFeedDto.Portal = url.Substring(url.LastIndexOf("/") + 1);
                                notificationFeedDto.Url = url;

                                foreach (XmlNode val in obj.ChildNodes)
                                {
                                    if (val.Name == "title")
                                    {
                                        notificationFeedDto.Title = val.InnerText;
                                    }

                                    if (val.Name == "link")
                                    {
                                        notificationFeedDto.LinkUrl = val.InnerText;
                                        if (isFeedFetch)
                                        {
                                            NotificationFeedDto dto = Constants.PreviousBindedData.Where(p => p.LinkUrl == notificationFeedDto.LinkUrl).FirstOrDefault();
                                            isRead = dto != null ? dto.isRead : false;
                                        }
                                    }

                                    if (val.Name == "author")
                                    {
                                        notificationFeedDto.Author = val.InnerText;
                                    }

                                    if (val.Name == "pubDate")
                                    {
                                        DateTime pubDate = Convert.ToDateTime(val.InnerText);
                                        notificationFeedDto.PublishedDate = pubDate.ToString(dateformat);
                                        if (pubDate > Constants.LastRunDateTime)
                                        {
                                            isAlertNeeded = true;
                                            Constants.LastRunDateTime = currentDateTime;
                                        }

                                        notificationFeedDto.isRead = isRead;
                                        notificationFeedDto.Link = "View";
                                        notificationFeedDtoList.Add(notificationFeedDto);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //throw ex;
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        private void PopulateFeedGridView(bool isFirstTime = false)
        {
            #region Commented
            //if (!isBinded)
            //{
            //    lblListName.DataBindings.Add("Text", notificationDtoList, "ListName");
            //    dgvListFeedView.DataBindings.Add("DataSource", notificationDtoList, "FeedDtoList");
            //    //grpPortalName.DataBindings.Add("Text", notificationDtoList, "Portal");
            //    lblPortalName.DataBindings.Add("Text", notificationDtoList, "Portal");
            //    isBinded = true;
            //}
            //drFeeds.DataSource = notificationDtoList;
            #endregion

            if (Constants.UrlCollection.Count > 0)
            {
                List<NotificationFeedDto> notificationFeedDtoList = new List<NotificationFeedDto>();

                RetrieveFeeds(notificationFeedDtoList, true);

                //Add all previous unread alerts
                foreach (NotificationFeedDto unread in Constants.PreviousBindedData.Where(p => p.isRead == false))
                {
                    if (notificationFeedDtoList.Where(p => p.Link == unread.Link).FirstOrDefault() == null)
                    {
                        notificationFeedDtoList.Add(unread);
                    }
                }

                if (isAlertNeeded || isFirstTime || Constants.PreviousBindedData.Count != notificationFeedDtoList.Count)
                {
                    BindingListView<NotificationFeedDto> dataList =
                    new Equin.ApplicationFramework.BindingListView<NotificationFeedDto>(notificationFeedDtoList);
                    Constants.PreviousBindedData = notificationFeedDtoList;
                    //feedBindingSource.DataSource = dataList;
                    dgvInbox.DataSource = dataList;

                    isFirstTime = isFirstTime? !isFirstTime : isFirstTime;

                    NotificationWindow.PopupNotifier popup = new NotificationWindow.PopupNotifier();
                    popup.TitleText = "Notification Inbox";
                    popup.ContentText = "New updates available";
                    popup.Click += new EventHandler(popup_Click);
                    popup.Popup();
                }
            }
            else
            {
                pollTimer.Stop();
                Constants.LastRunDateTime = DateTime.MinValue; //Next time to bind data.
                NotificationWindow.PopupNotifier popup = new NotificationWindow.PopupNotifier();
                popup.TitleText = "Notification Inbox";
                popup.ContentText = "Please check your configuration in setting";
                popup.Click += new EventHandler(popup_Click);
                popup.Popup();
            }
        }

        void popup_Click(object sender, EventArgs e)
        {
            NotificationWindow.PopupNotifier popup = (NotificationWindow.PopupNotifier)sender;
            if (popup.ContentText == "Please check your configuration in setting")
            {
                pollTimer.Stop();
                frmSettings form = new frmSettings();
                form.ShowDialog();
                PopulateFeedGridView(true);
                pollTimer.Start();
            }
            else if (popup.ContentText == "New updates available")
            {
                this.Show();
                WindowState = FormWindowState.Normal;

                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void LoadPortals()
        {
            cmbPortal.Items.Clear();
            cmbLists.DataSource = null;
            foreach (string portal in Constants.UrlCollection)
                cmbPortal.Items.Add(portal);

            cmbPortal.SelectedIndex = -1;
        }
        #endregion

        private void btnCoPRead_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInbox.Rows.Count; i++)
            {
                ((ObjectView<NotificationFeedDto>)dgvInbox.Rows[i].DataBoundItem).Object.isRead = true;
                dgvInbox.Refresh();
            }
        }

        private void dgvInbox_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (!Convert.ToBoolean(dgvInbox.Rows[e.RowIndex].Cells[7].Value))
                    dgvInbox.Rows[e.RowIndex].DefaultCellStyle.Font = newNotificationFont;
                else
                    dgvInbox.Rows[e.RowIndex].DefaultCellStyle.Font = oldNotificationFont;
            }
        }
    }


}
