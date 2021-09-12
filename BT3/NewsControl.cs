using System;
using System.Drawing;
using System.Windows.Forms;

namespace BT3
{
    internal class NewsControl
    {
        public NewsControl()
        {
        }

        public Size Size { get; internal set; }
        public DockStyle Dock { get; internal set; }

        internal void SetArticle(object article)
        {
            throw new NotImplementedException();
        }
    }
}