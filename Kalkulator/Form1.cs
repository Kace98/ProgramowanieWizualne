namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private double currentValue = 0;
        private double storedValue = 0;
        private string currentOperation = "";
        private bool isNewNumber = true;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
        }

        private void AddDigit(string digit)
        {
            if (isNewNumber)
            {
                label1.Text = digit;
                isNewNumber = false;
            }
            else
            {
                label1.Text += digit;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddDigit("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDigit("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDigit("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDigit("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDigit("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDigit("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDigit("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDigit("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddDigit("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddDigit("9");
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains(","))
            {
                label1.Text += ",";
                isNewNumber = false;
            }
        }

        private void PerformOperation(string operation)
        {
            if (!isNewNumber)
            {
                storedValue = double.Parse(label1.Text);
                isNewNumber = true;
            }
            currentOperation = operation;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            PerformOperation("+");
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            PerformOperation("-");
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            PerformOperation("*");
        }

        private void buttonDev_Click(object sender, EventArgs e)
        {
            PerformOperation("/");
        }

        private void buttonRev_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0" && label1.Text != "Błąd")
            {
                if (label1.Text.Length == 1)
                {
                    label1.Text = "0";
                    isNewNumber = true;
                }
                else
                {
                    label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
                    if (label1.Text == "-")
                    {
                        label1.Text = "0";
                        isNewNumber = true;
                    }
                }
            }
        }

        private void buttonEq_Click_1(object sender, EventArgs e)
        {
            if (currentOperation != "")
            {
                double secondValue = double.Parse(label1.Text);
                double result = 0;

                switch (currentOperation)
                {
                    case "+":
                        result = storedValue + secondValue;
                        break;
                    case "-":
                        result = storedValue - secondValue;
                        break;
                    case "*":
                        result = storedValue * secondValue;
                        break;
                    case "/":
                        if (secondValue != 0)
                            result = storedValue / secondValue;
                        else
                            label1.Text = "Błąd";
                        break;
                }

                if (label1.Text != "Błąd")
                {
                    label1.Text = result.ToString();
                    storedValue = result;
                }
                currentOperation = "";
                isNewNumber = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Nie potrzebujemy implementacji dla kliknięcia w label
        }
    }
}
