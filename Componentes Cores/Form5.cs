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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBox1.Text)
            {
                case "Verde - Lima":
                    this.BackColor = Color.Lime;
                    comboBox1.ForeColor = Color.Lime;
                    break;

                case "Azul - Marinho":
                    this.BackColor = Color.Navy;
                    comboBox1.ForeColor= Color.Navy;
                    break;

                case "Rosa Claro":
                    this.BackColor = Color.LightPink;
                    comboBox1.ForeColor = Color.LightPink;
                    break;

                case "Ciano":
                    this.BackColor = Color.Cyan;
                    comboBox1.ForeColor = Color.Cyan;
                    break;
                
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
