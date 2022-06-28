using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20._06_pracktika1
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);


            dolg = 100000;
            label1.Text = "Долг по кредиту: " + dolg;
        }
        double dolg;
        double c;
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Math.Round(Convert.ToDouble(textBox1.Text), 2);
            Plata(x);
        }
        public void Plata(double p)
        {
            if (p >= dolg)
            {
                c = p - dolg;
                dolg = 0;
                label1.Text = "Долг по кредиту: " + dolg;
                label1.Text += "\nКредит погашен\n";
                label1.Text += "Переплата: " + (c);
            }
            if (p < dolg)
            {
                dolg -= p;
                label1.Text = "Платёж принят\n";
                label1.Text += "Долг по кредиту: " + dolg;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            try
            {
                if (c > 0)
                {
                    int fd = Convert.ToInt32(textBox2.Text);
                    double n = c - fd;
                    label1.Text += "Переплата: " + n;
                }
            }
            catch
            {
                MessageBox.Show("Переплаты нет!");
            }
        }
    }
}
