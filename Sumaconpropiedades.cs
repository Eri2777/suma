using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clasesuma1 SUMAR = new clasesuma1();
            SUMAR.V1 = double.Parse(txt_n1.Text);
            SUMAR.V2 = double.Parse(txtn2.Text);
            txtres.Text = SUMAR.sumar().ToString();


        }
    }
}
