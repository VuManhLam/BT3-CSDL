using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3.Components
{
    public partial class New : UserControl
    {
        public New()
        {
            InitializeComponent();
        }
        public void SetArticle(Article news)
        {
            lblTitle.Text = news.Title;
            lblDescription.Text = news.Description;
            lblPublishedDate.Text = news.PublishedDate.ToString("dd/MM/yyyy HH:mm");
            lblDetail.LinkClicked += (sender, args) =>
            {
                Process.Start(news.Link);
            };

        }
    }
}
