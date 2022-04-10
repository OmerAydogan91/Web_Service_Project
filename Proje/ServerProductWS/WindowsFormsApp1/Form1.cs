using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.TCKNService;//TCKNService servisimizi ekliyoruz


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KPSPublicSoapClient proxy = new KPSPublicSoapClient();
            bool Dogrula = proxy.TCKimlikNoDogrula(Convert.ToInt64(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            MessageBox.Show(Dogrula.ToString());
        }

    }
}
