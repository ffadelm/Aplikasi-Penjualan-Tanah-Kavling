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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        
        //button kembali ke home jika di klik
        private void btnHm_Click(object sender, EventArgs e)
        {
            //maka akan diarahkan ke fom3 atau Home 
            Form3 hm = new Form3();
            hm.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
