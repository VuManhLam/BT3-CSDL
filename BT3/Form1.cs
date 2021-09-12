using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class MainForm : Form
    {
        private readonly NewsFeedManager _newsManager;
        private object _newManager;
        private object pnlNews;

        public NewsFeedManager NewsManager => NewsManager1;

        public object NewManager { get => NewManager1; set => NewManager1 = value; }
        public object PnlNews { get => PnlNews1; set => PnlNews1 = value; }

        public NewsFeedManager NewsManager1 => _newsManager;

        public object NewManager1 { get => _newManager; set => _newManager = value; }
        public object PnlNews1 { get => pnlNews; set => pnlNews = value; }

        public NewsFeedManager NewsManager2 => _newsManager;

        public object NewManager2 { get => _newManager; set => _newManager = value; }
        public object PnlNews2 { get => pnlNews; set => pnlNews = value; }

        public MainForm(NewsFeedManager newManager)
        {
            _newsManager = newManager;
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowFeedOnTreeView(NewsManager.GetNewsFeed());
           
        }

        private void ShowFeedOnTreeView(List<Publisher> publishers)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new AddFeedFrom(NewsManager);
            dialog.ShowDialog(this);

            if (dialog.HasChanges)
            {
                NewsManager.HasChanges();
                ShowFeedOnTreeView(NewsManager.GetNewsFeed());
            }    
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tvwPublisher.SelectedNode == null) return;

            if (tvwPublisher.SelectedNode.Level == 0)
            {
                NewsManager.RemovePublisher(tvwPublisher.SelectedNode.Text);
            }
            else
            {
                var publisherNode = tvwPublisher.SelectedNode.Parent;
                NewsManager.RemoveCategory(publisherNode.Text, tvwPublisher.SelectedNode.Text);

            }
            tvwPublisher.SelectedNode.Remove(); 
        }
        
        
        
    }
}

