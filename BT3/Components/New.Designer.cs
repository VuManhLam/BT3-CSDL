
namespace BT3.Components
{
    partial class New
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPublishedDate = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Aqua;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(33, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Location = new System.Drawing.Point(33, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(337, 99);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label2";
            // 
            // lblPublishedDate
            // 
            this.lblPublishedDate.AutoSize = true;
            this.lblPublishedDate.Location = new System.Drawing.Point(33, 147);
            this.lblPublishedDate.Name = "lblPublishedDate";
            this.lblPublishedDate.Size = new System.Drawing.Size(46, 17);
            this.lblPublishedDate.TabIndex = 2;
            this.lblPublishedDate.Text = "label3";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(312, 147);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(72, 17);
            this.lblDetail.TabIndex = 3;
            this.lblDetail.TabStop = true;
            this.lblDetail.Text = "linkLabel1";
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblPublishedDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Name = "New";
            this.Size = new System.Drawing.Size(387, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPublishedDate;
        private System.Windows.Forms.LinkLabel lblDetail;
    }
}
