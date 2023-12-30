using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            frmOgrenciDetay frmOgr = new frmOgrenciDetay();
           
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            frmOgrenciDetay frmOgr = new frmOgrenciDetay();
            frmOgr.numara = maskedTextBox1.Text;
            frmOgr.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                frmOgretmenDetay frmOgretmen = new frmOgretmenDetay();
                frmOgretmen.Show();
            }
        }
    }
}
