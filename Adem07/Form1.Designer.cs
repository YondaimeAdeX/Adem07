
namespace Adem07
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.cmbYakıt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmodelyili = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dt2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dt3 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.txtYakit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dt4 = new System.Windows.Forms.DataGridView();
            this.cmbVites = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.cmbVites);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dt1);
            this.tabPage1.Controls.Add(this.txtmodelyili);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbYakıt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtrenk);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbModel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbMarka);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1109, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Araba Ekle";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtMarka);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dt2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1109, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Marka Ekle";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.txtModel);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.dt3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1109, 542);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Model Ekle";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.txtYakit);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.dt4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1109, 542);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Yakıt Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka :";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(90, 33);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 21);
            this.cmbMarka.TabIndex = 1;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(90, 60);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Renk :";
            // 
            // txtrenk
            // 
            this.txtrenk.Location = new System.Drawing.Point(90, 87);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(94, 20);
            this.txtrenk.TabIndex = 5;
            // 
            // cmbYakıt
            // 
            this.cmbYakıt.FormattingEnabled = true;
            this.cmbYakıt.Location = new System.Drawing.Point(90, 113);
            this.cmbYakıt.Name = "cmbYakıt";
            this.cmbYakıt.Size = new System.Drawing.Size(121, 21);
            this.cmbYakıt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yakıt :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vites :";
            // 
            // txtmodelyili
            // 
            this.txtmodelyili.Location = new System.Drawing.Point(90, 166);
            this.txtmodelyili.Name = "txtmodelyili";
            this.txtmodelyili.Size = new System.Drawing.Size(94, 20);
            this.txtmodelyili.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Model Yılı :";
            // 
            // dt1
            // 
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt1.Location = new System.Drawing.Point(382, 6);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(724, 478);
            this.dt1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dt2
            // 
            this.dt2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt2.Location = new System.Drawing.Point(377, 6);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(724, 478);
            this.dt2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Marka :";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(57, 49);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(94, 20);
            this.txtMarka.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(57, 46);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(94, 20);
            this.txtModel.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Model :";
            // 
            // dt3
            // 
            this.dt3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt3.Location = new System.Drawing.Point(377, 3);
            this.dt3.Name = "dt3";
            this.dt3.Size = new System.Drawing.Size(724, 478);
            this.dt3.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtYakit
            // 
            this.txtYakit.Location = new System.Drawing.Point(57, 51);
            this.txtYakit.Name = "txtYakit";
            this.txtYakit.Size = new System.Drawing.Size(94, 20);
            this.txtYakit.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Yakıt :";
            // 
            // dt4
            // 
            this.dt4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt4.Location = new System.Drawing.Point(377, 3);
            this.dt4.Name = "dt4";
            this.dt4.Size = new System.Drawing.Size(724, 478);
            this.dt4.TabIndex = 17;
            // 
            // cmbVites
            // 
            this.cmbVites.FormattingEnabled = true;
            this.cmbVites.Items.AddRange(new object[] {
            "Düz",
            "Otomatik"});
            this.cmbVites.Location = new System.Drawing.Point(90, 140);
            this.cmbVites.Name = "cmbVites";
            this.cmbVites.Size = new System.Drawing.Size(121, 21);
            this.cmbVites.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 568);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dt1;
        private System.Windows.Forms.TextBox txtmodelyili;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbYakıt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dt2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dt3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtYakit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dt4;
        private System.Windows.Forms.ComboBox cmbVites;
    }
}

