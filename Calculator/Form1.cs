using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = "Я НАЖАТА!!!";
        }

        private void numButton_Click(object sender, EventArgs e) //обработка нажатия кнопок с цифрами
        {
            if ((Tablo.Text.Length ==1)&&(Tablo.Text[0]=='0')) { Tablo.Text = ""; }
            if (Tablo.Text.Length < 12) //число не более 12 символов
            {
                Tablo.Text += (sender as Button).Text;
            }
        }
    }
}
