using System.Diagnostics.Metrics;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project_calculator
{
    public partial class Form1 : Form
    {
        double enterfirstvalue, entersecondvalue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }
        //this is the default width
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 400;
            txtresult.Width = 358;
        }
        //this is Something like fractional number detection
        private void enternumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtresult.Text == "0")
                txtresult.Text = "";
            {
                if (num.Text == ",")
                {
                    if (!txtresult.Text.Contains(","))

                        txtresult.Text = txtresult.Text + num.Text;

                }
                else
                {
                    txtresult.Text = txtresult.Text + num.Text;
                }
            }
        }
        // When we select operators, it makes the number disappear etc.
        private void NumOP(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterfirstvalue = Convert.ToDouble(txtresult.Text);
            op = num.Text;
            txtresult.Text = "";
        }
        //The properties of the operators are selected here
        private void btnequal_Click(object sender, EventArgs e)
        {
            entersecondvalue = Convert.ToDouble(txtresult.Text);

            switch (op)
            {
                case "+":
                    txtresult.Text = (enterfirstvalue + entersecondvalue).ToString();
                    break;

                case "-":
                    txtresult.Text = (enterfirstvalue - entersecondvalue).ToString();
                    break;

                case "*":
                    txtresult.Text = (enterfirstvalue * entersecondvalue).ToString();
                    break;

                case "/":
                    txtresult.Text = (enterfirstvalue / entersecondvalue).ToString();
                    break;

                case "Mod":
                    txtresult.Text = (enterfirstvalue % entersecondvalue).ToString();
                    break;

                case "Exp":
                    double i = Convert.ToDouble(txtresult.Text);
                    double j;
                    j = entersecondvalue;
                    txtresult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;

                default:
                    break;
            }
        }
        //it's clear the textbox
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";
        }
        //this CE button but ý don't know why there is
        private void btnclearentry_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";

            string f, s;

            f = Convert.ToString(enterfirstvalue);
            s = Convert.ToString(entersecondvalue);

            f = "";
            s = "";
        }
        //plusminus button :3
        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtresult.Text);
            txtresult.Text = Convert.ToString(-1 * q);
        }
        //backspace
        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtresult.Text.Length > 0)
            {
                txtresult.Text = txtresult.Text.Remove(txtresult.Text.Length - 1, 1);
            }
            if (txtresult.Text == "")
            {
                txtresult.Text = "0";
            }
        }
        //normal calculator mode
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 400;
            txtresult.Width = 358;
        }
        //scientific mode
        private void siceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 790;
            txtresult.Width = 748;
        }
        //exit button in the mode menu
        private void siceToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            DialogResult exitcal;
            exitcal = MessageBox.Show("are you serious man? do you realy want to close this app?", "scientific calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitcal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Pi number
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtresult.Text = "3,14159265358979323";
        }
        //log button
        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtresult.Text);
            logg = Math.Log10(logg);
            txtresult.Text = Convert.ToString(logg);
        }
        //sqrt button
        private void btnsqr_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtresult.Text);
            sq = Math.Sqrt(sq);
            txtresult.Text = Convert.ToString(sq);
        }
        //X² button heheheh (X^2)
        private void btnx2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtresult.Text) * Convert.ToDouble(txtresult.Text);
            txtresult.Text = Convert.ToString(x);
        }
        //X³ button (X^3)
        private void btnx3_Click(object sender, EventArgs e)
        {
            double x, y, z, t;
            y = Convert.ToDouble(txtresult.Text);
            z = Convert.ToDouble(txtresult.Text);
            t = Convert.ToDouble(txtresult.Text);

            x = (y * z * t);
            txtresult.Text = Convert.ToString(x);
        }
        //sinh button
        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtresult.Text);
            sh = Math.Sinh(sh);
            txtresult.Text = Convert.ToString(sh);
        }
        //sin button
        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtresult.Text);
            sin = Math.Sin(sin);
            txtresult.Text = Convert.ToString(sin);
        }
        // Dec button.this button removes all numbers after the comma
        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtresult.Text);

            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtresult.Text = Convert.ToString(i2);
        }
        //cos button
        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtresult.Text);
            cos = Math.Cos(cos);
            txtresult.Text = Convert.ToString(cos);
        }
        //tanh button
        private void btnTanh_Click(object sender, EventArgs e)
        {
            double th = Convert.ToDouble(txtresult.Text);
            th = Math.Tanh(th);
            txtresult.Text = Convert.ToString(th);
        }
        //tan button
        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtresult.Text);
            tan = Math.Tan(tan);
            txtresult.Text = Convert.ToString(tan);
        }
        // 1/x button
        private void btn1x_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtresult.Text));
            txtresult.Text = Convert.ToString(a);
        }

        //converts to base eight (octal)
        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtresult.Text);
            txtresult.Text = Convert.ToString(a, 8);
        }
        //ln x button
        private void btnlnx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtresult.Text);
            lnx = Math.Log(lnx);
            txtresult.Text = Convert.ToString(lnx);
        }
        // % button
        private void btnpre_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtresult.Text) / Convert.ToDouble(100);
            txtresult.Text = Convert.ToString(a);
        }
        //cosh button
        private void btnCosh_Click(object sender, EventArgs e)
        {
            double cs = Convert.ToDouble(txtresult.Text);
            cs = Math.Cosh(cs);
            txtresult.Text = Convert.ToString(cs);
        }
        // converts to base two (binary)
        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtresult.Text);
            txtresult.Text = Convert.ToString(a, 2);
        }
        // converts to base two (Hexadecimal)
        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtresult.Text);
            txtresult.Text = Convert.ToString(a, 16);
        }
    }
}

