namespace Nahom_s_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1;
        double num2;
        string result;
        double total;
        string option;


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void EnabledButtons()
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }
        private void DisabledButtons()
        {
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        private void DarkMode_CheckedChanged_1(object sender, EventArgs e)
        {
            if (DarkMode.Checked)
            {
                first_tab.BackColor = Color.Gray;
                radioButton1.ForeColor = Color.White;
                Scientific.ForeColor = Color.White;
                DarkMode.ForeColor = Color.White;
                btn0.ForeColor = Color.DarkGray;
                btn1.ForeColor = Color.DarkGray;
                btn2.ForeColor = Color.DarkGray;
                btn3.ForeColor = Color.DarkGray;
                btn4.ForeColor = Color.DarkGray;
                btn5.ForeColor = Color.DarkGray;
                btn6.ForeColor = Color.DarkGray;
                btn7.ForeColor = Color.DarkGray;
                btn8.ForeColor = Color.DarkGray;
                btn9.ForeColor = Color.DarkGray;
                btnPlus.BackColor = Color.Silver;
                btnDiv.BackColor = Color.Silver;
                btnSub.BackColor = Color.Silver;
                btnMul.BackColor = Color.Silver;
                btnClear.BackColor = Color.DarkGray;
            }
            if (!DarkMode.Checked)
            {
                first_tab.BackColor = Color.White;
                radioButton1.ForeColor = Color.Black;
                Scientific.ForeColor = Color.Black;
                DarkMode.ForeColor = Color.Black;
                btn0.ForeColor = Color.White;
                btn1.ForeColor = Color.White;
                btn2.ForeColor = Color.White;
                btn3.ForeColor = Color.White;
                btn4.ForeColor = Color.White;
                btn5.ForeColor = Color.White;
                btn6.ForeColor = Color.White;
                btn7.ForeColor = Color.White;
                btn8.ForeColor = Color.White;
                btn9.ForeColor = Color.White;
                btnPlus.BackColor = Color.Gold;
                btnDiv.BackColor = Color.Gold;
                btnSub.BackColor = Color.Gold;
                btnMul.BackColor = Color.Gold;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            double pie = Math.PI;
            string pi = pie.ToString("F2");
            if (textBox1.Text.Contains(pi))
                return;
            DisabledButtons();
            textBox1.Text += pi;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Error"))
                textBox1.Clear();
            textBox1.Text += btn1.Text;
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            Error();
            textBox1.Text += btn0.Text;
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            Error();
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            Error();
            textBox1.Text += btn3.Text;
        }

        private void first_tab_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            Error();
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            Error();
            textBox1.Text += btn5.Text;
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            Error();
            textBox1.Text += btn6.Text;
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            Error();
            textBox1.Text += btn7.Text;
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            Error();
            textBox1.Text += btn8.Text;
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            Error();
            textBox1.Text += btn9.Text;
        }

        private void btnPoint_Click_1(object sender, EventArgs e)
        {
            Error();
            if (textBox1.Text.Contains(btnPoint.Text))
                return;
            textBox1.Text += btnPoint.Text;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            EnabledButtons();
            num1 = 0;
            num2 = 0;
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            Error();
            try
            {
                if (Scientific.Checked)
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                    num1 = Math.Pow(num1, 2);
                    result = num1.ToString("F2");
                    textBox1.Text = result;
                }
                else
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                    option = "+";
                    textBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnSub_Click_1(object sender, EventArgs e)
        {
            Error();
            EnabledButtons();
            try
            {
                if (Scientific.Checked)
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                    for (double i = num1 - 1; i >= 1; i--)
                    {
                        num1 *= i;
                    }
                    result = num1.ToString("F2");
                    textBox1.Text = result;
                }
                else
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                    option = "-";
                    textBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDiv_Click_1(object sender, EventArgs e)
        {
            Error();
            EnabledButtons();
            try
            {
                if (Scientific.Checked)
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                    option = "X^Y";
                    textBox1.Clear();
                }
                else
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                    option = "/";
                    textBox1.Clear();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnMul_Click_1(object sender, EventArgs e)
        {
            Error();
            EnabledButtons();
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                option = "*";
                textBox1.Clear();
            }
            
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnMod_Click_1(object sender, EventArgs e)
        {
            Error();
            EnabledButtons();
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                option = "%";
                textBox1.Clear();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnRoot_Click_1(object sender, EventArgs e)
        {
            Error();
            EnabledButtons();
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                double newNum1 = Math.Sqrt(num1);
                string result = Convert.ToString(newNum1);
                textBox1.Text = result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnEqual_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Error"))
                textBox1.Clear();

            try
            {
                num2 = Convert.ToDouble(textBox1.Text);
                switch (option)
                {
                    case "+":
                        total = num1 + num2;
                        result = Convert.ToString(total.ToString("F2"));
                        textBox1.Text = result;
                        break;
                    case "-":
                        total = num1 - num2;
                        result = Convert.ToString(total.ToString("F2"));
                        textBox1.Text = result;
                        break;
                    case "/":
                        total = num1 / num2;
                        result = Convert.ToString(total.ToString("F2"));
                        textBox1.Text = result;
                        break;
                    case "*":
                        total = num1 * num2;
                        result = Convert.ToString(total.ToString("F2"));
                        textBox1.Text = result;
                        break;
                    case "%":
                        total = num1 % num2;
                        result = Convert.ToString(total.ToString("F2"));
                        textBox1.Text = result;
                        break;
                    case "X^Y":
                        total = Math.Pow(num1, num2);
                        result = Convert.ToString(total.ToString("F2"));
                        textBox1.Text = result;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void Error()
        {
            if (textBox1.Text.Contains("Error"))
                textBox1.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Scientific_CheckedChanged(object sender, EventArgs e)
        {
            if (Scientific.Checked)
            {
                btnPlus.Text = "x^2";
                btnSub.Text = "x!";
                btnDiv.Text = "x^y";
                btnMul.Text = "log";
            }
            else
            {
                btnPlus.Text = "+";
                btnSub.Text = "−";
                btnDiv.Text = "/";
                btnMul.Text = "x";
            }
        }
    }
}