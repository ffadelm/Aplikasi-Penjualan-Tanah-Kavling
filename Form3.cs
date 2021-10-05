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
    public partial class Form3 : Form
    {
        //koneksi ke database sql Server
        private string kstr = @"Data Source=MSI;Initial Catalog=kavlingtanah;User ID=sa;Password = Kudaponi123";
        private SqlConnection conn;

        //attribut ini digunakan untuk menunjukan lokasi foto nantinya
        public string imglocation = "";
        
        public Form3()
        {
            InitializeComponent();
            conn = new SqlConnection(kstr);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //membuka koneksi 
            conn.Open();

            //data adapter disini digunakan untuk menampilkan data tabel tanah dan beberapa kolom dari table user join ke dalam nya 
            SqlDataAdapter sda = new SqlDataAdapter(@"Select dbo.tanah.id_tanah, dbo.tanah.judul, dbo.tanah.status, dbo.tanah.luas, dbo.tanah.alamat, dbo.tanah.harga, dbo.tanah.foto, dbo.users.nama, dbo.users.no_hp, dbo.users.kontak
            From((dbo.tanah INNER JOIN dbo.users ON dbo.tanah.id_user = dbo.users.id_user))", conn);
            //menginisiasi dataTable
            DataTable dtbl = new DataTable();
            //mengisi data table dengan ketentuan yang ada di adapter
            sda.Fill(dtbl);
            //menampilkan data table yang telah di tentukan di adapter ke dgv
            dgv.DataSource = dtbl;

            //mengubah header dari setiap kolom[index]
            dgv.Columns[1].HeaderText = "Judul Tanah";
            dgv.Columns[2].HeaderText = "Status";
            dgv.Columns[3].HeaderText = "Luas(m^2)";
            dgv.Columns[4].HeaderText = "Alamat";
            dgv.Columns[5].HeaderText = "Harga(Rp.)";

            //membuat auto size untuk lebar dari dgv
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;



            //menyembunyikan Column yang tidak untuk di tampilkan
            dgv.Columns[0].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;

            //memanggil method setRowNumber untuk membuat nomor pada row di dgv
            setRowNumber(dgv);

        }

        //method untuk membuat nomor di dgv
        private void setRowNumber(DataGridView dgv)
        {
            //membuat perulangan angka 
            foreach (DataGridViewRow row in dgv.Rows)
            {
                //meletakkan perulangan angkan di bagian row setiap angka di + 1
                //agar tercipta perulangan 1, 2, 3, 4 dst.
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        //method btn untuk logout jika di klik
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //kondisi untuk meyakinkan user
            if (MessageBox.Show("Apakah Anda Ingin Keluar?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //jika di klik "Yes" maka akan menuju login/form2 dan berhasil keluar
                Form2 lg = new Form2();
                lg.Show();
                this.Hide();
            }
            //jika menjawab No maka system akan bertahan di menu home dan tidak keluar dari akun
        }

        //method btn jual jika di klik akan membuka form jual/form4
        private void btnJual_Click(object sender, EventArgs e)
        {
            //memanggil form4 untuk di buka
            Form4 jl = new Form4();
            this.Hide();
            jl.Show();
        }

        //method btn akun untuk membuka form profile akun/form6
        private void btnAkun_Click(object sender, EventArgs e)
        {
            //memanggil form6 untuk di buka
            Form6 akn = new Form6();
            akn.Show();
            this.Hide();
        }

        //method untuk dgv apabila di klik by cell/ klik bagian cell
        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //inisiasi form8 agar bisa di panggil setiap label nya 
            //di form8 ini lbJudul, lbStatus dll, itu dibuat modifier public agar bisa di akses di form3 ini
            Form8 dt = new Form8();

            //mengisi lable dengan data yang ada di dgv sesuai index
            //gunanya untuk di tampilkan di form detail/form8 
            dt.lbJudul.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
            dt.lbStatus.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
            dt.lbLuas.Text = this.dgv.CurrentRow.Cells[3].Value.ToString();
            dt.lbAlamat.Text = this.dgv.CurrentRow.Cells[4].Value.ToString();
            dt.lbHarga.Text = this.dgv.CurrentRow.Cells[5].Value.ToString();

            //kondisi jika foto tanah ini kosong
            if(dt.imgTanah == null)
            {
                //maka akan dispose/menghilang
                dt.imgTanah.Dispose();
            }

            //jika fotonya ada maka akan menampilkan fotonya 
            byte[] data = (byte[])this.dgv.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(data);
            dt.imgTanah.Image = Image.FromStream(ms);

            //mengisi lable dengan data yang ada di dgv sesuai index
            //gunanya untuk di tampilkan di form detail/form8 
            dt.lbNama.Text = this.dgv.CurrentRow.Cells[7].Value.ToString();
            dt.lbTelp.Text = this.dgv.CurrentRow.Cells[8].Value.ToString();
            dt.lbKontak.Text = this.dgv.CurrentRow.Cells[9].Value.ToString();


            this.Hide();
            dt.Show();
        }

        //method menutup system/program jika di klik close
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            //membuat sebuah fungsi apabila program di close akan menutup
            System.Windows.Forms.Application.Exit();
        }
    }
}
