using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPConsole
{
    public class SPListDTO
    {
        //public int Id { get; set; }
        //public int ParentId { get; set; }
        public string ListId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ListUrl { get; set; }
        public string FeedUrl { get; set; }
        public bool isSubscribed { get; set; }
    }

    public class NotificationDto
    {
        public string Portal { get; set; }
        public string ListName { get; set; }
        public List<FeedDto> FeedDtoList { get; set; }
    }

    public class NotificationFeedDto
    {
        public string Portal { get; set; }
        public string ListName { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string LinkUrl { get; set; }
        public string Author { get; set; }
        public string PublishedDate { get; set; }
        public bool isRead { get; set; }

        public string Url { get; set; }
    }

    public class FeedDto
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Author { get; set; }
        public string PublishedDate { get; set; }
    }

    
}
