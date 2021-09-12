using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BT3.RssFeed
{
    public class RssReader
    {
        private readonly NewsParser _paser;

        public RssReader(NewsParser parser)
        {
            _paser = parser;
        }

        public List<Article>GetNews(string rssLink)
        {
            var feedData = DownloadFeed(rssLink);
            return _paser.ParseXml(feedData);
        }

        private string DownloadFeed(string rssLink)
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8
            };
            return client.DownloadString(rssLink);
        }
    }
}
