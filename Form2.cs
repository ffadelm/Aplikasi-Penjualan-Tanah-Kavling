using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//import sys db
using System.Data.SqlClient;


namespace Aplikasi_Penjualan_Tanah_Kavling
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //method form saat di close 
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //membuat inisiasi ketika form di close akan menuju form starter/form1
            Form1 strt = new Form1();
            strt.Show();
            this.Hide();
        }

        //method button masuk saat di klik
        private void button1_Click(object sender, EventArgs e)
        {
            //membuat koneksi ke database sql server
            SqlConnection con = new SqlConnection(@"Data Source=MSI;Initial Catalog=kavlingtanah;User ID=sa;Password = Kudaponi123");
            
            //membuat data adapter untuk menyelerasikan data yang ada di db dengan data yang di masukkan ke txt box
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from dbo.login where username = '" + txtUser.Text + "'" +
                "and password = '" + txtPass.Text + "'", con);

            //menginisiasi data table untuk mengisi ke table data yang di inputkan sebelumnya ke db
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //kondisi ketika data table == true dengan txtbox
            if (dt.Rows[0][0].ToString() == "1")
            {
                //inisiasi ketika kondisi true akan menuju form home/form3
                Form3 hm = new Form3();
                hm.Show();
                this.Hide();
            }

            //jika kondisi tidak terpenuhi/false
            else
            {
                MessageBox.Show("Silahkan cek kembali Username & Password Anda", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //method button daftar saat di klik
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            //inisiasi ketika di klik akan menuju form daftar/form7
            Form7 dftr = new Form7();
            dftr.Show();
            this.Hide();
        }
    }
}
