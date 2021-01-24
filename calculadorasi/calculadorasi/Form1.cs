using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorasi
{
    public partial class Form1 : Form
    {

        static operaciones op = new operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdResultado_Click(object sender, EventArgs e)
        {
            if (cbxOperacion.Text == "Suma")
            {
                lblRes.Text = (op.suma(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
            else if (cbxOperacion.Text == "Resta")
            {
                lblRes.Text = (op.resta(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
            else if (cbxOperacion.Text == "Multiplicación")
            {
                lblRes.Text = (op.mult(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
            else 
            {
                lblRes.Text = (op.div(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }

        }
    }
}

