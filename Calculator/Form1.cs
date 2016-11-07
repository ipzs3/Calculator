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
    public partial class calculator : Form
    {
        string theOperator;

        public calculator()
        {
            InitializeComponent();
        }
        //==============//
        // Catch Alphas //
        //==============//

            
        //============//
        // BUTTON ONE //
        //============//
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }
        //============//
        // BUTTON TWO //
        //============//
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }
        //==============//
        // BUTTON THREE //
        //==============//
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }
        //=============//
        // BUTTON FOUR //
        //=============//
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }
        //=============//
        // BUTTON FIVE //
        //=============//
        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }
        //============//
        // BUTTON SIX //
        //============//
        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }
        //==============//
        // BUTTON SEVEN //
        //==============//
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }
        //==============//
        // BUTTON EIGHT //
        //==============//
        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }
        //=============//
        // BUTTON NINE //
        //=============//
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }
        //=============//
        // BUTTON ZERO //
        //=============//
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }
        //==============//
        // CLEAR BUTTON //
        //==============//
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        //===============//
        // EQUALS BUTTON //
        //===============//
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double num2;
            double answer;

            num2 = double.Parse(txtDisplay.Text);

            switch (theOperator)
            {
                case "+":
                    answer = total1 + num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "-":
                    answer = total1 - num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "*":
                    answer = total1 * num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "/":
                    answer = total1 / num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                default:
                    answer = 0;
                    break;
            }
        }

        //==============//
        // POINT BUTTON //
        //==============//
        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }
        //============//
        // ADD BUTTON //
        //============//
        double total1 = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                theOperator = "+";
                txtDisplay.Clear();
            }
        }
        //=================//
        // SUBTRACT BUTTON //
        //=================//
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length < 1)
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                theOperator = "-";
                txtDisplay.Clear();
            }
        }
        //===============//
        // DIVIDE BUTTON //
        //===============//
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length < 1)
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                theOperator = "/";
                txtDisplay.Clear();
            }
        }
        //=================//
        // MULTIPLY BUTTON //
        //=================//
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length < 1)
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                theOperator = "*";
                txtDisplay.Clear();

            }
        }
    }
}
