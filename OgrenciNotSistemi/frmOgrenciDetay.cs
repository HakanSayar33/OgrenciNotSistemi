using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemi
{
    public partial class frmOgrenciDetay : Form
    {
        public frmOgrenciDetay()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=DbNotKayıt;Integrated Security=True");

        private void frmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblOgr where ogrnumara=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",lblNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblSınav1.Text = dr[4].ToString();
                lblSınav2.Text = dr[5].ToString();
                lblSınav3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                lblDurum.Text = dr[8].ToString();
            }
            baglanti.Close();
        }
    }
}
