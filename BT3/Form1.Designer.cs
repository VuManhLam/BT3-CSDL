﻿
using System;
using System.Windows.Forms;

namespace BT3
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tvwPublisher = new System.Windows.Forms.TreeView();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn và soạn chyên mục";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(233, 28);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(32, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tvwPublisher
            // 
            this.tvwPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwPublisher.Location = new System.Drawing.Point(12, 94);
            this.tvwPublisher.Name = "tvwPublisher";
            this.tvwPublisher.Size = new System.Drawing.Size(269, 343);
            this.tvwPublisher.TabIndex = 4;
            this.tvwPublisher.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwPublisher_AfterSelect);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(297, 94);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(491, 355);
            this.panel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tvwPublisher);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Quản lí tin tức";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tvwPublisher_AfterSelect(object sender, TreeViewEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TreeView tvwPublisher;
        private System.Windows.Forms.Panel panel;
    }
}

