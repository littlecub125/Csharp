using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_FirstStep
{
    public partial class Calculator : Form
    {
        bool operandPerformed = false;
        string operand;
        double answer = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void b_ClickNumber(object sender, EventArgs e)
        {
            if (this.label1.Text == "0" || operandPerformed)
                label1.Text = "";
            Button btn = (Button)sender;
            label1.Text += btn.Text;
            operandPerformed = false; 
        }

        private void b_Operand(object sender, EventArgs e)
        {
            operandPerformed = true;
            Button btn = (Button)sender;
            operand = btn.Text;
            answer = Double.Parse(label1.Text);               
        }

        private void b_ResultOperand(object sender, EventArgs e)
        {
            switch (operand)
            {
                case "+":
                    answer = answer + Double.Parse(label1.Text);
                    break;
                case "-":
                    answer = answer - Double.Parse(label1.Text);
                    break;
                case "X":
                    answer = answer * Double.Parse(label1.Text);
                    break;
                case "%":
                    answer = answer / Double.Parse(label1.Text);
                    break;
            }
            label1.Text = answer.ToString();
            operandPerformed = false;
        }

        private void b_ResetClick(object sender, EventArgs e)
        {
            this.label1.ResetText();
        }
    }
}
