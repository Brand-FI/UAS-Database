namespace Zenithzens_PamerYuk_DB_Form
{
    partial class FormTambahOrganisasi
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
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.comboBoxKota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(77, 57);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(171, 20);
            this.textBoxNama.TabIndex = 0;
            // 
            // comboBoxKota
            // 
            this.comboBoxKota.FormattingEnabled = true;
            this.comboBoxKota.Location = new System.Drawing.Point(97, 120);
            this.comboBoxKota.Name = "comboBoxKota";
            this.comboBoxKota.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKota.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Organisasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kota";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKeluar.Location = new System.Drawing.Point(11, 178);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(76, 40);
            this.buttonKeluar.TabIndex = 29;
            this.buttonKeluar.Text = "TUTUP";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSimpan.Location = new System.Drawing.Point(249, 178);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(76, 40);
            this.buttonSimpan.TabIndex = 28;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // FormTambahOrganisasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 229);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKota);
            this.Controls.Add(this.textBoxNama);
            this.Name = "FormTambahOrganisasi";
            this.Text = "FormTambahOrganisasi";
            this.Load += new System.EventHandler(this.FormTambahOrganisasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.ComboBox comboBoxKota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonSimpan;
    }
}