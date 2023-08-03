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
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn9.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
                return;
            textBox1.Text += ".";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592653589793";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
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
            num1 = 0;
            num2 = 0;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            option = "+";
            textBox1.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {


            try
            {
                num2 = Convert.ToDouble(textBox1.Text);
                switch (option)
                {
                    case "+":
                        total = num1 + num2;
                        result = Convert.ToString(total);
                        textBox1.Text = result;
                        break;
                    case "-":
                        total = num1 - num2;
                        result = Convert.ToString(total);
                        textBox1.Text = result;
                        break;
                    case "/":
                        total = num1 / num2;
                        result = Convert.ToString(total);
                        textBox1.Text = result;
                        break;
                    case "*":
                        total = num1 * num2;
                        result = Convert.ToString(total);
                        textBox1.Text = result;
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                textBox1.Text += ex.Message;
            }
            catch (Exception ex)
            {
                textBox1.Text += ex.Message;
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
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
            num1 = Convert.ToDouble(textBox1.Text);
            option = "-";
            textBox1.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
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
            num1 = Convert.ToDouble(textBox1.Text);
            option = "/";
            textBox1.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
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
            num1 = Convert.ToDouble(textBox1.Text);
            option = "*";
            textBox1.Clear();
        }

        private void btnRoot_Click(object sender, EventArgs e)
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
            num1 = Convert.ToDouble(textBox1.Text);
            option = "Root";
            textBox1.Clear();
        }

        private void btnMod_Click(object sender, EventArgs e)
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
            num1 = Convert.ToDouble(textBox1.Text);
            option = "%";
            textBox1.Clear();
        }

        private void DarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if(DarkMode.Checked == true)
            {
                
            }
        }
        private void LightMode()
        {
           
        }
    }
}