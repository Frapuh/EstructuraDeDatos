using System;

namespace HolaVs
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declaro variables a usar
			int res, numero1, numero2;
			float numero3;
			//Ejercicios
			//1
			Console.WriteLine("Primer Ejercicio"); Console.WriteLine(200+56);
			//2
			Console.WriteLine("Segundo Ejercicio"); Console.WriteLine(13*12);
			//3
			Console.WriteLine("Tercer Ejercicio"); Console.WriteLine(321-213);
			//4
			Console.WriteLine("Cuarto Ejercicio"); Console.WriteLine((20+5)/6);
			//5
			Console.WriteLine("Quinto Ejercicio"); res = 12 * 102; Console.WriteLine(res);
			//6
			Console.WriteLine("Sexto Ejercicio"); res = 200 + 1111; Console.WriteLine(res);
			//7
			Console.WriteLine("Septimo Ejercicio"); 
			numero1 = 10; numero2 = 25; 
			Console.WriteLine(numero1 * numero2);
			//8
			Console.WriteLine("Octavo Ejercicio");
			Console.WriteLine("Ingrese primero un numero y luego el otro:");
			while (!(Int32.TryParse(Console.ReadLine(), out numero1))) { Console.WriteLine("Introducir un numero valido"); } 
			while (!(Int32.TryParse(Console.ReadLine(), out numero2))) { Console.WriteLine("Introducir un numero valido"); } 
			Console.WriteLine(numero1 * numero2);
			//9
			Console.WriteLine("Noveno Ejercicio");
			Console.WriteLine("Ingrese un numero para verificar si es entero y par");
			while (!(float.TryParse(Console.ReadLine(), out numero3))) { Console.WriteLine("Introducir un numero valido"); } 
			Console.WriteLine(string.Format("El numero {0} {1}" , numero3, (numero3 % 2 == 0) ? "es par" : "es impar"));
			Console.WriteLine(string.Format("El numero {0} {1}" , numero3, (numero3 % 1 == 0) ? "es entero" : "no es entero"));
			//10
			Console.WriteLine("Decimo Ejercicio");
			Console.WriteLine("Ingrese dos numero para saber cual es el mayor:");
			while (!(Int32.TryParse(Console.ReadLine(), out numero1))) { Console.WriteLine("Introducir un numero valido"); } 
			while (!(Int32.TryParse(Console.ReadLine(), out numero2))) { Console.WriteLine("Introducir un numero valido"); } 
			Console.WriteLine(string.Format("{0}", (numero1 > numero2) ? string.Format("{0} es mayor", numero1) : string.Format("{0} es mayor", numero2)));
			//11
			Console.WriteLine("Onceavo Ejercicio");
			Console.WriteLine("Ingrese dos numero para dividir:");
			while (!(Int32.TryParse(Console.ReadLine(), out numero1))) { Console.WriteLine("Introducir un numero valido"); } 
			while (!(Int32.TryParse(Console.ReadLine(), out numero2))) { Console.WriteLine("Introducir un numero valido"); }
			Console.WriteLine(string.Format("{0}", (numero2 != 0) ? string.Format("{0}",(Convert.ToDouble(numero1) / Convert.ToDouble(numero2))) : "Error no se puede dividir por 0"));
			//12
			Console.WriteLine("Doceavo Ejercicio");
			Console.WriteLine("Introducir un numero entre 0 y 5");
			while (!(Int32.TryParse(Console.ReadLine(), out numero1)) && !((numero1 > 0) && (numero1 < 6))) { Console.WriteLine("Introducir un numero entre 0 y 5"); }
			switch (numero1)
			{
				case 1: Console.WriteLine("Uno"); break;
				case 2: Console.WriteLine("Dos"); break;
				case 3: Console.WriteLine("Tres"); break;
				case 4: Console.WriteLine("Cuatro"); break;
				case 5: Console.WriteLine("Cinco"); break;
			}
			//13
			Console.WriteLine("Treceeavo Ejercicio");
			numero1 = 1;
			while (numero1 < 11)
			{
				Console.WriteLine(numero1);
				numero1 = numero1 + 1;
			}
			//14
			Console.WriteLine("Catorceavo Ejercicio");
			numero1 = 1;
			do
			{
				Console.WriteLine(numero1);
				numero1 = numero1 + 1;
			} while(numero1<11);
			//15
			Console.WriteLine("Quinceavo Ejercicio");
			for (numero1 = 10; numero1<21; numero1++)
			{
				Console.WriteLine(numero1);
			}
		}
	}
}
		