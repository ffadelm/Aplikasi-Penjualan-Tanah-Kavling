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
using System.IO;

namespace Aplikasi_Penjualan_Tanah_Kavling
{
    public partial class Form6 : Form
    {
        //membuat koneksi ke database dan deklarasi sqlDataAdapter serta Data Set
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=kavlingtanah;User ID=sa;Password=Kudaponi123");
        SqlDataAdapter da;
        DataSet ds;
        
        //deklarasi R untuk row
        int R;
        
        //dan img location untuk mengakses location foto
        public string imglocation = "";

        public Form6()
        {
            InitializeComponent();
        }

        //method btn kembali jika di klik
        private void btnBack_Click(object sender, EventArgs e)
        {
            //akan kembali ke menu home/form3
            Form3 hm = new Form3();
            hm.Show();
            this.Hide();
        }

        //method untuk load form untuk mengisi data 
        private void Form6_Load(object sender, EventArgs e)
        {
            //membuka koneksi
            conn.Open();
            //mengisi dataadapter dengan query untuk mendapat kan seluruh data yang ada di table users
            da = new SqlDataAdapter("Select * from dbo.users ", conn);
            //insiasi dataset untuk mengisi data yang di dapat dari adapter
            ds = new DataSet();
            da.Fill(ds, "dbo.users");
            //memangggil getData
            GetData();
            //menutup koneksi
            conn.Close();

            //menonaktifkan btn browse dan simpan
            btnGambar.Enabled = false;
            btnSmpn.Enabled = false;
        }

        //method getData yang akan di gunakan untuk mendapatkan data dari table users yang di deklarasikan di form load
        private void GetData()
        {
            //data yang ada di table users dengan index[] akan di letakkan per textbox sesuai yang diarahkan
            //txNama untuk index = 1 Telp untuk index = 2 dst.
            txNama.Text = ds.Tables[0].Rows[R][1].ToString();
            txTelp.Text = ds.Tables[0].Rows[R][2].ToString();
            txKontak.Text = ds.Tables[0].Rows[R][3].ToString();
            txBio.Text = ds.Tables[0].Rows[R][4].ToString();
            txAl.Text = ds.Tables[0].Rows[R][5].ToString();

            //menampilkan foto 
            //jika foto user null 
            if (imgUser == null)
            {
                //maka akan system tidak akan menampilkan foto alias blank
                imgUser.Dispose();
            }

            //jika di dalam table ada data image maka
            //system akan menampilkan nya di imgUser yang ada di teble user index 6
            byte[] data = (byte[])ds.Tables[0].Rows[R][6];
            MemoryStream ms = new MemoryStream(data);
            imgUser.Image = Image.FromStream(ms);

            /*disini ada enabled di gunakan untuk mengaktifkan setiap btn
              ataupun textbox apa bila di klik btn tambah
              true untuk aktif dan false untuk non aktif */
            txNama.Enabled = false;
            txTelp.Enabled = false;
            txKontak.Enabled = false;
            txBio.Enabled = false;
            txAl.Enabled = false;

            //menutup koneksi 
            conn.Close();
        }

        //method btn gambar/ browse akan berguna untuk mencari file di directory kita
        private void btnGambar_Click(object sender, EventArgs e)
        {
            //menginisiai dialog file/ membuka file directory di perangkat kita
            OpenFileDialog dialogCari = new OpenFileDialog();
            //akan mem filter file dengan format png jpg atau all files
            dialogCari.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            //jika file yang kita cari telah di temukan, kemudian klik ok 
            if (dialogCari.ShowDialog() == DialogResult.OK)
            {
                //saat klik ok di sini imgloaction yng tadinya kosong "" akan berisi filename yang di pilih tadi
                imglocation = dialogCari.FileName.ToString();
                //instansiasi bahwa imgUser sebagai Imglocation agar nantinya dapat di panggil di method2 lain
                imgUser.ImageLocation = imglocation;
            }
        }

        private void Edit()
        {
            //deklarasi images sebagai tipe data byte karena kita ingin meinput file
            byte[] images = null;

            /*karena di atas sudah mengimport system.IO maka bisa di gunakan FileStream DKK
             disini berguna dan mengacu pada transfer data baik ke atau dari media penyimpanan.
             jadi nantinya kita dapat mengakses file kita untuk mendapatkan data yang akan kita input
             lalu akan di baca di program*/
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

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

            //deklarasi str sebagai query update data ke table users yang ada di db
            string str = "update dbo.users set nama = @nm, no_hp = @telp, kontak = @kon, biodata = @biodata, alamat = @alamat, foto = @foto where id_user = @id";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@nm", txNama.Text));
            cmd.Parameters.Add(new SqlParameter("@telp", txTelp.Text));
            cmd.Parameters.Add(new SqlParameter("@kon", txKontak.Text));
            cmd.Parameters.Add(new SqlParameter("@biodata", txBio.Text));
            cmd.Parameters.Add(new SqlParameter("@alamat", txAl.Text));
            cmd.Parameters.Add(new SqlParameter("@foto", images));
            //hs yang isinya id_user akan di masukkan ke id_user di tabel users ini 
            cmd.Parameters.Add(new SqlParameter("@id", hs));

            cmd.ExecuteNonQuery();

            //menutup koneksi
            conn.Close();
            //menampilkan pesan berhasil
            MessageBox.Show("Data Profile Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //membuat btn dan txt aktif ketika btn edit di klik
            txNama.Enabled = true;
            txTelp.Enabled = true;
            txKontak.Enabled = true;
            txBio.Enabled = true;
            txAl.Enabled = true;
            btnGambar.Enabled = true;
            btnSmpn.Enabled = true;
        }

        //method btn simpan
        private void btnSmpn_Click(object sender, EventArgs e)
        {
            //memanggil Edit agar di eksekusi
            Edit();

            /*disini ada enabled di gunakan untuk mengaktifkan setiap btn
              ataupun textbox apa bila di klik btn tambah
              true untuk aktif dan false untuk non aktif */
            txNama.Enabled = false;
            txTelp.Enabled = false;
            txKontak.Enabled = false;
            txBio.Enabled = false;
            txAl.Enabled = false;

            btnGambar.Enabled = false;
            btnSmpn.Enabled = false;
        }
    }
}
