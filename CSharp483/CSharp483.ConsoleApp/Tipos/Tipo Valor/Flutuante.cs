using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp483.ConsoleApp.Tipos.Tipo_Valor
{
    class Flutuante
    {

        public void Executar()
        {
            float numeroComVirgula = 10.6f;
            double numeroMaiorComVirgula = 1000.85;
            decimal salarioRafael = 10000.00000m;
            Console.WriteLine(numeroComVirgula);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(Single.MaxValue);

            Console.WriteLine(double.MinValue);
            Console.WriteLine(Double.MaxValue);

            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(Decimal.MaxValue);


        }






    }
}
