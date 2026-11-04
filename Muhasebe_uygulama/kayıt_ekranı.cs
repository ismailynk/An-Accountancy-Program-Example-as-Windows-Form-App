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
using System.Globalization;

namespace Muhasebe_uygulama
{
    public partial class kayıt_ekranı : Form
    {
        
        
        public static String constr = dbtool.constr;
       OleDbConnection con=new OleDbConnection(constr);
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public string id=null;
        
        public kayıt_ekranı()
        {
            InitializeComponent();
        }
        public String kullanici;
        private void kayıt_ekranı_Load(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            label10.Text =  kullanici;
            griddoldur();
            autodoldur();
        }
        void autodoldur() {
            con = new OleDbConnection(constr);
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kayit";
            con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection Collection1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection Collection2 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection Collection3 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection Collection4 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection Collection5 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection Collection6 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection Collection7 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection Collection8 = new AutoCompleteStringCollection();
            while (reader.Read())
            {

                Collection1.Add(reader[4].ToString());
                Collection2.Add(reader[5].ToString());
                Collection3.Add(reader[6].ToString());
                Collection4.Add(reader[7].ToString());
                Collection5.Add(reader[8].ToString()); Collection7.Add(reader[11].ToString());
                Collection8.Add(reader[12].ToString());
                Collection6.Add(reader[9].ToString());
               

            }
            textBox2.AutoCompleteCustomSource = Collection1;
            textBox3.AutoCompleteCustomSource = Collection2;
            textBox4.AutoCompleteCustomSource = Collection3;
            textBox5.AutoCompleteCustomSource = Collection4;
            textBox6.AutoCompleteCustomSource = Collection5;
            textBox7.AutoCompleteCustomSource = Collection6;
            textBox8.AutoCompleteCustomSource = Collection7;
            textBox1.AutoCompleteCustomSource = Collection8;

            reader.Close();
            con.Close();
           
        }
        


        private void kayıt_ekranı_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        Boolean kayıt_kontrol() {
            con.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = con;
            komut.CommandText = ("Select * From kayit where geldigiyer = '" + textBox2.Text.ToString() + "' and faturano = '" + textBox4.Text.ToString() + "'");
            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read()==true)
            {
              
                DialogResult result1 = MessageBox.Show("Evrak numarası ve Geldiği Yeri Aynı Değerlere Sahip, Konusu : '"+oku["konusu"]+"' olan Evrak bulunmakta. Yinede Kayıt Etmek istermisiniz","Yinede Kayıt Edilsinmi", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
                if (result1 == DialogResult.Yes)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            else
            {
                con.Close();
                return true;
            }
            
        }
        void kayıt()
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();

                cmd.Parameters.Add("@evraktarihi", OleDbType.DBDate).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@evrakgelistarihi", OleDbType.DBDate).Value = DateTime.Today;
                cmd.Parameters.Add("@gelissaati", OleDbType.DBTime).Value = DateTime.Now.TimeOfDay;
                cmd.Parameters.Add("@geldigiyer", OleDbType.BSTR).Value = textBox2.Text;
                cmd.Parameters.Add("@konusu", OleDbType.BSTR).Value = textBox3.Text;
                cmd.Parameters.Add("@faturano", OleDbType.BSTR).Value = textBox4.Text;
                cmd.Parameters.Add("@htfno", OleDbType.BSTR).Value = textBox5.Text;
                cmd.Parameters.Add("@talepno", OleDbType.BSTR).Value = textBox6.Text;
                cmd.Parameters.Add("@satınpersonel", OleDbType.BSTR).Value = textBox7.Text;
                cmd.Parameters.Add("@teslimkisi", OleDbType.BSTR).Value = kullanici;
                cmd.Parameters.Add("@yapılanislem", OleDbType.BSTR).Value = textBox8.Text;
                cmd.Parameters.Add("@acıklama", OleDbType.BSTR).Value = textBox1.Text;
                if (checkBox1.Checked)
                {
                    cmd.Parameters.Add("@islemtarih", OleDbType.DBDate).Value = dateTimePicker3.Value;
                }
                else
                {
                    cmd.Parameters.Add("@islemtarih", OleDbType.DBDate).Value = System.DBNull.Value;
                }
                cmd.CommandText = "insert into kayit"
                + "(evraktarihi,evrakgelistarihi,gelissaati,geldigiyer,konusu,faturano,htfno,talepno,satınpersonel,teslimkisi,yapılanislem,acıklama,islemtarih)"
                + "values"
                + "(@evraktarihi,@evrakgelistarihi,@gelissaati,@geldigiyer,@konusu,@faturano,@htfno,@talepno,@satınpersonel,@teslimkisi,@yapılanislem,@acıklama,@islemtarih)";

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Veri başarıyla kayıt edildi.", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Veri kayıt edilirken bir hata oluştu.", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            griddoldur();
            autodoldur();
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            if (kayıt_kontrol())
            {
                kayıt();
            }
            else
            {
                MessageBox.Show("Veri Kaydı İptal Edildi.", "Kayıt İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void vericek_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Value =DateTime.ParseExact(tarih(dataGridView1.CurrentRow.Cells[1].Value.ToString()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (dataGridView1.CurrentRow.Cells[13].Value.ToString() == "")
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
                dateTimePicker3.Value = DateTime.ParseExact(tarih(dataGridView1.CurrentRow.Cells[13].Value.ToString()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            guncelle.Enabled = true;
            label9.Text = "Seçili Öğe : " + id;
        }
        public string tarih(string tarih) {
            tarih = tarih.Replace('.', '/');
            String[] date = tarih.Split(' ');
            tarih = date[0];
            date = tarih.Split('/');
            if (date[0].Length < 2)
            {
                date[0] = "0" + date[0];
                return date[0] + "/" + date[1] + "/" + date[2];
            }
            else
            {
                return tarih;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
            autodoldur();
        }
        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox8.Clear();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker3.Value = DateTime.Today;
            guncelle.Enabled = false;
            checkBox1.Checked = false;
            id = null;
            label9.Text = "Seçili Öğe : " + id;
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                try
                {
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "update kayit set evraktarihi='" + dateTimePicker1.Value.ToShortDateString() +
                    "',geldigiyer = '" + textBox2.Text.ToString() +
                    "',konusu = '" + textBox3.Text.ToString() +
                    "',faturano = '" + textBox4.Text.ToString() +
                    "',htfno = '" + textBox5.Text.ToString() +
                    "',talepno = '" + textBox6.Text.ToString() +
                    "',satınpersonel = '" + textBox7.Text.ToString() +
                    "',yapılanislem = '" + textBox8.Text.ToString() +
                    "',acıklama = '" + textBox1.Text.ToString() +
                    "',islemtarih = @islemtarih where id=" + id + "";
                if (checkBox1.Checked)
                {
                    cmd.Parameters.Add("@islemtarih", OleDbType.DBDate).Value = dateTimePicker3.Value;
                }
                else
                {
                    cmd.Parameters.Add("@islemtarih", OleDbType.DBDate).Value = System.DBNull.Value;
                }
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Veri başarıyla güncellendi.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                griddoldur();
                }
                catch (Exception)
                {

                    MessageBox.Show("Beklenmeyen bir hata oluştu.", "Güncelleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                
               
            }
            else {
                MessageBox.Show("Beklenmeyen bir hata oluştu.","Güncelleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            autodoldur();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection(constr);
                da = new OleDbDataAdapter("SElect * from kayit where geldigiyer like '%" + textBox2.Text.ToString() +
                    "%' and konusu like '%" + textBox3.Text.ToString() +
                    "%'   and faturano like '%" + textBox4.Text.ToString() +
                    "%'   and htfno like '%" + textBox5.Text.ToString() +
                    "%'   and talepno like '%" + textBox6.Text.ToString() +
                    "%'   and satınpersonel like '%" + textBox7.Text.ToString() +
                    "%'   and yapılanislem like '%" + textBox8.Text.ToString() +
                    "%'   and acıklama like '%" + textBox1.Text.ToString() +
                    "%'   ", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "ogrenci");
                dataGridView1.DataSource = ds.Tables["ogrenci"];
                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.", "Arama Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
                      
        }
        void griddoldur()
        {
            con = new OleDbConnection(constr);
            da = new OleDbDataAdapter("SElect * from kayit", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "fatura");
            dataGridView1.DataSource = ds.Tables["fatura"];
            con.Close();
            temizle();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker3.Enabled = true;
            }
            else
            {
                dateTimePicker3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            dbtool.rapor.autodoldur();
            dbtool.rapor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            dbtool.bilgiform.Show();
        }

        
        
    }
}
