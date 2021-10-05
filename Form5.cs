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
    public partial class Form5 : Form
    {
        //membuat koneksi ke database dan deklarasi sqlcommand
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=kavlingtanah;User ID=sa;Password=Kudaponi123");
        public SqlCommand cmd;
        public Form5()
        {
            InitializeComponent();
            
        }

        //method btn masuk jika di klik
        private void btnMasuk_Click(object sender, EventArgs e)
        {
            //akan di arah kan ke login/Form2
            Form2 lg = new Form2();
            lg.Show();
            this.Hide();
        }
        
        //method btn buat akun jika di klik 
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            //jika username dan password kosong
            if(txUsername.Text == ""|| txPass.Text == "")
            {
                //akan menampilkan pesan ini
                MessageBox.Show("Isi Data dengan lengkap!");
            }
            //jika terpenuhi
            else
            {
                //deklarasi hs sebagai int dengan nilai 0 digunakan untuk nilai awal dari sebuah id nantinya
                int hs = 0;
                
                //membuka koneksi
                conn.Open();

                //deklarasi query untuk mengambil data id_user dari tabel users di db
                string strs = "SELECT id_user FROM dbo.users";
                //jadi disini strs menampilkan id_user dan akan di baca kemudian akan di inisiasi ke hs
                SqlCommand cm = new SqlCommand(strs, conn);
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    hs = int.Parse(dr["id_user"].ToString());
                }
                dr.Close();

                //deklarasi str sebagai query insert data ke table login yang ada di db
                //hs yang isinya id_user akan di masukkan ke id_user di tabel login ini 
                string str = "insert into dbo.login (username, password, id_user) " +
                    "values('" + txUsername.Text + "','" + txPass.Text + "','"+hs+"')";
                cmd = new SqlCommand(str, conn);
                //query akan di eksekusi
                cmd.ExecuteNonQuery();
                //menutup koneksi 
                conn.Close();
                //menampilkan pesan berhasil
                MessageBox.Show("Akun berhasil di buat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //maka akan mengalihkan ke home/form3
                Form3 hm = new Form3();
                hm.Show();
                this.Hide();
            }
        }
    }
}
