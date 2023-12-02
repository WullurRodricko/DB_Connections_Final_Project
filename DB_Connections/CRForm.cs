using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Connections
{
    public partial class CRForm : Form
    {
        public CRForm()
        {
            InitializeComponent();
        }

        private void CRForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewbutton_Click_1(object sender, EventArgs e)
        {
            CrystalReport1.SetParameterValue("stok_bahan_makanan", textBox1.Text);
            crystalReportViewer1.ReportSource = CrystalReport1;
            crystalReportViewer1.Refresh();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Admin frm = new Admin();
            frm.Show();

            this.Hide();
        }
    }
}
