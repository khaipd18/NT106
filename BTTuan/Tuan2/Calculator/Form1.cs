namespace Calculator_ver0._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string type;
        float num1, num2;
        float result;
        float lastResult = 0;

        private void button20_Click(object sender, EventArgs e)
        {
            DisplayScreen.Text = DisplayScreen.Text + "1";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            DisplayScreen.Text = DisplayScreen.Text + "0";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            DisplayScreen.Text = DisplayScreen.Text + "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            DisplayScreen.Text = DisplayScreen.Text + "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            DisplayScreen.Text = DisplayScreen.Text + "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            DisplayScreen.Text = DisplayScreen.Text + "5";
        }

        private void DisplayScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Num6_Click(object sender, EventArgs e)
        {
            DisplayScreen.Text = DisplayScreen.Text + "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            DisplayScreen.Text = DisplayScreen.Text + "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            DisplayScreen.Text = DisplayScreen.Text + "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            DisplayScreen.Text = DisplayScreen.Text + "9";
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (!DisplayScreen.Text.Contains(","))
            {
                DisplayScreen.Text = DisplayScreen.Text + ",";
            }
        }

        private void ButtonSqrt2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(DisplayScreen.Text, out double number))
            {
                double sqrtResult = Math.Sqrt(number);
                DisplayScreen.Text = sqrtResult.ToString();
            }
            else
            {
                DisplayScreen.Text = "Khong hop le";
            }
        }

        private void ButtonPow2_Click(object sender, EventArgs e)
        {
            if (float.TryParse(DisplayScreen.Text, out float num))
            {
                float result = num * num;
                DisplayScreen.Text = result.ToString();
            }
            else
            {
                DisplayScreen.Text = "Khong hop le";
            }
        }

        private void ButtonDEL_Click(object sender, EventArgs e)
        {
            if (DisplayScreen.Text.Length > 0)
            {
                DisplayScreen.Text = DisplayScreen.Text.Substring(0, DisplayScreen.Text.Length - 1);
            }
        }

        private void ButtonAC_Click(object sender, EventArgs e)
        {
            DisplayScreen.Text = "";
        }



        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            if (float.TryParse(DisplayScreen.Text, out float num2))  // Lấy số thứ hai
            {
                switch (type)
                {
                    case "ADD":
                        result = num1 + num2;
                        DisplayScreen.Text = result.ToString();
                        break;

                    case "SUB":
                        result = num1 - num2;
                        DisplayScreen.Text = result.ToString();
                        break;

                    case "MUL":
                        result = num1 * num2;
                        DisplayScreen.Text = result.ToString();
                        break;

                    case "DIV":
                        if (num2 != 0)
                        {

                            int quotient = (int)(num1 / num2);


                            float remainder = num1 - (quotient * num2);

                            DisplayScreen.Text = remainder.ToString();
                        }
                        else
                        {
                            DisplayScreen.Text = "Khong hop le";
                        }
                        break;

                    case "DIVIDE":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            DisplayScreen.Text = result.ToString();
                        }
                        else
                        {
                            DisplayScreen.Text = "Khong hop le";
                        }
                        break;

                    default:
                        DisplayScreen.Text = "Khong hop le";
                        break;
                }


            }
            else
            {
                DisplayScreen.Text = "Khong hop le";
            }
        }

        private void ButtonMult_Click(object sender, EventArgs e)
        {
            if (float.TryParse(DisplayScreen.Text, out num1))
            {

                type = "MUL";


                DisplayScreen.Text = "";
            }
            else
            {

                DisplayScreen.Text = "Khong hop le";
            }
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (float.TryParse(DisplayScreen.Text, out num1))
            {

                type = "DIVIDE";


                DisplayScreen.Text = "";
            }
            else
            {

                DisplayScreen.Text = "Khong hop le";
            }
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (float.TryParse(DisplayScreen.Text, out num1))
            {

                type = "ADD";

                DisplayScreen.Text = "";
            }
            else
            {

                DisplayScreen.Text = "Khong hop le";
            }
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (float.TryParse(DisplayScreen.Text, out num1))
            {
                type = "SUB";

                DisplayScreen.Text = "";
            }
            else
            {
                DisplayScreen.Text = "Khong hop le";
            }
        }
        private void ButtonDIV_Click(object sender, EventArgs e)
        {
            if (float.TryParse(DisplayScreen.Text, out num1))
            {
                type = "DIV";

                DisplayScreen.Text = "";
            }
            else
            {

                DisplayScreen.Text = "Khong hop le";
            }
        }
        private void ButtonPercentage_Click(object sender, EventArgs e)
        {
            if (double.TryParse(DisplayScreen.Text, out double num))
            {
                double result = num / 100;
                DisplayScreen.Text = result.ToString();
            }
            else
            {
                DisplayScreen.Text = "Khong hop le";
            }
        }

        private void ButtonAns_Click(object sender, EventArgs e)
        {






        }
    }
}
