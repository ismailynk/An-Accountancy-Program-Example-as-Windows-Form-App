namespace Muhasebe_uygulama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.acesdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muhacesDataSet = new Muhasebe_uygulama.muhacesDataSet();
            this.acesdbTableAdapter = new Muhasebe_uygulama.muhacesDataSetTableAdapters.acesdbTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.passtxt = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.adtxt = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePasswordValidationTool1 = new Siticone.Desktop.UI.Winforms.SiticonePasswordValidationTool();
            ((System.ComponentModel.ISupportInitialize)(this.acesdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhacesDataSet)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // acesdbBindingSource
            // 
            this.acesdbBindingSource.DataMember = "acesdb";
            this.acesdbBindingSource.DataSource = this.muhacesDataSet;
            // 
            // muhacesDataSet
            // 
            this.muhacesDataSet.DataSetName = "muhacesDataSet";
            this.muhacesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acesdbTableAdapter
            // 
            this.acesdbTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel3);
            this.siticonePanel1.Controls.Add(this.siticonePictureBox1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(421, 606);
            this.siticonePanel1.TabIndex = 10;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(38, 392);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(345, 48);
            this.siticoneHtmlLabel3.TabIndex = 1;
            this.siticoneHtmlLabel3.Text = "Fatura Kayıt Sistemi";
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(73, 12);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(267, 320);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 0;
            this.siticonePictureBox1.TabStop = false;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(158)))));
            this.siticonePanel2.Controls.Add(this.siticoneButton1);
            this.siticonePanel2.Controls.Add(this.passtxt);
            this.siticonePanel2.Controls.Add(this.adtxt);
            this.siticonePanel2.Controls.Add(this.siticoneHtmlLabel2);
            this.siticonePanel2.Controls.Add(this.siticoneHtmlLabel1);
            this.siticonePanel2.Controls.Add(this.label3);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(421, 0);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(457, 606);
            this.siticonePanel2.TabIndex = 11;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(107)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(63, 327);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton1.TabIndex = 14;
            this.siticoneButton1.Text = "Giriş Yap";
            this.siticoneButton1.Click += new System.EventHandler(this.cek_Click);
            // 
            // passtxt
            // 
            this.passtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxt.DefaultText = "12345";
            this.passtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passtxt.Location = new System.Drawing.Point(179, 270);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.PlaceholderText = "";
            this.passtxt.SelectedText = "";
            this.passtxt.Size = new System.Drawing.Size(138, 32);
            this.passtxt.TabIndex = 13;
            // 
            // adtxt
            // 
            this.adtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adtxt.DefaultText = "aytekin.baser";
            this.adtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adtxt.Location = new System.Drawing.Point(179, 226);
            this.adtxt.Name = "adtxt";
            this.adtxt.PasswordChar = '\0';
            this.adtxt.PlaceholderText = "";
            this.adtxt.SelectedText = "";
            this.adtxt.Size = new System.Drawing.Size(138, 32);
            this.adtxt.TabIndex = 12;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(63, 237);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(96, 21);
            this.siticoneHtmlLabel2.TabIndex = 11;
            this.siticoneHtmlLabel2.Text = "Kullanıcı Adı";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(88, 165);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(141, 41);
            this.siticoneHtmlLabel1.TabIndex = 10;
            this.siticoneHtmlLabel1.Text = "Giriş Yap";
            // 
            // siticonePasswordValidationTool1
            // 
            this.siticonePasswordValidationTool1.PasswordMaximumLength = ((long)(16));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 606);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fatura Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acesdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhacesDataSet)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private muhacesDataSet muhacesDataSet;
        private System.Windows.Forms.BindingSource acesdbBindingSource;
        private muhacesDataSetTableAdapters.acesdbTableAdapter acesdbTableAdapter;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox passtxt;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox adtxt;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.Winforms.SiticonePasswordValidationTool siticonePasswordValidationTool1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
    }
}

