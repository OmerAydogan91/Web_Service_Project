using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientProductWS.ProductWSConsumer;//product servisi ekliyoruz
using ClientProductWS.MusteriWSConsumer;//musteri servisi ekliyoruz


namespace ClientProductWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductWsSoapClient proxy = new ProductWsSoapClient();
            string msj = proxy.HelloWorld();
            MessageBox.Show(msj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductWsSoapClient urungetir = new ProductWsSoapClient();
            dataGridView1.DataSource = urungetir.UrunleriGetir();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerWSSoapClient cs = new CustomerWSSoapClient();
            dataGridView1.DataSource= cs.MusteriGetir();
        }
    }
}
