using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using SPConsole;

namespace SPWinForms
{
    public partial class frmSettings : Form
    {
        List<SPListDTO> spListDetailCollection = new List<SPListDTO>();
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            pnlUrlAdd.Visible = true;
            pnlListSelection.Visible = false;

            pnlListSelection.Location = new Point(207, 12);
            pnlListSelection.Size = new Size(469, 442);

            pnlUrlAdd.Location = new Point(207, 12);
            pnlUrlAdd.Size = new Size(469, 442);

            lblStatus.Visible = false;
            LoadAddedSites();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            string url = txtUrl.Text.Trim();
            

            if (!string.IsNullOrEmpty(url) && !Constants.UrlCollection.Contains(url))
            {
                if (url.Substring(url.Length - 1) == "/")
                {
                    url = url.Substring(0, url.Length - 2);
                }

                if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    try
                    {
                        lblStatus.Text = "Please wait while we authenticate you entry";
                        lblStatus.Visible = true;
                        


                        SPConsole.ListWebService.Lists list = new SPConsole.ListWebService.Lists();
                        list.Url = url + "/_vti_bin/Lists.asmx";

                        list.Credentials = Constants.Credentials;
                        //XmlNode result = list.GetList("Form Templates");
                        XmlNode result = list.GetListCollection();

                        Constants.UrlCollection.Add(url);
                        lstboxSites.Items.Add(url);
                        txtUrl.Text = string.Empty;

                        lblStatus.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Visible = false;
                        MessageBox.Show("Error: \n Either url entered is wrong (follow the eg format no '/' in the last) \n Or you do not have privilage to access");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter valid URL");
                }
            }
            else
            {
                MessageBox.Show("Site is already added. Please verify");
            }

            btnAdd.Enabled = true;
        }
        
        private void tvListCollection_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (Convert.ToString(e.Node.Tag) != "0")
            {
                Constants.SPSettings.Where(p => p.Url == Convert.ToString(e.Node.Tag) && p.ListId == e.Node.Name).FirstOrDefault().isSubscribed = e.Node.Checked;

            }

            if (Convert.ToString(e.Node.Tag) == "0")
            {
                if (e.Node.Nodes.Count > 0)
                {
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        node.Checked = e.Node.Checked;
                    }
                }
            }
        }

        private void lnkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlUrlAdd.Visible = true;
            pnlListSelection.Visible = false;
        }

        private void lnkListSelection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlUrlAdd.Visible = false;
            pnlListSelection.Visible = true;

            PopulateTreeView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCredentialUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDomain.Text.Trim()) && !string.IsNullOrEmpty(txtUsername.Text.Trim()) && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                Constants.Domain = txtDomain.Text.Trim();
                Constants.Username = txtUsername.Text.Trim();
                Constants.Password = txtPassword.Text.Trim();
            }
            else
            {
                MessageBox.Show("Please fill all input fields");
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstboxSites.SelectedIndex > -1)
            {
                string url = lstboxSites.SelectedItem.ToString();
                if (Constants.UrlCollection.Contains(url))
                {
                    Constants.UrlCollection.Remove(url);

                    List<SPListDTO> deleteSettingList = Constants.SPSettings.Where(p => p.Url == url).ToList();
                    if (deleteSettingList.Count > 0)
                        deleteSettingList.ForEach(p => Constants.SPSettings.Remove(p));
                    
                    List<NotificationFeedDto> deleteList = Constants.PreviousBindedData.Where(p => p.Url == url).ToList();

                    if (deleteList.Count > 0)
                        deleteList.ForEach(p => Constants.PreviousBindedData.Remove(p));

                    lstboxSites.Items.Remove(url);
                }
            }
        }

        #region Private methods
       
        private void LoadAddedSites()
        {
            if (Constants.UrlCollection.Count > 0)
            {
                lstboxSites.Items.Clear();
                foreach (string url in Constants.UrlCollection)
                    lstboxSites.Items.Add(url);
            }
        }

        private void PopulateTreeView()
        {
            try
            {
                foreach (string url in Constants.UrlCollection)
                {
                    SPListDTO spListObj = new SPListDTO();
                    //string url = "http://sharepoint2010:1857/";
                    SPConsole.ListWebService.Lists list = new SPConsole.ListWebService.Lists();
                    list.Url = url + "/_vti_bin/Lists.asmx";

                    list.Credentials = Constants.Credentials;
                    XmlNode listCollection = list.GetListCollection();
                    //list.GetListItems("pages", null, null, null, null, null, null);

                    if (Constants.SPSettings.Where(p => p.Name == url).FirstOrDefault() != null)
                    {
                        spListObj = new SPListDTO();
                        spListObj.Name = url;
                        spListObj.ListUrl = string.Empty;
                        spListObj.Url = url;
                        spListObj.FeedUrl = url;
                        Constants.SPSettings.Add(spListObj);
                    }

                    tvListCollection.CheckBoxes = true;
                    TreeNode parentNode = null;
                    if (tvListCollection.Nodes.Count > 0)
                    {
                        if (tvListCollection.Nodes.ContainsKey(url))
                        {
                            parentNode = tvListCollection.Nodes[url];
                        }
                        else
                        {
                            parentNode = new TreeNode();
                            tvListCollection.Nodes.Add(parentNode);

                        }
                    }
                    else
                    {
                        parentNode = new TreeNode();
                        tvListCollection.Nodes.Add(parentNode);
                    }

                    TreeNode childNode = null;
                    parentNode.Text = url;
                    parentNode.Name = url;
                    parentNode.Tag = "0";

                    foreach (XmlNode node in listCollection)
                    {
                        if (node.Name == "List")
                        {
                            if (node.Attributes.Count > 0)
                            {
                                SPListDTO obj = Constants.SPSettings.Where(p => p.ListId == node.Attributes["ID"].Value).FirstOrDefault();
                                if (obj == null)
                                {
                                    spListObj = new SPListDTO();
                                    spListObj.ListId = node.Attributes["ID"].Value;
                                    spListObj.Name = node.Attributes["Title"].Value;
                                    spListObj.ListUrl = node.Attributes["DefaultViewUrl"].Value;
                                    spListObj.Url = url;
                                    spListObj.FeedUrl = string.Format("{0}/_layouts/listfeed.aspx?List={1}", url, node.Attributes["ID"].Value.Replace("-", "%2D"));
                                    Constants.SPSettings.Add(spListObj);

                                    childNode = new TreeNode();
                                    childNode.Text = spListObj.Name;
                                    childNode.Name = spListObj.ListId;
                                    childNode.Tag = url;
                                    parentNode.Nodes.Add(childNode);

                                }
                                else
                                {
                                    if (obj.Name.ToLower() != node.Attributes["Title"].Value.ToLower())
                                    {
                                        obj.Name = node.Attributes["Title"].Value;

                                    }
                                    TreeNode cn = parentNode.Nodes[node.Attributes["ID"].Value];
                                    if (cn != null)
                                        parentNode.Nodes[node.Attributes["ID"].Value].Checked = obj.isSubscribed;
                                    else
                                    {
                                        childNode = new TreeNode();
                                        childNode.Text = obj.Name;
                                        childNode.Name = obj.ListId;
                                        childNode.Tag = url;
                                        childNode.Checked = obj.isSubscribed;
                                        parentNode.Nodes.Add(childNode);
                                    }
                                }
                            }
                        }
                    }


                }

                tvListCollection.ExpandAll();
                //http://sharepoint2010:1857/_layouts/listfeed.aspx?List=AA073D56%2D94BB%2D4C18%2DB398%2D02186200D9A3
                //http://sharepoint2010:1857/_layouts/listfeed.aspx?List=aa073d56%2D94bb%2D4c18%2Db398%2D02186200d9a3

                //http://sharepoint2010:1857/_layouts/listfeed.aspx?List=bfe3c57a%2D41c0%2D4225%2D8076%2D95f6d567a624
                //http://sharepoint2010:1857/_layouts/listfeed.aspx?List=066c90c0%2D586b%2D45af%2Db20b%2Dc4975ac1bf24
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            Constants.Username = string.Empty;
            Constants.Password = string.Empty;
            Constants.Domain = string.Empty;
        }

    }


}
