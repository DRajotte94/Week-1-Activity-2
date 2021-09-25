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
            // attempts to convert the text to a double
            if (double.TryParse(textBox1.Text, out miles))
            {
                // converts the miles to kms the send to the second textbox
                double kms = miles * 1.60934;
                textBox2.Text = kms.ToString();
            }
            else
            {
                // if the input is unable to be converted to a double an error is displayed in a messagebox
                MessageBox.Show("Error");
            }
        }
    }
}
