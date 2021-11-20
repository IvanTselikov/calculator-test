using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool errorFlag = false; //флаг ошибки. Если true - произошла ошибка

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = "Я НАЖАТА!!!";
        }

        private bool isNewNumber = true;

        private void numButton_Click(object sender, EventArgs e) //обработка нажатия кнопок с цифрами
        {
            if (Tablo.Text == "0" || isNewNumber)
            {
                Tablo.Text = "";
                isNewNumber = false;
            }
            if (Tablo.Text.Length <= 12) // число не более 12 символов
            {
                Tablo.Text += (sender as Button).Text;
            }
        }

        private double inp1 = 0, inp2 = double.NaN; // операнды

        private string lastOperation = "+";

        private void operationButton_Click(object sender, EventArgs e)
        {
            if (!errorFlag)
            {
                string currentOperation = (sender as Button).Text;

                if (!isNewNumber)
                {
                    inp2 = double.Parse(Tablo.Text);

                    try
                    {
                        inp1 = Operation(lastOperation);

                        string result = inp1.ToString();
                        if (result.Length > 11)
                            result = result.Substring(0, 12);

                        Tablo.Text = result;
                    }
                    catch (Exception ex)
                    {
                        Tablo.Text = ex.Message;
                    }
                }

                lastOperation = currentOperation;
                isNewNumber = true;
            }
        }

        /// <summary>
        /// Выполнить операцию.
        /// Получает на вход строку с последним выбранным знаком операции
        /// </summary>
        /// <returns>Результат операции</returns>
        double Operation(string CurrentOp)
        {
            double  res = double.NaN;

            switch (CurrentOp)
            {
                case "+":
                    res = inp1 + inp2;
                    break;
                case "-":
                    res = inp1 - inp2;
                    break;
                case "*":
                    res = inp1 * inp2;
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
                            throw new Exception("На ноль делить нельзя");
                        }
                        else
                        {
                            res = inp1 / inp2;
                        }
                    }
                    break;
            }
            if (res > double.MaxValue)
            {
                throw new Exception("Большое число!");
            }
            if (res < double.MinValue)
            {
                throw new Exception("Маленькое число!");
            }
            return res;
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            if ((Tablo.Text.Length >= 12) || Tablo.Text.Contains('E') || errorFlag || Tablo.Text.Contains(',')) { return; }
            Tablo.Text += ",";
        }

        private void ClearLastCharacter_Click(object sender, EventArgs e)
        {
            if (errorFlag || Tablo.Text.Contains("E")) { return; }
            if (Tablo.Text.Length == 1) { Tablo.Text = "0"; }
            else
            {
                Tablo.Text = Tablo.Text.Remove(Tablo.Text.Length - 1, 1);
            };

            if (Tablo.Text == "-")
            {
                Tablo.Text = "0";
            }
            else
            {
                if ((Tablo.Text[0] == '-') && (!Tablo.Text.Contains(',')) && (Convert.ToDouble(Tablo.Text) == 0)) { Tablo.Text = "0"; }
            }
        }

        private void ChangeSign_Click(object sender, EventArgs e)
        {
            if (errorFlag || Tablo.Text == "0") { return; }
            if (Tablo.Text.IndexOf("-", 0) == -1)
            {
                Tablo.Text = Tablo.Text.Insert(0, "-");
            }
            else
            {
                Tablo.Text = Tablo.Text.Remove(0, 1);
            }
        }
    }
}
