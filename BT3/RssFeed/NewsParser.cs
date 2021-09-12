using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace BT3.RssFeed
{
    public class NewsParser
    {
       

        internal List<Article> ParseXml(object feedData)
        {
            throw new NotImplementedException();
        }

        private string StripHtml(string content)
        {
            return Regex.Replace(content, "<.*?", String.Empty).Trim();
        }
        private DateTime ParseDate(string dateStr)
        {
            try
            {
                return DateTime.Parse(dateStr);
            }
            catch
            {
                return DateTime.Now;
            }
        }
    }
}
