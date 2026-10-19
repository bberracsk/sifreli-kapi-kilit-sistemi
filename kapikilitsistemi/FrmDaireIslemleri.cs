using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kapikilitsistemi
{
    public partial class FrmDaireIslemleri : Form
    {
        string connString =
        "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ApartmanOtomasyon;Integrated Security=True";

        public FrmDaireIslemleri()
        {
            InitializeComponent();
        }

        void Listele()
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM Daireler", connString);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvDaireler.DataSource = dt;
        }

        private void dgvDaireler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDaireler.CurrentRow == null)
                return;

            txtDaireNo.Text =
            dgvDaireler.CurrentRow.Cells["DaireNo"].Value.ToString();

            txtDaireSahibi.Text =
            dgvDaireler.CurrentRow.Cells["DaireSahibi"].Value.ToString();

            txtSifre.Text =
            dgvDaireler.CurrentRow.Cells["Sifre"].Value.ToString();

            cmbDurum.Text =
            dgvDaireler.CurrentRow.Cells["Durum"].Value.ToString();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn =
            new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd;

                if (cmbDurum.Text == "Boş")
                {
                    cmd = new SqlCommand(
                    "UPDATE Daireler SET " +
                    "DaireSahibi=NULL, " +
                    "Sifre=NULL, " +
                    "Durum='Boş' " +
                    "WHERE DaireNo=@d",
                    conn);

                    cmd.Parameters.AddWithValue("@d",
                    txtDaireNo.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Daire Boşaltıldı");
                }
                else
                {
                    cmd = new SqlCommand(
                    "UPDATE Daireler SET " +
                    "DaireSahibi=@k, " +
                    "Sifre=@s, " +
                    "Durum='Dolu' " +
                    "WHERE DaireNo=@d",
                    conn);

                    cmd.Parameters.AddWithValue("@d",
                    txtDaireNo.Text);

                    cmd.Parameters.AddWithValue("@k",
                    txtDaireSahibi.Text);

                    cmd.Parameters.AddWithValue("@s",
                    txtSifre.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Daire Güncellendi");
                }

                Listele();
                txtDaireNo.Clear();
                txtDaireSahibi.Clear();
                txtSifre.Clear();
                cmbDurum.Text = "";
            }
        }

        private void cmbDurum_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            bool bos = cmbDurum.Text == "Boş";
           
        }

        private void FrmDaireIslemleri_Load_1(object sender, EventArgs e)
        {
            dgvDaireler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDaireler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvDaireler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDaireler.AllowUserToAddRows = false;
            dgvDaireler.ReadOnly = true;
            Listele();
        }
    }
}