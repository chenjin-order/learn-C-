using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            int x, y, result = 0;

            var op = txt_Operator.Text;

            var operandX = txt_DataX.Text;

            var operandY = txt_DataY.Text;

            x = int.Parse(operandX);
            y = int.Parse(operandY);
            IBinarycomputing computing;

            switch (op)
            {
                default:
                    computing = new Addition();
                    break;
                case "-":
                    computing = new Subtraction();
                    break;
                case "*":
                    computing = new Multiplication();
                    break;
                case "/":
                    computing = new Division();
                    break;
            }

            result = computing.Calculate(x, y);

            txt_Result.Text = result.ToString();
        }
    }
}
