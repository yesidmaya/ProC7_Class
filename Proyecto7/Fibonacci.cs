using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto7
{
    class Fibonacci
    {
        int num1 = 0;
        int num2 = 0;

        public Fibonacci() //Constructor sin parametros siempre tiene que estar
        {
            
        }

        public Fibonacci( int a, int b) //Constructor con parametros
        {
            num1 = a;
            num2 = b;
        }

        public int validarNumero(string valor)
        {
            int numero = 0;
            try
            {
                numero = Convert.ToInt32(valor); // convertimos valor a entero
            }
            catch (Exception /*ex*/)
            {
                Console.WriteLine("POR FAVOR DIGITA UN NUMERO" /*+ ex.ToString()*/); //ex para mostrar mas detalle del error
                Console.ReadLine();
            }
            return numero;
        }

        public string calcularFibonacci(int numero)
        {
            string mostrar = string.Empty;
            int suma = 0;
            while (suma <= numero)
            {
                suma = num1 + num2;
                num1 = num2;
                num2 = suma;
                mostrar = mostrar + " " + suma;
            }
            return mostrar;
        }
    }
}
