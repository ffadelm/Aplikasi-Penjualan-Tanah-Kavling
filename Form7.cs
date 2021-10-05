using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_Penjualan_Tanah_Kavling
{
    public partial class Form7 : Form
    {
        //membuat koneksi ke database dan command
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=kavlingtanah;User ID=sa;Password=Kudaponi123");
        public SqlCommand cmd;
        
        public Form7()
        {
            InitializeComponent();
        }

        //jika btn lanjut di klik
        private void btnLanjut_Click(object sender, EventArgs e)
        {
            //jika nama telpon dan alamat kosong 
            if (txNama.Text == "" || txTelp.Text == ""|| txAl.Text == "")
            {
                //maka akan menampilkan pesan ini
                MessageBox.Show("Isi Data dengan lengkap!");
            }
            //jika kondisi terpenuhi
            else
            {
                //maka akan membuka koneksi
                conn.Open();

                //deklarasi str untuk insert data ke table users 
                string str = "insert into dbo.users (nama, no_hp, alamat) values('" + txNama.Text + "', '" + txTelp.Text + "' ,'"+txAl.Text+"')";
                //dan command query agar di eksekusi
                cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();

                //dan akan diarahkan ke form daftar di form5
                Form5 dftr = new Form5();
                dftr.Show();
                this.Hide();

                //menutup koneksi
                conn.Close();
            }
        }
    }
}
