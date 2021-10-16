using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Esfera
    {

       


        public double CalculoEsfera(double r)
        {
            double volume = 4 / 3.14 * Math.Pow(r, 3);


            Console.WriteLine(" O valor da operação é  " , volume);
            return volume;

        }

    }
}
