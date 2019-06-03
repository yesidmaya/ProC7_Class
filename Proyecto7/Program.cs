using Proyecto7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto5_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************** Serie Fibonacci: 0,1,1,2,3,5,8,13,21,34,55,89....

            int numero = -1;
            int a = 0;
            int b = 1;
            string mostrarPantalla = String.Empty;// almacenamos la cadena de texto y colocamos la cadena vacia
            mostrarPantalla = "0";

            Console.WriteLine("Introduzca valor FINAL de la serie FIBONACCI ->");
            string valor = Console.ReadLine(); // tomamos valor

            Proyecto7.Fibonacci fib = new Fibonacci(a, b); // llamamos a cla CLASS con constructor de clase
                                                           // se lo puede simplificar asi Fibonacci fib = new Fibonacci();

            numero = fib.validarNumero(valor); // instanciamos el objeto de la CLASS
            mostrarPantalla = fib.calcularFibonacci(numero); // instanciamos el objeto de la CLASS


            //mostrarPantalla = mostrarPantalla + calcularFibonacci(a, b, numero); // llamamos al METODO calcularFibonacci

            Console.WriteLine(mostrarPantalla);
            Console.ReadLine();
        }

        
    }
}
