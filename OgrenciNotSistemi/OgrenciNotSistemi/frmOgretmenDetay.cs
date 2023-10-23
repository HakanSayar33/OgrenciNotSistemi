using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciNotSistemi
{
    public partial class frmOgretmenDetay : Form
    {
        public frmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=DbNotKayıt;Integrated Security=True");
        private void frmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayıtDataSet.tblOgr' table. You can move, or remove it, as needed.
            this.tblOgrTableAdapter.Fill(this.dbNotKayıtDataSet.tblOgr);
            baglanti.Open();
            SqlCommand gecen = new SqlCommand("Select Count(DURUM) From tblOgr where DURUM='True'", baglanti);
            SqlCommand kalan = new SqlCommand("Select Count(DURUM) From tblOgr where DURUM='False'", baglanti);
            lblGecenSayisi.Text = (gecen.ExecuteScalar()).ToString();
            lblKalanSayisi.Text = (kalan.ExecuteScalar()).ToString();
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand ("insert into tblOgr (ogrNumara,ogrAd,ogrSoyad) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", mskNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci sisteme eklendi");
            this.tblOgrTableAdapter.Fill(this.dbNotKayıtDataSet.tblOgr);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtSınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }
        string durum;
        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama,s1,s2,s3;
            
            s1 = Convert.ToDouble(txtSınav1.Text);
            s2 = Convert.ToDouble(txtSınav2.Text);
            s3 = Convert.ToDouble(txtSınav3.Text);

            ortalama = (s1+ s2 + s3)/3;
            lblOrtalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut
                = new SqlCommand("update tblOgr set ogrS1=@p1,ogrS2=@p2,ogrS3=@p3,ortalama=@p4,durum=@p5 where ogrnumara=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSınav1.Text);
            komut.Parameters.AddWithValue("@p2", txtSınav2.Text);
            komut.Parameters.AddWithValue("@p3", txtSınav3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblOrtalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", mskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci notları güncellendi");
            this.tblOgrTableAdapter.Fill(this.dbNotKayıtDataSet.tblOgr);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand gecen = new SqlCommand("Select Count(DURUM) From TBLDERS where DURUM='True'", baglanti);
            SqlCommand kalan = new SqlCommand("Select Count(DURUM) From TBLDERS where DURUM='False'", baglanti);
            lblGecenSayisi.Text = (gecen.ExecuteScalar()).ToString();
            lblKalanSayisi.Text = (kalan.ExecuteScalar()).ToString();
            baglanti.Close();
        }
    }
}
