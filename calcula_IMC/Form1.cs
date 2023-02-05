using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcula_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
            
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double imc = 0, num1, num2;
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Clear();
                textBox2.Clear();
                return;
            }
           

            imc = num1 / (num2 * num2);
            if (imc <= 18.50)
            {
                lbllegal.Text = ("ABAIXO DO PESO");
                lbllegal.ForeColor = Color.Red;
            }
            else if (imc >= 18.51 && imc <= 24.90)
            {
                lbllegal.Text = ("PESO IDEAL PARABÉNS");
            }
            else if (imc >= 24.91 && imc <= 29.90)
            {
                lbllegal.Text = ("LEVEMENTE ACIMA DO PESO");
            }
            else if (imc >= 29.91 && imc <= 34.90)
            {
                lbllegal.Text = ("OOBESIDADE GRAU 1");
            }
            else if (imc >= 34.91 && imc <= 39.90)
            {
                lbllegal.Text = ("OOBESIDADE GRAU 2(SEVERA)");
            }
            else if (imc >= 39.91)
            {
                lbllegal.Text = ("OOBESIDADE GRAU 3 (MÓRBIDA)");
            }
            lblresultado.Text = imc.ToString("n");
            lblresultado.Visible = true;
            lbllegal.Visible = true;
        }

        private void lbllegal_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == "" || textBox1.Text == "")
            {
                btnCalcular.Enabled = false;
                lbllegal.Visible = false;
                lblresultado.Visible = false;
            }
            else
            {
                btnCalcular.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                btnCalcular.Enabled = false;
                lbllegal.Visible = false;
                lblresultado.Visible = false;
            }
            else
            {
                btnCalcular.Enabled = true;
            }
        }
    }
    
}
