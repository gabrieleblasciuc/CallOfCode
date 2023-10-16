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
    public partial class ORU : Form
    {
        public ORU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ORU_Anpassungen form1 = new ORU_Anpassungen();

            this.Hide();

            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();

            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ORU_Routines form1 = new ORU_Routines();
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ORU_Data form1 = new ORU_Data();
            this.Hide();
            form1.Show();
        }
    }
}
