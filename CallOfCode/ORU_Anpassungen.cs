using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallOfCode
{
    public partial class ORU_Anpassungen : Form
    {
        public ORU_Anpassungen()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string did = "2E 03 FC";

            string reserved1 = Convert.ToString(int.Parse(reserved_1_TextBox.Text), 2);
            string s_blNvE2ETestmode = Convert.ToString(int.Parse(s_blNvE2ETestmode_TextBox.Text), 2);
            string reserved2 = Convert.ToString(int.Parse(reserved_2_TextBox.Text), 2);
            reserved1 = reserved1 + s_blNvE2ETestmode;
            did += " " + Convert.ToInt32(reserved1, 2).ToString("X") + " " + Convert.ToInt32(reserved2, 2).ToString("X");

            ORU_Anp_RichTextBox.Text = did;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s_blNvE2ETestmode_TextBox.Text = "";
            reserved_1_TextBox.Text = "";
            reserved_2_TextBox.Text = "";
            ORU_Anp_RichTextBox.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s_blNvE2ETestmode_TextBox.Text = "";
            reserved_1_TextBox.Text = "";
            reserved_2_TextBox.Text = "";

            string modifiedString = "";

            string substringToRemove = "2E 03 FC ";
            int index = ORU_Anp_RichTextBox.Text.IndexOf(substringToRemove);

            if (index != -1)
            {
                modifiedString = ORU_Anp_RichTextBox.Text.Remove(index, substringToRemove.Length);
                Console.WriteLine(modifiedString); // Output: "BF 7F"
            }
            else
            {
                Console.WriteLine("Substring not found.");
            }

            string reserved1_s_blNvE2ETestmode = modifiedString.Substring(0, 2);

            

            modifiedString = modifiedString.Remove(0, 3);
            string reserved2 = modifiedString.Substring(0, 2);

            string hexString2 = reserved2;
            int decimalValue2 = Convert.ToInt32(hexString2, 16);
            string binaryValue2 = Convert.ToString(decimalValue2, 2).PadLeft(8, '0');

            reserved_2_TextBox.Text = Convert.ToString(binaryValue2);


            int reserved2_int = Convert.ToInt32(binaryValue2, 2);
            reserved_2_TextBox.Text = Convert.ToString(reserved2_int);

            string hexString = reserved1_s_blNvE2ETestmode;
            int decimalValue = Convert.ToInt32(hexString, 16);
            string binaryValue = Convert.ToString(decimalValue, 2).PadLeft(8, '0');


            string reserved1 = binaryValue.Substring(0, 7);
            string s_blNvE2ETestmode = binaryValue.Substring(7, 1);

            int reserved1_int = Convert.ToInt32(reserved1, 2);
            int s_blNvE2ETestmode_int = Convert.ToInt32(s_blNvE2ETestmode, 2);

            reserved_1_TextBox.Text = Convert.ToString(reserved1_int);
            s_blNvE2ETestmode_TextBox.Text = Convert.ToString(s_blNvE2ETestmode_int);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ORU form1 = new ORU();

            // Hide Form1
            this.Hide();

            // Show Form1
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ORU_Anp_RichTextBox.Text))
            {
                // TextBox is empty
                // Add your code here to handle the case where the TextBox is empty
            }
            else
            {
                Clipboard.SetText(ORU_Anp_RichTextBox.Text);
                MessageBox.Show("Text copied to clipboard!");
            }
        }
    }
}
