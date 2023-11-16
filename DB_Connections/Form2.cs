using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DB_Connections
{
    public partial class Form2 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form2()
        {
            InitializeComponent();
            alamat = "server=localhost; database=db_mahasiswa; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && (textBox2.Text == "12345" || textBox3.Text == "12345"))
            {
                Form1 frm = new Form1();
                frm.Show();

                this.Hide();
            }
            if (textBox1.Text == "student" && (textBox2.Text == "unklab12345" || textBox3.Text == "unklab12345"))
            {
                Form3 frm = new Form3();
                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("anda salah memasukkan username atau password");
            }


            //Form1 frm = new Form1();
            // frm.Show();
            // this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.Text = textBox2.Text;
                textBox3.Visible = true;
                textBox2.Visible = false;

            }
            else
            {
                textBox3.Visible = false;
                textBox2.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
