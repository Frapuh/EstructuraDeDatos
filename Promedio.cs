using System;

public class Promedio{
	public static void Main(string[] args)
	{
		int totalClases, cantClases;
		Console.WriteLine("Ingresar la cantidad total de clases");
		while(!(Int32.TryParse(Console.ReadLine(), out totalClases))) { Console.WriteLine("Ingresar una cantidad correcta"); } 
		Console.WriteLine("Ingresar la cantidad de asistencias");
		while(!(Int32.TryParse(Console.ReadLine(), out cantClases))) { Console.WriteLine("Ingresar una cantidad correcta"); } 

		CalcularAsistencia(cantClases, totalClases);
	}	

	static void CalcularAsistencia (int cantClases, int totalClases)
	{
		if ((float)cantClases/(float)totalClases >= 0.75)
		{
			Console.WriteLine("Tenes la asistencia correcta");
		} else
		{
			Console.WriteLine("Quedaste libre!");
		}
	}

}