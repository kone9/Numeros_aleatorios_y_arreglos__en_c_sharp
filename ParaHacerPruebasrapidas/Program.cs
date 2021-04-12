using System;
using System.Linq;

namespace ParaHacerPruebasrapidas
{
    class Program
    {
		static int[] listaDeNumerosAleatorios = new int[10];

		static void Main(string[] args)
        {
			Console.WriteLine("HOLA World");
			listaDeNumerosAleatorios = GenerarNumerosAleatorios();
			string losNumerosSon = "";
			foreach(int i in listaDeNumerosAleatorios)
            {
				losNumerosSon = losNumerosSon + "  " + i;
            }

			Console.WriteLine("Los numeros aleatorios son: " + losNumerosSon);
			Console.WriteLine("El numero Minimo es: " + CalcularMinimo(listaDeNumerosAleatorios));
			Console.WriteLine("El numero Maximo es: " + CalcularMaximo(listaDeNumerosAleatorios));
			Console.WriteLine("La Suma de todo es: " + SumaDeTodosLosNumeros(listaDeNumerosAleatorios));


		}

		static int[] GenerarNumerosAleatorios(int minimo = 400, int maximo = 800)
		{
			Random rnd = new Random();

			int[] numerosGenerados = new int[10];

			for (int i = 0; i < 10; i++)
			{

				int numerosAleatorio = rnd.Next(minimo, maximo);
				numerosGenerados[i] = numerosAleatorio;
			}

			return numerosGenerados;
		}

		static int CalcularMinimo(int[] numeros)
        {
			int numeroMinimo = numeros.Min();
			return numeroMinimo;
        }

		static int CalcularMaximo(int[] numeros)
        {
			int numeroMaximo = numeros.Max();
			return numeroMaximo;
		}

		static int SumaDeTodosLosNumeros(int[] numeros)
        {
			int sumaDeLosNumeros = numeros.Sum();
			return sumaDeLosNumeros;
		}
	}
}
