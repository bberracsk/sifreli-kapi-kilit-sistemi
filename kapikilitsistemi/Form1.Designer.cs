namespace kapikilitsistemi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtDogruSifre = new System.Windows.Forms.TextBox();
            this.lbl_dogrusifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lbl_girilensifre = new System.Windows.Forms.Label();
            this.txtDaire = new System.Windows.Forms.TextBox();
            this.lbl_daireno = new System.Windows.Forms.Label();
            this.lbx_loglar = new System.Windows.Forms.ListBox();
            this.txtDaireSahibi = new System.Windows.Forms.TextBox();
            this.lblDaireSahibi = new System.Windows.Forms.Label();
            this.btn_daireislem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtDogruSifre
            // 
            this.txtDogruSifre.Location = new System.Drawing.Point(205, 213);
            this.txtDogruSifre.Name = "txtDogruSifre";
            this.txtDogruSifre.Size = new System.Drawing.Size(175, 22);
            this.txtDogruSifre.TabIndex = 32;
            // 
            // lbl_dogrusifre
            // 
            this.lbl_dogrusifre.AutoSize = true;
            this.lbl_dogrusifre.Location = new System.Drawing.Point(90, 219);
            this.lbl_dogrusifre.Name = "lbl_dogrusifre";
            this.lbl_dogrusifre.Size = new System.Drawing.Size(77, 16);
            this.lbl_dogrusifre.TabIndex = 31;
            this.lbl_dogrusifre.Text = "Doğru Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(205, 175);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(175, 22);
            this.txtSifre.TabIndex = 30;
            // 
            // lbl_girilensifre
            // 
            this.lbl_girilensifre.AutoSize = true;
            this.lbl_girilensifre.Location = new System.Drawing.Point(90, 175);
            this.lbl_girilensifre.Name = "lbl_girilensifre";
            this.lbl_girilensifre.Size = new System.Drawing.Size(78, 16);
            this.lbl_girilensifre.TabIndex = 29;
            this.lbl_girilensifre.Text = "Girilen Şifre:";
            // 
            // txtDaire
            // 
            this.txtDaire.Location = new System.Drawing.Point(205, 96);
            this.txtDaire.Name = "txtDaire";
            this.txtDaire.Size = new System.Drawing.Size(175, 22);
            this.txtDaire.TabIndex = 28;
            // 
            // lbl_daireno
            // 
            this.lbl_daireno.AutoSize = true;
            this.lbl_daireno.Location = new System.Drawing.Point(90, 96);
            this.lbl_daireno.Name = "lbl_daireno";
            this.lbl_daireno.Size = new System.Drawing.Size(64, 16);
            this.lbl_daireno.TabIndex = 27;
            this.lbl_daireno.Text = "Daire No:";
            // 
            // lbx_loglar
            // 
            this.lbx_loglar.FormattingEnabled = true;
            this.lbx_loglar.ItemHeight = 16;
            this.lbx_loglar.Location = new System.Drawing.Point(482, 96);
            this.lbx_loglar.Name = "lbx_loglar";
            this.lbx_loglar.Size = new System.Drawing.Size(439, 148);
            this.lbx_loglar.TabIndex = 26;
            // 
            // txtDaireSahibi
            // 
            this.txtDaireSahibi.Location = new System.Drawing.Point(205, 132);
            this.txtDaireSahibi.Name = "txtDaireSahibi";
            this.txtDaireSahibi.Size = new System.Drawing.Size(175, 22);
            this.txtDaireSahibi.TabIndex = 35;
            // 
            // lblDaireSahibi
            // 
            this.lblDaireSahibi.AutoSize = true;
            this.lblDaireSahibi.Location = new System.Drawing.Point(90, 135);
            this.lblDaireSahibi.Name = "lblDaireSahibi";
            this.lblDaireSahibi.Size = new System.Drawing.Size(84, 16);
            this.lblDaireSahibi.TabIndex = 34;
            this.lblDaireSahibi.Text = "Daire Sahibi:";
            // 
            // btn_daireislem
            // 
            this.btn_daireislem.Location = new System.Drawing.Point(86, 311);
            this.btn_daireislem.Name = "btn_daireislem";
            this.btn_daireislem.Size = new System.Drawing.Size(835, 44);
            this.btn_daireislem.TabIndex = 36;
            this.btn_daireislem.Text = "Daire İşlemleri İçin Tıklayınız";
            this.btn_daireislem.UseVisualStyleBackColor = true;
            this.btn_daireislem.Click += new System.EventHandler(this.btn_daireislem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 628);
            this.Controls.Add(this.btn_daireislem);
            this.Controls.Add(this.txtDaireSahibi);
            this.Controls.Add(this.lblDaireSahibi);
            this.Controls.Add(this.txtDogruSifre);
            this.Controls.Add(this.lbl_dogrusifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lbl_girilensifre);
            this.Controls.Add(this.txtDaire);
            this.Controls.Add(this.lbl_daireno);
            this.Controls.Add(this.lbx_loglar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtDogruSifre;
        private System.Windows.Forms.Label lbl_dogrusifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lbl_girilensifre;
        private System.Windows.Forms.TextBox txtDaire;
        private System.Windows.Forms.Label lbl_daireno;
        private System.Windows.Forms.ListBox lbx_loglar;
        private System.Windows.Forms.TextBox txtDaireSahibi;
        private System.Windows.Forms.Label lblDaireSahibi;
        private System.Windows.Forms.Button btn_daireislem;
    }
}

