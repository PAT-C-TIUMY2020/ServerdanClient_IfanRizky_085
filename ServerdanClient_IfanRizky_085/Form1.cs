using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerdanClient_IfanRizky_085
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.MatematikaClient obj = new
            ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Tambah(6, 3);
            Console.WriteLine("6 + 3 = " + hasilTambah);
            double hasilKurang = obj.Kurang(6, 3);
            Console.WriteLine("6 - 3 = " + hasilKurang);
            double hasilKali = obj.Kali(6, 3);
            Console.WriteLine("6 x 3 = " + hasilKali);
            double hasilBagi = obj.Bagi(6, 3);
            Console.WriteLine("6 / 3 = " + hasilBagi);
            Console.ReadLine();

            textBox1.Text = "6";            textBox2.Text = "3";
            label7.Text = hasilTambah.ToString();
            label8.Text = hasilKurang.ToString();
            label9.Text = hasilKali.ToString();
            label10.Text = hasilBagi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
