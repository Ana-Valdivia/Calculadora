using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplinho
{
    class Calculadora
    {
        //Atributos sempre são privados.
        private double num1;
        private double num2;

        //Encapsulamento.
        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }

        //Métodos.

        public double fazerSoma() //Método de somar
        {
            return(this.num1 + this.num2);
        }
        public double fazerSub() //Método de subtrair
        {
            {
            return (this.num1 - this.num2);
        }

    }
}