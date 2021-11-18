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

        int inp1, inp2; //операнды

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

        /// <summary>
        /// Выполнить операцию.
        /// Получает на вход строку с последним выбранным знаком операции
        /// </summary>
        /// <returns>Строка с результатом операции</returns>
        string Operation(string CurrentOp)
        {
            string  res = "";

            switch (CurrentOp)
            {
                case "+":
                    res = (inp1 + inp2).ToString();
                    break;
                case "-":
                    res = (inp1 - inp2).ToString();
                    break;
                case "×":
                    res = (inp1 * inp2).ToString();
                    break;
                case "/":
                    if (inp1 == 0 && inp2 == 0)
                    {
                        throw new Exception("Неопределено");
                    }
                    else
                    {
                        if (inp2 == 0)
                        {
                            throw new Exception("Деление невозможно");
                        }
                        else
                        {
                            res = (inp1 / inp2).ToString();
                        }
                    }
                    break;
            }
            if (double.Parse(res) > double.MaxValue)
            {
                throw new Exception("Большое число!");
            }
            if (double.Parse(res) < double.MinValue)
            {
                throw new Exception("Маленькое число!");
            }
            return res;
        }

    }
}
