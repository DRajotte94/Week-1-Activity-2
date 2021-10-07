using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_1_Activity_2
{
    public partial class MilesToKm : Form
    {
        public MilesToKm()
        {
            InitializeComponent();
        }

        // When the convert button is clicked the input in the miles textbox is converted to km then printed in the km textbox
        private void convertButton_Click(object sender, EventArgs e)
        {
            // variable for the miles
            double miles; 
            // attempts to convert the text to a double. If the value is negative or not a number sends error message
            if (double.TryParse(textBox1.Text, out miles) && miles > 0)
            {
                // converts the miles to kms
                double kms = miles * 1.60934;
                // sends the result to the output textbox formatted to always show 3 decimal places
                textBox2.Text = string.Format("{0:0,0.000}", kms); // credit to Dave from https://www.daveoncsharp.com/2009/09/formatting-decimals-in-csharp/
            }
            else
            {
                // if the input is unable to be converted to a double an error is displayed in a messagebox
                MessageBox.Show("Please enter a valid positive number");
            }
        }
    }
}
