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
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
namespace Muhasebe_uygulama
{
    public partial class Form2 : Form
    {
        public static String constr = dbtool.constr;
        OleDbConnection con = new OleDbConnection(constr);
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            griddoldur();
            autodoldur();
        }
        
        void cıktı()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Satın Alım Çıktısı";
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
           /* OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.InitialDirectory = @"C:\";
            openDlg.ShowDialog();
            string path = openDlg.FileName;
            Console.WriteLine(path);*/
           //workbook.SaveAs("c:\\Excel Çıktısı.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            
            
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void rapor_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.
             Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            con = new OleDbConnection(constr);
            string cmdtxt = "SElect * from kayit where geldigiyer like '%" + textBox2.Text.ToString() +
                "%' and konusu like '%" + textBox3.Text.ToString() +
                "%'   and faturano like '%" + textBox4.Text.ToString() +
                "%'   and htfno like '%" + textBox5.Text.ToString() +
                "%'   and talepno like '%" + textBox6.Text.ToString() +
                "%'   and satınpersonel like '%" + textBox7.Text.ToString() +
                "%'   and yapılanislem like '%" + textBox8.Text.ToString() +
                "%'   and acıklama like '%" + textBox1.Text.ToString() +"%'";
            if (checkBox1.Checked)
            {
                cmdtxt += "and evraktarihi between @date1 and @date4 ";
            }
            if (checkBox2.Checked)
            {
                cmdtxt += "and evrakgelistarihi between @date2 and @date5 ";
            }
            if (checkBox3.Checked)
            {
                cmdtxt+= "and islemtarih between @date3 and @date6";
            }
            Console.WriteLine(cmdtxt);
            da = new OleDbDataAdapter(cmdtxt, con);
            if (checkBox1.Checked)
            {
               
                da.SelectCommand.Parameters.Add("@date1", OleDbType.DBDate).Value = dateTimePicker1.Value;
                da.SelectCommand.Parameters.Add("@date4", OleDbType.DBDate).Value = dateTimePicker4.Value;
            }
            if (checkBox2.Checked)
            {
                da.SelectCommand.Parameters.Add("@date2", OleDbType.DBDate).Value = dateTimePicker2.Value;
                da.SelectCommand.Parameters.Add("@date5", OleDbType.DBDate).Value = dateTimePicker5.Value;
            }
            if (checkBox3.Checked)
            {
                da.SelectCommand.Parameters.Add("@date3", OleDbType.DBDate).Value = dateTimePicker3.Value;
                da.SelectCommand.Parameters.Add("@date6", OleDbType.DBDate).Value = dateTimePicker6.Value;
            }
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            con.Close();

        }
        public void autodoldur()
        {
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                dateTimePicker2.Enabled = true;
                dateTimePicker5.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
                dateTimePicker5.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker4.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker4.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                dateTimePicker3.Enabled = true;
                dateTimePicker6.Enabled = true;
            }
            else
            {
                dateTimePicker3.Enabled = false;
                dateTimePicker6.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cıktı();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            dbtool.kayıtekran.Show();
        }

        private void siticoneTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ara_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            dbtool.bilgiform.Show();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            deneme2();
        }

        private void deneme2()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            xlWorkBook.SaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");

        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
