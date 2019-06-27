using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciar.
            //nomedoobjeto = colocar o nome do objeto.

            Calculadora calc = new Calculadora();
            calc.Num1 = Convert.ToDouble(textBox1.Text);
            calc.Num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(calc.fazerSoma());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.Num1 = Convert.ToDouble(textBox1.Text);
            calc.Num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(calc.fazerSub());

        }
    }
}
