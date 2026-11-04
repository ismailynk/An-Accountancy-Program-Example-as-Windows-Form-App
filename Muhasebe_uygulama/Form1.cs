using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Muhasebe_uygulama{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string constr2; 
        OleDbConnection baglantı;
        private void giris() {
            constr2 = dbtool.constr2;
            baglantı = new OleDbConnection(constr2);
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText=("Select * From kullanici where kadi = '"+adtxt.Text.ToString()+ "' and sifre = '" + passtxt.Text.ToString() + "'");
            OleDbDataReader oku = komut.ExecuteReader();
           
            if (oku.Read()==true)
            {
                dbtool.bilgiform.ad= oku["ad"].ToString();
                dbtool.bilgiform.id = oku["id"].ToString();
                dbtool.bilgiform.kadı = oku["kadi"].ToString();
                dbtool.bilgiform.sifre = oku["sifre"].ToString();
                dbtool.kayıtekran.kullanici = oku["ad"].ToString();
                dbtool.kayıtekran.Show();
                this.Hide();
            }
            else
            {
                passtxt.Clear();
                adtxt.Clear();
                MessageBox.Show("Kullanıcı adı veya parola yanlış. Lütfen tekrar deneyiniz.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            baglantı.Close();
        }
        private void cek_Click(object sender, EventArgs e)
        {
            giris();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
