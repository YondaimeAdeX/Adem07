using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adem07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Arabalar> arabalars = new List<Arabalar>();
        List<Modeller> modellers = new List<Modeller>();
        List<Yakitlar> yakitlars = new List<Yakitlar>();
        List<Markalar> markalars = new List<Markalar>();

        private void Doldur() 
        {
            dt1.DataSource = null;
            dt1.DataSource = arabalars;

            dt2.DataSource = null;
            dt2.DataSource = markalars;

            cmbMarka.DataSource = null;
            cmbMarka.DataSource = markalars;
            cmbMarka.DisplayMember = "marka";

            dt3.DataSource = null;
            dt3.DataSource = modellers;

            cmbModel.DataSource = null;
            cmbModel.DataSource = modellers;
            cmbModel.DisplayMember = "model";

            dt4.DataSource = null;
            dt4.DataSource = yakitlars;

            cmbYakıt.DataSource = null;
            cmbYakıt.DataSource = yakitlars;
            cmbYakıt.DisplayMember = "yakit";


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Arabalar araba = new Arabalar();
            araba.marka = cmbMarka.Text;
            araba.model = cmbModel.Text;
            araba.modelYili = txtmodelyili.Text;
            araba.renk = txtrenk.Text;
            araba.vites = cmbVites.Text;
            araba.yakit = cmbYakıt.Text;
            arabalars.Add(araba);
            Doldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Markalar marka = new Markalar();
            marka.marka = txtMarka.Text;
            markalars.Add(marka);
            Doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modeller model = new Modeller();
            model.model = txtModel.Text;
            modellers.Add(model);
            Doldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Yakitlar yakit = new Yakitlar();
            yakit.yakit = txtYakit.Text;
            yakitlars.Add(yakit);
            Doldur();
        }
    }
}
