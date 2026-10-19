namespace kapikilitsistemi
{
    partial class FrmDaireIslemleri
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.txtDaireNo = new System.Windows.Forms.TextBox();
            this.txtDaireSahibi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.dgvDaireler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaireler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daire No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daire Sahibi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Daire Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durum:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(448, 132);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(228, 33);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Dolu",
            "Boş"});
            this.cmbDurum.Location = new System.Drawing.Point(722, 86);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(279, 24);
            this.cmbDurum.TabIndex = 5;
            // 
            // txtDaireNo
            // 
            this.txtDaireNo.Location = new System.Drawing.Point(184, 44);
            this.txtDaireNo.Name = "txtDaireNo";
            this.txtDaireNo.Size = new System.Drawing.Size(279, 22);
            this.txtDaireNo.TabIndex = 6;
            // 
            // txtDaireSahibi
            // 
            this.txtDaireSahibi.Location = new System.Drawing.Point(184, 84);
            this.txtDaireSahibi.Name = "txtDaireSahibi";
            this.txtDaireSahibi.Size = new System.Drawing.Size(279, 22);
            this.txtDaireSahibi.TabIndex = 7;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(722, 50);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(279, 22);
            this.txtSifre.TabIndex = 8;
            // 
            // dgvDaireler
            // 
            this.dgvDaireler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaireler.Location = new System.Drawing.Point(60, 216);
            this.dgvDaireler.Name = "dgvDaireler";
            this.dgvDaireler.RowHeadersWidth = 51;
            this.dgvDaireler.RowTemplate.Height = 24;
            this.dgvDaireler.Size = new System.Drawing.Size(1043, 418);
            this.dgvDaireler.TabIndex = 9;
            this.dgvDaireler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaireler_CellClick_1);
            // 
            // FrmDaireIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 668);
            this.Controls.Add(this.dgvDaireler);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtDaireSahibi);
            this.Controls.Add(this.txtDaireNo);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDaireIslemleri";
            this.Text = "Daire İşlemleri";
            this.Load += new System.EventHandler(this.FrmDaireIslemleri_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaireler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.TextBox txtDaireNo;
        private System.Windows.Forms.TextBox txtDaireSahibi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.DataGridView dgvDaireler;
    }
}