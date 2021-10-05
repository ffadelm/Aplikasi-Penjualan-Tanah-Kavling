using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Penjualan_Tanah_Kavling
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        //method button back 
        private void btnBack_Click(object sender, EventArgs e)
        {
            //untuk kembali form Home / form3 
            Form3 hm = new Form3();
            hm.Show();
            this.Hide();
        }

        //mendeklarasikan DialogResult untuk return values dari MessageBox
        DialogResult result;
        //method btn pesan sekarang jika di klik
        private void btnPesan_Click(object sender, EventArgs e)
        {
            /*jadi result akan menampilkan pesan untuk meyakinkan user dengan pilihan "Yes" atau "No"*/
            result = MessageBox.Show("Apakah Anda Yakin ingin Memesan Tanah ini?\n" +
                "dan jangan lupa untuk mencatat No.Telepon/kontak penjual \nuntuk konfirmasi lebih lanjut dengan penjual", "Pesan Tanah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //jika result tersebut berisi Yes
            if (result == DialogResult.Yes)
            {
                // maka akan diarahkan ke form transaksi sukses / form9
                Form9 ts = new Form9();
                this.Hide();
                ts.Show();
            }
            //jika no maka akan tetap di form8/ detail tanah
        }
    }
}
