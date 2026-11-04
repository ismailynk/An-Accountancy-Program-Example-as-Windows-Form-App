using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Muhasebe_uygulama
{
    public partial class kullanici_bilgi : Form
    {
        public kullanici_bilgi()
        {
            InitializeComponent();
        }
        public static String constr = dbtool.constr2;
        OleDbConnection con = new OleDbConnection(constr);
        OleDbCommand cmd;
        public  string ad;
        public string kadı;
        public string id;
        public string sifre;
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (siticoneTextBox3.Text.ToString().Equals(siticoneTextBox5.Text.ToString()))
            {
                giris();
            }
            else
            {

                MessageBox.Show("Yeni Şifreniz Birbiri ile Aynı Değil, Lütfen Yeni Şifrenizi Tekrar Giriniz", "Deneme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void giris()
        {
            if (sifre.Equals(siticoneTextBox4.Text.ToString()))
            {
                guncelle_sifre();
                MessageBox.Show("Şifreniz Başarıyla Değişmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                siticoneTextBox4.Clear();

                MessageBox.Show("Mevcut Parola Yanlış. Lütfen tekrar deneyiniz.", "Deneme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void kullanici_bilgi_Load(object sender, EventArgs e)
        {
            siticoneTextBox1.Text = ad;
            siticoneTextBox2.Text = kadı;
            label9.Text = ad;
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            siticoneTextBox1.Text = ad;
            siticoneTextBox2.Text = kadı;
            this.Hide();
            dbtool.rapor.Show();
        }
        private void kayıt_ekranı_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            siticoneTextBox1.Text = ad;
            siticoneTextBox2.Text = kadı;
            this.Hide();
            dbtool.kayıtekran.Show();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            guncelle();
        }
        private void guncelle()
        {
            if (id != null)
            {
                try
                {
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update kullanici set ad='" + siticoneTextBox1.Text.ToString() +
                        "',kadi = '" + siticoneTextBox2.Text.ToString() +
                        "' where id=" + id + "";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("hata");
                    throw;
                }
                
                
            }
            else
            {
                MessageBox.Show("İd Tanımlı Değil", "Güncelleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void guncelle_sifre()
        {
            if (id != null)
            {
                try
                {
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update kullanici set sifre='" + siticoneTextBox3.Text.ToString() +
                        "' where id=" + id + "";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("hata");
                    throw;
                }


            }
            else
            {
                MessageBox.Show("İd Tanımlı Değil", "Güncelleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
