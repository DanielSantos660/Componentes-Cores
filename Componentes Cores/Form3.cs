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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Magenta;
            checkBox1.ForeColor = Color.White;

            if (checkBox1.Checked == false ) {
                panel1.BackColor = SystemColors.Control;
                checkBox1 .ForeColor = SystemColors.ControlText;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Yellow;
            checkBox2.ForeColor = Color.White;

            if (checkBox2.Checked == false)
            {
                panel2.BackColor = SystemColors.Control;
                checkBox2.ForeColor = SystemColors.ControlText;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightBlue;
            checkBox3.ForeColor = Color.White;

            if (checkBox3.Checked == false)
            {
                panel3.BackColor = SystemColors.Control;
                checkBox3.ForeColor = SystemColors.ControlText;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Gray;
            checkBox4.ForeColor = Color.White;

            if (checkBox4.Checked == false)
            {
                panel4.BackColor = SystemColors.Control;
                checkBox4.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
