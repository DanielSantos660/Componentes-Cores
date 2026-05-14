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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 0)
            {
                this.BackColor = Color.Brown;
                listBox2.ForeColor = Color.Brown;
                label1.ForeColor = SystemColors.ControlText;

            } else if (listBox2.SelectedIndex == 1)
            {
                this.BackColor = Color.Black;
                listBox2.ForeColor = Color.Black;
                label1.ForeColor = Color.White;

            } else if (listBox2.SelectedIndex == 2) 
            {
                this.BackColor = Color.FromArgb(114, 47, 55);
                listBox2.ForeColor = Color.FromArgb(114, 47, 55);
                label1.ForeColor = SystemColors.ControlText;

            } else if (listBox2.SelectedIndex == 3)
            {
                this.BackColor = Color.FromArgb(255, 215, 0);
                listBox2.ForeColor = Color.FromArgb(255, 215, 0);
                label1.ForeColor = SystemColors.ControlText;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                listBox2.ForeColor= SystemColors.ControlText;
                label1.ForeColor = SystemColors.ControlText;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
