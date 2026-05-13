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
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
            radioButton7.ForeColor = Color.LightPink;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            radioButton6.ForeColor = Color.LightBlue;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            this.BackColor = Color.LightGreen;
        }
    }
}
