using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //4
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //3.5
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //6.75
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res = 0.0;
            if (correo.Checked == true)
            {
                res += 3.5;
            }
            if (normal.Checked == true)
            {
                res += 4;
            }
            if (urgente.Checked == true)
            {
                res += 6.75;
            }

            if (email.Checked == true)
            {
                res += 0.75;
            }
            if (telephone.Checked == true)
            {
                res += 1.25;
            }
            if (fax.Checked == true)
            {
                res += 0.50;
            }

            labelRes.Enabled = true;
            labelRes.Text = res.ToString() + " Euros.";
        }
    }
}
