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
    public partial class AddFeedFrom : Form
    {
        private readonly NewsFeedManager _newsManager;
        private object newManager;
        private object cbbPublishers;

        public bool HasChanges { get; set; }

        public AddFeedFrom(NewsFeedManager newsManager)
        {
            InitializeComponent();
        }

        public AddFeedFrom(object newManager)
        {
            this.newManager = newManager;
        }
        private void AddFeedForm_Load(object sender, EventArgs e)
        {
            var publishers = _newsManager.GetNewsFeed();
            foreach ( var publisher in publishers)
            {
                cbbPublisher.Items.Add(publisher.Name);
            }    
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            var PublisherName = cbbPublisher.Text;
            var CategoryName = txtCategoryName.Text;
            var RssLink = txtRssLink.Text;

            if ( string.IsNullOrWhiteSpace(PublisherName) ||
                string.IsNullOrWhiteSpace(CategoryName) ||
                string.IsNullOrWhiteSpace(RssLink))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Lỗi");
                return;
            }

            HasChanges = true;

            var success = _newsManager.AddCategory(PublisherName, CategoryName, RssLink, false);
            if (success)
            {
                ClearForm();
                return;
            }  
            if (MessageBox.Show("Chuyên mục này đã tồn tại, bạn có muốn cập nhật RSS Link không?","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _newsManager.AddCategory(PublisherName, CategoryName, RssLink, true);
            }
            ClearForm();
        }

        private void ClearForm()
        {
            cbbPublisher.Text = "";
            txtCategoryName.Text = "";
            txtRssLink.Text = "";
        }
    }
}
