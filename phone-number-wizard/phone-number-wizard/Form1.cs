using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace phone_number_wizard
{
    public partial class frmIncrementalPhoneNumber : Form
    {
        long upper = 9999999999;
        long lower = 0000000000;

        long current = 5555555555;

        int clicks;

        List<long> upperList = new List<long>();
        List<long> lowerList = new List<long>();

        public frmIncrementalPhoneNumber()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void updateDisplay()
        {
            current = ((upper + lower) / 2);
            if (current >= 1000000000)
            lblPhoneNumber.Text = Regex.Replace(current.ToString(), @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            else if (current >= 100000000)
                lblPhoneNumber.Text = Regex.Replace("0" + current.ToString(), @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            else if (current >= 10000000)
                lblPhoneNumber.Text = Regex.Replace("00" + current.ToString(), @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            else if (current >= 1000000)
                lblPhoneNumber.Text = Regex.Replace("000" + current.ToString(), @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            else if (current >= 100000)
                lblPhoneNumber.Text = Regex.Replace("000-0" + current.ToString(), @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            else if (current >= 10000)
                lblPhoneNumber.Text = Regex.Replace("000-00" + current.ToString(), @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            else if (current >= 1000)
                lblPhoneNumber.Text = Regex.Replace("000-000" + current.ToString(), @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
        }

        private void btnSmaller_Click(object sender, EventArgs e)
        {
            if (upper > 0)
            {
                upperList.Add(upper);
                lowerList.Add(lower);
                upper = current--;
            }
            updateDisplay();
            click();
        }

        private void btnBigger_Click(object sender, EventArgs e)
        {
            lowerList.Add(lower);
            upperList.Add(upper);
            lower = current++;
            updateDisplay();
            click();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            upper = 9999999999;
            lower = 0000000000;
            current = 5555555555;
            clicks = -1;

            lblPhoneNumber.Text = Regex.Replace(current.ToString(), @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            click();
        }

        void click()
        {
            clicks++;
            lblClicks.Text = "Number of clicks: " + clicks; 
            if (clicks != 0) btnUndo.Enabled = btnReset.Enabled = true;
            else btnUndo.Enabled = btnReset.Enabled = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (clicks != 0)
            {
                clicks -= 2;
                click();
                upperList.Remove(upperList.Last());
                lowerList.Remove(lowerList.Last());


            }

            upper = upperList.Last();
            lower = lowerList.Last();
            updateDisplay();
        }

        private void btnSmaller_MouseEnter(object sender, EventArgs e)
        {
            picChangeArrow.Visible = true;
            picChangeArrow.Image = Properties.Resources.imgDownRedArrow;
        }

        private void btnSmaller_MouseLeave(object sender, EventArgs e)
        {
            picChangeArrow.Visible = false;
        }

        private void btnBigger_MouseEnter(object sender, EventArgs e)
        {
            picChangeArrow.Visible = true;
            picChangeArrow.Image = Properties.Resources.imgUpGreenArrow;
        }

        private void btnBigger_MouseLeave(object sender, EventArgs e)
        {
            picChangeArrow.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Regex.Replace(textBox1.Text, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
        }
    }
}
