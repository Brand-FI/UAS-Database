namespace Zenithzens_PamerYuk_DB_Form
{
    partial class FormTeman
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
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCariTeman = new System.Windows.Forms.TextBox();
            this.comboBoxCariTeman = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(11, 89);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(778, 350);
            this.dataGridViewUser.TabIndex = 11;
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCariTeman);
            this.panel1.Controls.Add(this.comboBoxCariTeman);
            this.panel1.Location = new System.Drawing.Point(11, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 54);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCariTeman
            // 
            this.textBoxCariTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCariTeman.Location = new System.Drawing.Point(448, 22);
            this.textBoxCariTeman.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCariTeman.Name = "textBoxCariTeman";
            this.textBoxCariTeman.Size = new System.Drawing.Size(319, 21);
            this.textBoxCariTeman.TabIndex = 2;
            this.textBoxCariTeman.TextChanged += new System.EventHandler(this.textBoxCariTeman_TextChanged);
            // 
            // comboBoxCariTeman
            // 
            this.comboBoxCariTeman.FormattingEnabled = true;
            this.comboBoxCariTeman.Items.AddRange(new object[] {
            "Organisasi",
            "Semua"});
            this.comboBoxCariTeman.Location = new System.Drawing.Point(190, 22);
            this.comboBoxCariTeman.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCariTeman.Name = "comboBoxCariTeman";
            this.comboBoxCariTeman.Size = new System.Drawing.Size(162, 21);
            this.comboBoxCariTeman.TabIndex = 1;
            this.comboBoxCariTeman.SelectedIndexChanged += new System.EventHandler(this.comboBoxCariTeman_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "CARI TEMAN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormTeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.panel1);
            this.Name = "FormTeman";
            this.Text = "FormTeman";
            this.Load += new System.EventHandler(this.FormTeman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCariTeman;
        private System.Windows.Forms.ComboBox comboBoxCariTeman;
        private System.Windows.Forms.Label label2;
    }
}