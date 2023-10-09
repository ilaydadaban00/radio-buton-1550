using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radio_button_if_else_renk_1550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void renkDegistir_Click(object sender, EventArgs e)
        {
            if (rbMor.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (rbKirmizi.Checked)
            {
                this.BackColor = Color.Red;
                
            }
            else if(rbMavi.Checked)
               {
                this.BackColor= Color.Blue;
                }
            else if(rbSari.Checked)
            {
                this.BackColor= Color.Yellow;
            }
        }
    }
}
