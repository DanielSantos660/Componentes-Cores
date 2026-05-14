using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes_Cores
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            radioButton8.ForeColor = Color.Violet;
            if (radioButton8.Checked == false)
            {
                radioButton8.ForeColor = SystemColors.ControlText;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Magenta;
            radioButton7.ForeColor = Color.LightPink;
            if (radioButton7.Checked == false)
            {
                radioButton7.ForeColor = SystemColors.ControlText;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            radioButton6.ForeColor = Color.LightBlue;
            if (radioButton6.Checked == false)
            {
                radioButton6.ForeColor = SystemColors.ControlText;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            radioButton5.ForeColor = Color.LightGreen;
            if (radioButton5.Checked == false)
            {
                radioButton5.ForeColor = SystemColors.ControlText;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
