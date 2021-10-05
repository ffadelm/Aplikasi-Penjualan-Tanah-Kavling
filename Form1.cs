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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //method btn start saat di klik 
        private void btn_start_Click(object sender, EventArgs e)
        {
            //membuat inisiasi ketika btn di klik akan menuju form login/form2
            Form2 lg = new Form2();
            lg.Show();
            this.Hide();
        }
        
        //method menutup system/program jika di klik close
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //membuat sebuah fungsi apabila program di close akan menutup
            System.Windows.Forms.Application.Exit();
        }
    }
}
