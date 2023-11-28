using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_ogrenme_836
{
    public partial class Form1 : Form
    {
        List<int> Sayilar = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtS1.Text);
            Sayilar.Add(sayi);

            lbSayilar.DataSource=Sayilar.ToList();
        }
    }
}
