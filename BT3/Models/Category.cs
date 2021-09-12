using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public class Category
    {
        public string Name { get; set; }
        public string RssLink { get; set; }
        public List<Article> Article { get; set; }
        public object Articles { get; internal set; }

        public Category()
        {
            Article = new List<Article>();
        }

    }
}