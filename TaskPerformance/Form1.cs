using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPerformance
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Get input numbers
            float num1 = float.Parse(txtImput1.Text);
            float num2 = float.Parse(txtImput2.Text);
            float result = 0;

            // Perform calculation based on selected operation
            switch (cbCalculation.SelectedItem.ToString())
            {
                case "+":
                    result = CalculatorPrivateAssembly.BasicComputation.Add(num1, num2);
                    break;
                case "-":
                    result = CalculatorPrivateAssembly.BasicComputation.Subtract(num1, num2);
                    break;
                case "*":
                    result = CalculatorPrivateAssembly.BasicComputation.Multiply(num1, num2);
                    break;
                case "/":
                    result = CalculatorPrivateAssembly.BasicComputation.Divide(num1, num2);
                    break;
            }
            // Display result
            lblTotal.Text = "Total: " + result.ToString();
        }
    }
}

