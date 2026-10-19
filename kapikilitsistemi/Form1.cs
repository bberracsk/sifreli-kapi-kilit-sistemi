using System;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Windows.Forms;

namespace kapikilitsistemi
{
    public partial class Form1 : Form
    {
        string connString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ApartmanOtomasyon;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM8";
            serialPort1.BaudRate = 9600;
            serialPort1.DataReceived += serialPort1_DataReceived;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen) serialPort1.Open();
                LogEkle("Sistem hazır");
            }
            catch (Exception ex) { MessageBox.Show("COM hata: " + ex.Message); }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort1.ReadLine().Trim();

                this.Invoke(new Action(() =>
                {
                    if (data.StartsWith("DAIRE:"))
                    {
                        string dNo = data.Replace("DAIRE:", "");
                        DaireOnKontrol(dNo);
                    }
                    else
                    {
                        Kontrol(data);
                    }
                }));
            }
            catch { }
        }

        private void DaireOnKontrol(string daireNo)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Durum FROM Daireler WHERE DaireNo=@d", conn);
                cmd.Parameters.AddWithValue("@d", daireNo);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string durum = dr["Durum"].ToString();
                    dr.Close();

                    if (durum == "Boş")
                    {
                        serialPort1.WriteLine("BOS");
                        LogEkle($"BOS DAIRE - Daire:{daireNo}"); // Eski sade format
                    }
                    else
                    {
                        serialPort1.WriteLine("OK");
                    }
                }
                else
                {
                    dr.Close();
                    serialPort1.WriteLine("YOK");
                    LogEkle($"DAİRE YOK - Daire:{daireNo}"); // Eski sade format
                }
            }
        }

        private void Kontrol(string veri)
        {
            string[] p = veri.Split(',');
            if (p.Length != 2)
            {
                LogEkle("Bozuk veri");
                return;
            }

            string daireNo = p[0].Trim();
            string sifre = p[1].Trim();

            txtDaire.Text = daireNo;
            txtSifre.Text = sifre;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Sifre, DaireSahibi FROM Daireler WHERE DaireNo=@d", conn);
                cmd.Parameters.AddWithValue("@d", daireNo);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string dogruSifre = dr["Sifre"].ToString();
                    string daireSahibi = dr["DaireSahibi"].ToString();
                    txtDogruSifre.Text = dogruSifre;
                    txtDaireSahibi.Text = daireSahibi;

                    if (sifre == dogruSifre)
                    {
                        serialPort1.WriteLine("1");
                        LogEkle($"BAŞARILI - Daire:{daireNo} - {daireSahibi} - Şifre:{sifre}");
                        LogKaydet(daireNo, daireSahibi, "Basarili");
                    }
                    else
                    {
                        serialPort1.WriteLine("0");
                        LogEkle($"HATALI - Daire:{daireNo} - {daireSahibi} - Şifre:{sifre}");
                        LogKaydet(daireNo, daireSahibi, "Hatali");
                    }
                }
                dr.Close();
            }
        }

        private void LogKaydet(string daireNo, string daireSahibi, string durum)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO GirisLoglari (DaireNo, DaireSahibi, Durum) VALUES (@d, @k, @durum)", conn);
                cmd.Parameters.AddWithValue("@d", daireNo);
                cmd.Parameters.AddWithValue("@k", daireSahibi);
                cmd.Parameters.AddWithValue("@durum", durum);
                cmd.ExecuteNonQuery();
            }
        }

        // --- İSTEDİĞİNİZ ESKİ LOG FORMATI ---
        private void LogEkle(string msg)
        {
            lbx_loglar.Items.Add("[" + DateTime.Now.ToLongTimeString() + "] " + msg);
            lbx_loglar.TopIndex = lbx_loglar.Items.Count - 1;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
            base.OnFormClosing(e);
        }

        private void btn_daireislem_Click(object sender, EventArgs e)
        {
            new FrmDaireIslemleri().ShowDialog();
        }
    }
}