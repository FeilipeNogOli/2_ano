using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, r;

            label1.Text = "-";
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                r = a - b;

                lblr.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, r;

            label1.Text = "+";
            try {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                r = a + b;

                lblr.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            label1.Text = "?";
            lblr.Text = "?";
            txtN1.Focus();
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, r;

            label1.Text = "*";
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                r = a * b;

                lblr.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, r;

            label1.Text = "/";
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                r = a / b;

                lblr.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por zero");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a, b, r;

            label1.Text = "^";
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                r = Math.Pow(a, b);

                lblr.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
