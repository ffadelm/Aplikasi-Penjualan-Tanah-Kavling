using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//mengimport sql dan 
//io yang berguna untuk mengakses foto 
using System.Data.SqlClient;
using System.IO;


namespace Aplikasi_Penjualan_Tanah_Kavling
{
    public partial class Form4 : Form
    {
        //koneksi ke database
        private string kstr = @"Data Source=MSI;Initial Catalog=kavlingtanah;User ID=sa;Password = Kudaponi123";
        private SqlConnection conn;

        //membuat atribut idteroilih untuk mengakses id yang di pilih
        public string idterpilih;
        //dan img location untuk mengakses location foto
        public string imglocation = "";

        //method btn clear saat di klik maka akan merefresh form
        private void btnClear_Click(object sender, EventArgs e)
        {
            //memanggil method refreshForm() untuk merefresh form saat ini
            refreshForm();
        }

        public Form4()
        {
            InitializeComponent();
            
            //koneksi kstr sebelumnya agar terkoneksi
            conn = new SqlConnection(kstr);
            
            //memanggil method refreshForm() untuk merefresh form saat ini
            refreshForm();
        }

        //method dgView untuk mengakses seluruh data di table tanah yang ada di database 
        private void dgView()
        {
            //membuka koneksi
            conn.Open();

            //membuat query agar menampilkan seluruh data table tanah
            string str = "SELECT * FROM dbo.tanah";

            //menghubungkan query dengan database
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            //mengisi data yang sudah di hubungkan ke dgv2 dan akan di tampilkan di table mulai dengan index 0
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv2.DataSource = ds.Tables[0];
            
            //menutup koneksi 
            conn.Close();
        }

        //method btn tambah ketika di klik
        private void btnTmbh_Click(object sender, EventArgs e)
        {
            //disini ada enabled di gunakan untuk mengaktifkan setiap btn
            //ataupun textbox apa bila di klik btn tambah
            //true untuk aktif dan false untuk non aktif 
            txtJudul.Enabled = true;
            txtStatus.Enabled = true;
            txtLuas.Enabled = true;
            txtAlamat.Enabled = true;
            txtHarga.Enabled = true;

            btnSmpn.Enabled = true;
            btnClear.Enabled = true;
            btnHps.Enabled = false;
            btnEdit.Enabled = false;
            btnGambar.Enabled = true;

        }

        //saat btn simpan di klik akan menyimpan input yang di lakukan diblm txtbox/picbox
        private void btnSmpn_Click(object sender, EventArgs e)
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

            //deklarasi str query untuk insert ke table tanah 
            string str = "INSERT INTO dbo.tanah (judul, status, luas, alamat, harga, foto, id_user) " +
                "VALUES(@judul, @status, @luas, @alamat, @harga, @foto, @id)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@judul", txtJudul.Text));
            cmd.Parameters.Add(new SqlParameter("@status", txtStatus.Text));
            cmd.Parameters.Add(new SqlParameter("@luas", txtLuas.Text));
            cmd.Parameters.Add(new SqlParameter("@alamat", txtAlamat.Text));
            cmd.Parameters.Add(new SqlParameter("@harga", txtHarga.Text));
            cmd.Parameters.Add(new SqlParameter("@foto", images));
            //hs yang isinya id_user akan di masukkan ke id_user di tabel tanah ini
            cmd.Parameters.Add(new SqlParameter("@id", hs));

            cmd.ExecuteNonQuery();

            //menutup koneksi 
            conn.Close();
            //menampilkan pesan berhasil
            MessageBox.Show("Data Berhasil di Simpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //memanggil dgView()
            dgView();
            //memanggil refreshForm();
            refreshForm();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //mengisi dgv dengan dtabase table tanah 
            // TODO: This line of code loads data into the 'kavlingtanahDataSet2.tanah' table. You can move, or remove it, as needed.
            this.tanahTableAdapter.Fill(this.kavlingtanahDataSet2.tanah);

            //untuk meng hide kolom[index] 
            dgv2.Columns[0].Visible = false;
            dgv2.Columns[6].Visible = false;
            dgv2.Columns[7].Visible = false;

        }

        //method refreshForm untuk merefresh form4
        private void refreshForm()
        {
            /*apabila di refresh maka form yang ada textBox ataupun img location akan bernilai null atau kosong
             dengan kata lain akan mengkosongkan data yang sebelumnya di inputkan*/
            txtJudul.Text = "";
            txtStatus.Text = "";
            txtLuas.Text = "";
            txtAlamat.Text = "";
            txtHarga.Text = "";
            imgTanah.ImageLocation = null;

            /*disini ada enabled di gunakan untuk mengaktifkan setiap btn
              ataupun textbox apa bila di klik btn tambah
              true untuk aktif dan false untuk non aktif */
            txtJudul.Enabled = false;
            txtStatus.Enabled = false;
            txtLuas.Enabled = false;
            txtAlamat.Enabled = false;
            txtHarga.Enabled = false;

            btnTmbh.Enabled = true;
            btnEdit.Enabled = false;
            btnHps.Enabled = false;
            btnSmpn.Enabled = false;
            btnGambar.Enabled = false;

            //memanggil method clearBinding
            clearbinding();
        }

        //method ClearBinding akan menghapus data yang ada di txtbox ataupun picbox
        private void clearbinding()
        {
            
            this.txtJudul.DataBindings.Clear();
            this.txtStatus.DataBindings.Clear();
            this.txtLuas.DataBindings.Clear();
            this.txtAlamat.DataBindings.Clear();
            this.txtHarga.DataBindings.Clear();    
            imgTanah.ImageLocation = null;

        }

        //method untuk kembali ke menu home
        private void btnBack_Click(object sender, EventArgs e)
        {
            //akan menampilkan form3 atau home jika di klik
            Form3 hm = new Form3();
            hm.Show();
            this.Hide();
        }

        //method btn gambar/ browse akan berguna untuk mencari file di directory kita
        private void btnGambar_Click(object sender, EventArgs e)
        {
            //menginisiai dialog file/ membuka file directory di perangkat kita
            OpenFileDialog dialogCari = new OpenFileDialog();
            //akan mem filter file dengan format png jpg atau all files 
            dialogCari.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            //jika file yang kita cari telah di temukan, kemudian klik ok 
            if(dialogCari.ShowDialog() == DialogResult.OK)
            {
                //saat klik ok di sini imgloaction yng tadinya kosong "" akan berisi filename yang di pilih tadi
                imglocation = dialogCari.FileName.ToString();
                //instansiasi bahwa imgTanah sebagai Imglocation agar nantinya dapat di panggil di method2 lain
                imgTanah.ImageLocation = imglocation;
            }
            
        }

        //method jika cell dari dgv2 di klik maka akan melakukan sebuah operasi 
        private void dgv2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //deklarasi row yang berisi dgv2 dengan cell saat ini 
            int row = dgv2.CurrentCell.RowIndex;
            //membuat idterpilih dengan isinya dgv2 yang ada di row saat ini dan cell [0]/isinya id_tanah
            idterpilih = dgv2.Rows[row].Cells[0].Value.ToString();

            /*sama seperti idterpilih jd setiap index mempunyai nilai di table tanah
             judul dengan index 1, status dengan index 2 dst.
             di gunakan untuk meletakkan data yang ada di dgv2 ke txtbox*/
            //show text di dgv2 ke txtbox
            txtJudul.Text = dgv2.Rows[row].Cells[1].Value.ToString();
            txtStatus.Text = dgv2.Rows[row].Cells[2].Value.ToString();
            txtLuas.Text = dgv2.Rows[row].Cells[3].Value.ToString();
            txtAlamat.Text = dgv2.Rows[row].Cells[4].Value.ToString();
            txtHarga.Text = dgv2.Rows[row].Cells[5].Value.ToString();
            
            /*untuk tipe byte disini tidak di convert ke string karena filenya bertiipe byte
             dan mengambil dari path di dgv2 yang telah kita input sebelumnya*/
            //show foto ke picbox
            byte[] data = (byte[])dgv2.Rows[row].Cells[6].Value;
            MemoryStream ms = new MemoryStream(data);
            imgTanah.Image = Image.FromStream(ms);

            /*disini ada enabled di gunakan untuk mengaktifkan setiap btn
              ataupun textbox apa bila di klik btn tambah
              true untuk aktif dan false untuk non aktif */
            txtJudul.Enabled = true;
            txtStatus.Enabled = true;
            txtLuas.Enabled = true;
            txtAlamat.Enabled = true;
            txtHarga.Enabled = true;

            btnTmbh.Enabled = false;
            btnEdit.Enabled = true;
            btnGambar.Enabled = true;
            btnHps.Enabled = true;
            btnSmpn.Enabled = false;

        }

        //membuat method hapus 
        private void Hapus()
        {
            //membuka koneksi
            conn.Open();
            //membuat query untuk menghapus data di db dengan id yang di pilih
            string strd = "delete from dbo.tanah where id_tanah = '" + idterpilih + "'";
            //membuat command untuk di eksekusi 
            SqlCommand cmd = new SqlCommand(strd, conn);
            cmd.ExecuteNonQuery();
            
            //menutup koneksi 
            conn.Close();
            //menampilkan pesan berhasil
            MessageBox.Show("Data Berhasil Di hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //mendeklarasikan DialogResult untuk return values dari MessageBox
        DialogResult result;
        //method btn hapus jika di klik
        private void btnHps_Click(object sender, EventArgs e)
        {
            /*jadi result akan menampilkan pesan untuk meyakinkan user dengan pilihan "Yes" atau "No"*/
            result = MessageBox.Show("Apakah Anda ingin Menghapus ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //jika result tersebut berisi Yes
            if (result == DialogResult.Yes)
            {
                //maka method hapus akan di panggil dan data yang terpilih sebelumnya akan terhapus
                Hapus();
            }
            //jika result berisi No maka akan membatalkan data yang akan di hapus

            //memanggil dgView
            dgView();
            //memanggil refreshForm
            refreshForm();
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

            //membuka koneksi
            conn.Open();
            //membuat query untuk update data yang ada di table tanah 
            string str = "update dbo.tanah set judul = @judul, status = @status, luas = @luas, alamat = @alamat, harga = @harga, foto = @foto where id_tanah='" + idterpilih + "'";
            //membuat command untuuk memberikan parameter @ dan mengeksekusi query
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@judul", txtJudul.Text));
            cmd.Parameters.Add(new SqlParameter("@status", txtStatus.Text));
            cmd.Parameters.Add(new SqlParameter("@luas", txtLuas.Text));
            cmd.Parameters.Add(new SqlParameter("@alamat", txtAlamat.Text));
            cmd.Parameters.Add(new SqlParameter("@harga", txtHarga.Text));
            cmd.Parameters.Add(new SqlParameter("@foto", images));
            cmd.ExecuteNonQuery();
            //menutuk koneksi 
            conn.Close();
            //menampilkan pesan berhasil
            MessageBox.Show("Data Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*jadi result akan menampilkan pesan untuk meyakinkan user dengan pilihan "Yes" atau "No"*/
            result = MessageBox.Show("Apakah Anda ingin Mengubah data ini?", "Edit Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //jika result tersebut berisi Yes
            if (result == DialogResult.Yes)
            {
                //maka method edit akan di panggil dan data yang terpilih sebelumnya akan terupdate
                Edit();
            }

            //jika result berisi No maka akan membatalkan data yang akan di edit

            //memanggil dgView
            dgView();
            //memanggil refreshForm
            refreshForm();
        }
    }
}
