using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float salario, percentual, aumento, salarioFinal;

            salario = float.Parse(textBox1.Text);
            percentual = float.Parse(textBox2.Text);
            aumento = salario * percentual / 100;
            salarioFinal = salario + aumento;

            label4.Text = salarioFinal.ToString("C");
            label5.Text = aumento.ToString("C");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
