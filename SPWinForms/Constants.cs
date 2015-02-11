using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace SPConsole
{
    public static class Constants
    {
        public static List<SPListDTO> SPSettings = new List<SPListDTO>();
        public static string Username;
        public static string Password;
        public static string Domain;

        public static List<string> UrlCollection = new List<string>();
        public static DateTime LastRunDateTime = DateTime.MinValue;
        public static List<NotificationFeedDto> PreviousBindedData = new List<NotificationFeedDto>();

        public static NetworkCredential Credentials
        {
            get
            {
                NetworkCredential nc = null;
                if (string.IsNullOrEmpty(Constants.Username))
                {
                    nc = System.Net.CredentialCache.DefaultNetworkCredentials;
                }
                else
                {
                    nc = new NetworkCredential(Constants.Username, Constants.Password, Constants.Domain);
                }

                return nc;
            }
        }
    }
}
