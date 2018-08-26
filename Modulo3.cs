using System;

namespace HolaVS
{
	class Program
	{
		static void Main(string[] args)
		{
			//1
			Console.WriteLine("Primer Ejercicio");
			int usu, contra, num1, num2, a, b, c, i;
			string usuario, contraseña, contraseña2, nombre;
			char letra;
			do
			{
				Console.WriteLine("Introducir su usuario:");
				while (!(Int32.TryParse(Console.ReadLine(), out usu))) { Console.WriteLine("Introducir un usuario valido"); }
				Console.WriteLine("Introducir su contraseña:");
				while (!(Int32.TryParse(Console.ReadLine(), out contra))) { Console.WriteLine("Introducir una contraseña valida"); }
			} while (usu != 1234 || contra != 1111);
			//2
			Console.WriteLine("Segundo Ejercicio");
			Console.WriteLine("Introducir un numero entero positivo");
			while (!(Int32.TryParse(Console.ReadLine(), out num1)) || num1<0) { Console.WriteLine("Introducir un numero valido"); }
			num2 = 1;
			while (num1>1)
			{
				num1= num1/10;
				num2 = ++num2;
			}
			Console.WriteLine(string.Format("La cantidad de digitos es {0}", num2));
			//3
			Console.WriteLine("Tercer Ejercicio");
			for (i = 0; i<11;i++) { Console.WriteLine(string.Format("9 x {0} = {1}", i, i*9)); }
			//4
			/*Console.WriteLine("Cuarto Ejercicio");
			num1 = 0;
			while(true) { num1 = ++num1;  Console.WriteLine(num1); }*/
			//5
			/*Console.WriteLine("Quinto Ejercicio");
			while(true) { Console.Write("Hola "); }*/
			//6
			Console.WriteLine("Sexto Ejercicio");
			a=5; b=++a; c=a++; b=b*5; a=a*2;
			Console.WriteLine(string.Format("a = {0}\nb = {1}\nc = {2}\n",a,b,c));
			//7
			Console.WriteLine("Septimo Ejercicio");
			a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b;
			Console.WriteLine(string.Format("a = {0}\nb = {1}\nc = {2}\n",a,b,c));
			//8
			Console.WriteLine("Octavo Ejercicio");
			Console.WriteLine("Introducir una letra:");
			while (!(Char.TryParse(Console.ReadLine(), out letra)) || "0123456789".IndexOf(letra) >= 0) { Console.WriteLine("Introducir una letra valida"); }
			Console.WriteLine(string.Format("{0}", ("aeiouAEIOUáéíóúÁÉÍÓÚ".IndexOf(letra) >= 0) ? string.Format("{0} es una vocal", letra) : string.Format("{0} no es una vocal", letra)));
			//9
			Console.WriteLine("Noveno Ejercicio");
			Console.WriteLine("Introducir su usuario:");
			usuario = Console.ReadLine();
			do
			{
				Console.WriteLine("Escribir la contraseña");
				contraseña = Console.ReadLine();
				Console.WriteLine("Escribir la contraseña nuevamente");
				contraseña2 = Console.ReadLine();
			} while (contraseña != contraseña2);
			//10
			Console.WriteLine("Decimo Ejercicio");
			Console.WriteLine("Escriba su nombre: ");
			nombre = Console.ReadLine();
			Console.WriteLine(string.Format("{0}", (nombre == "Martín") ? "Hola" : "No te conozco"));
		}
	}
}