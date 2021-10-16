using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class CalculoImc
    {
        public void Main(double entrada1, double entrada2)
        {

            double imc;
            double peso = entrada1; //entrada1;
            double altura = entrada2; //entrada2;


            imc = (peso / (altura * altura));

            if (imc < 20)
            {
                Console.WriteLine("Voce esta acima do peso ");
            }
            if (20 <= imc && imc < 25)
            {
                Console.WriteLine("voce esta dentro do peso");
            }
            else
            {
                Console.WriteLine("voce esta acima do peso");
            }

        }
    }
}

