﻿namespace Zenithzens_PamerYuk_DB
{
    partial class FormUtama
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kisahHidupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permintaanPertemananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarTemanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "username";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.friendToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kisahHidupToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // kisahHidupToolStripMenuItem
            // 
            this.kisahHidupToolStripMenuItem.Name = "kisahHidupToolStripMenuItem";
            this.kisahHidupToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.kisahHidupToolStripMenuItem.Text = "Kisah Hidup";
            this.kisahHidupToolStripMenuItem.Click += new System.EventHandler(this.kisahHidupToolStripMenuItem_Click);
            // 
            // friendToolStripMenuItem
            // 
            this.friendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cariToolStripMenuItem,
            this.permintaanPertemananToolStripMenuItem,
            this.daftarTemanToolStripMenuItem});
            this.friendToolStripMenuItem.Name = "friendToolStripMenuItem";
            this.friendToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.friendToolStripMenuItem.Text = " Teman";
            // 
            // cariToolStripMenuItem
            // 
            this.cariToolStripMenuItem.Name = "cariToolStripMenuItem";
            this.cariToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cariToolStripMenuItem.Text = "Cari Teman";
            this.cariToolStripMenuItem.Click += new System.EventHandler(this.cariToolStripMenuItem_Click);
            // 
            // permintaanPertemananToolStripMenuItem
            // 
            this.permintaanPertemananToolStripMenuItem.Name = "permintaanPertemananToolStripMenuItem";
            this.permintaanPertemananToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.permintaanPertemananToolStripMenuItem.Text = "Permintaan Pertemanan";
            this.permintaanPertemananToolStripMenuItem.Click += new System.EventHandler(this.permintaanPertemananToolStripMenuItem_Click);
            // 
            // daftarTemanToolStripMenuItem
            // 
            this.daftarTemanToolStripMenuItem.Name = "daftarTemanToolStripMenuItem";
            this.daftarTemanToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.daftarTemanToolStripMenuItem.Text = "Daftar Teman";
            this.daftarTemanToolStripMenuItem.Click += new System.EventHandler(this.daftarTemanToolStripMenuItem_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(512, 0);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUtama";
            this.Text = "PamerYuk";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kisahHidupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem friendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permintaanPertemananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarTemanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}

