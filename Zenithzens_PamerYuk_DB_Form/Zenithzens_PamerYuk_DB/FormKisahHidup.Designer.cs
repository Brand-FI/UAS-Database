﻿namespace Zenithzens_PamerYuk_DB_Form
{
    partial class FormKisahHidup
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
            this.labelDaftar = new System.Windows.Forms.Label();
            this.dataGridViewKisah = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisah)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDaftar
            // 
            this.labelDaftar.BackColor = System.Drawing.Color.Black;
            this.labelDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDaftar.Location = new System.Drawing.Point(1, -2);
            this.labelDaftar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDaftar.Name = "labelDaftar";
            this.labelDaftar.Size = new System.Drawing.Size(622, 63);
            this.labelDaftar.TabIndex = 25;
            this.labelDaftar.Text = "KISAH HIDUP";
            this.labelDaftar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewKisah
            // 
            this.dataGridViewKisah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKisah.Location = new System.Drawing.Point(24, 75);
            this.dataGridViewKisah.Name = "dataGridViewKisah";
            this.dataGridViewKisah.Size = new System.Drawing.Size(570, 274);
            this.dataGridViewKisah.TabIndex = 36;
            this.dataGridViewKisah.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKisah_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 31);
            this.button1.TabIndex = 37;
            this.button1.Text = "TAMBAH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 31);
            this.button2.TabIndex = 38;
            this.button2.Text = "SIMPAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormKisahHidup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewKisah);
            this.Controls.Add(this.labelDaftar);
            this.Name = "FormKisahHidup";
            this.Text = "FormKisahHidup";
            this.Activated += new System.EventHandler(this.FormKisahHidup_Activated);
            this.Load += new System.EventHandler(this.FormKisahHidup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDaftar;
        private System.Windows.Forms.DataGridView dataGridViewKisah;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}