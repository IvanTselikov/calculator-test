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
        private bool ErrorFlag = false; //флаг ошибки. Если true - произошла ошибка
        private bool dec = false; // Является ли число десятичной дробью. Если true - в числе есть запятая
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

        private void Comma_Click(object sender, EventArgs e)
        {
            if ((Tablo.Text.Length >= 12) || Tablo.Text.Contains('E') || ErrorFlag || Tablo.Text.Contains(',')) { return; }
            Tablo.Text += ",";
            dec = true; 
        }

        private void ClearLastCharacter_Click(object sender, EventArgs e)
        {
            if ((ErrorFlag)||(Tablo.Text.Contains("E"))) { return; }
            if (Tablo.Text.Length == 1) { Tablo.Text = "0"; }
            else
            {
                if (Tablo.Text[Tablo.Text.Length - 1] == ',') { dec = false; };
                Tablo.Text = Tablo.Text.Remove(Tablo.Text.Length - 1, 1);
            };

            if ((Tablo.Text.Length == 1) && (Tablo.Text.Contains('-')))
            {
                Tablo.Text = "0";
            }
            else
            {
                if ((Tablo.Text[0] == '-') && (!Tablo.Text.Contains(',')) && (Convert.ToDouble(Tablo.Text) == 0)) { Tablo.Text = "0"; }
            }
        }
    }
}
