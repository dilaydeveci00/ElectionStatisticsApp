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


namespace Veri_Tabanlı_Parti_Seçim_Grafik_İstatistik
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        

        
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-93QGIB63\\SQLEXPRESS;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" insert into TBLILCE (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtilceAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtA.Text);
            komut.Parameters.AddWithValue("@p3", TxtB.Text);
            komut.Parameters.AddWithValue("@p4", TxtC.Text);
            komut.Parameters.AddWithValue("@p5", TxtD.Text);
            komut.Parameters.AddWithValue("@p6", TxtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti.");


        }

        

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();

        }
    }
}
