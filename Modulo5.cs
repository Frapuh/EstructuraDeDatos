using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int Signo(Double num)
        {
            int num2;
            if (num < 0) num2 = -1;
            else if (num == 0) num2 = 0;
            else num2 = 1;
            return num2;
        }

        int Menor(int num1, int num2)
        {
            if (num1 > num2) num1 = num2;
            return num1;
        }

        bool EsPrimo (int num1)
        {
            bool esPrimo = false;
            if (num1 == 1)
            {
                esPrimo = true;
                return esPrimo;
            }
            else if (num1 < 1)
            {
                Console.WriteLine("Ingresar un numero positivo");
                return esPrimo;
            }
            else
            {
                for (int i = 2; i < num1 / 2; i++)
                {
                    if (num1 % i == 0) esPrimo = true;
                    break;
                }
            }
            return esPrimo;
        }

        static void Dibuja() //Dibuja una piramide
        {
            Console.Clear();
            for (int fila = 1; fila <= 7; fila++)
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                {
                    Console.Write(" ");
                }
                for (int conta = 1; conta < (2 * fila); conta++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }

        static void Calcula()
        {
            int num1, num2, opt;
            while (true)
            {
                Console.WriteLine("Ingrese accion a realizar: 1-Sumar 2-Restar 3-Dividir 4-Multiplicar 5-Salir");
                while (!(Int32.TryParse(Console.ReadLine(), out opt)));
                if(opt == 5)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Ingrese primer numero entero");
                    while (!(Int32.TryParse(Console.ReadLine(), out num1))) ;
                    Console.WriteLine("Ingrese segundo numero entero");
                    while (!(Int32.TryParse(Console.ReadLine(), out num2)));
                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("El resultado es {0}", num1 + num2);
                            break;
                        case 2:
                            Console.WriteLine("El resultado es {0}", num1 - num2);
                            break;
                        case 3:
                            Console.WriteLine("El resultado es {0}", (double)num1 / num2);
                            break;
                        case 4:
                            Console.WriteLine("El resultado es {0}", num1 * num2);
                            break;
                    }
                }
                
            }
        }

        static int SumaCifras(int num)
        {
            int res = 0;
            for (int i = 0; i< Convert.ToString(num).Length; i++)
            {
                res = res + Convert.ToInt32(num.ToString().Substring(i, 1));
            }
            return res;
        }

        static void Triangulo(char let, int num)
        {
            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat(let, i)));
            }
        }


        static void Main(string[] args)
        {
            Triangulo('A', 4);

        }
    }
}
