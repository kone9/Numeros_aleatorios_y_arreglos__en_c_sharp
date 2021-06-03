using System;
using System.Linq;
using System.Collections.Generic;



namespace ParaHacerPruebasrapidas
{

    class Program
    {
		static int[] listaDeNumerosAleatorios = new int[10];

		static void Main(string[] args)
        {
			ConvertirDeNumerosRomanosAEnteros nuevoNumero = new ConvertirDeNumerosRomanosAEnteros();
		}








        static string PruebaReturn(int num)
        {
            if (num <= 0) return "";
            Console.WriteLine("el numero no es cero");
            return num.ToString();
        }

		static void mostrarLosNumerosAleatorios()
        {
			Console.WriteLine("HOLA World");
			listaDeNumerosAleatorios = GenerarNumerosAleatorios();
			string losNumerosSon = "";
			foreach (int i in listaDeNumerosAleatorios)
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

				int numerosAleatorio = rnd.Next(minimo, maximo + 1);
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







//public class Challenge
//{
//    public static string Numerals(int num)
//    {
//        int number = 1995;
//        string RomanNumeral = "";
//        //if number is greater than zero
//        if (number > 0)
//        {
//            //I use integer as parameter in function and save in string type variable.
//            RomanNumeral = ConverttoRomanNumera(number);
//        }
//        return RomanNumeral;
//    }

//    public static string ConverttoRomanNumera(int number)
//    {

//        int units = 0, tens = 0, hundreds = 0, thousand = 0;

//        units = number % 10; number /= 10;
//        tens = number % 10; number /= 10;
//        hundreds = number % 10; number /= 10;
//        thousand = number % 10; number /= 10;

//        string newRomanNumeral = "";

//        //thousand
//        switch (thousand)
//        {
//            case 1:
//                newRomanNumeral = "M";
//                break;
//            case 2:
//                newRomanNumeral = "MM";
//                break;
//            case 3:
//                newRomanNumeral = "MMM";
//                break;
//        }

//        //hundreds
//        switch (hundreds)
//        {
//            case 1:
//                newRomanNumeral += "C";
//                break;
//            case 2:
//                newRomanNumeral += "CC";
//                break;
//            case 3:
//                newRomanNumeral += "CCC";
//                break;
//            case 4:
//                newRomanNumeral += "CD";
//                break;
//            case 5:
//                newRomanNumeral += "D";
//                break;
//            case 6:
//                newRomanNumeral += "DC";
//                break;
//            case 7:
//                newRomanNumeral += "DCC";
//                break;
//            case 8:
//                newRomanNumeral += "DCCC";
//                break;
//            case 9:
//                newRomanNumeral += "CM";
//                break;
//        }


//        //tens
//        switch (tens)
//        {
//            case 1:
//                newRomanNumeral += "X";
//                break;
//            case 2:
//                newRomanNumeral += "XX";
//                break;
//            case 3:
//                newRomanNumeral += "XXX";
//                break;
//            case 4:
//                newRomanNumeral += "XL";
//                break;
//            case 5:
//                newRomanNumeral += "L";
//                break;
//            case 6:
//                newRomanNumeral += "LX";
//                break;
//            case 7:
//                newRomanNumeral += "LXX";
//                break;
//            case 8:
//                newRomanNumeral += "LXXX";
//                break;
//            case 9:
//                newRomanNumeral += "XC";
//                break;
//        }



//        //units
//        switch (units)
//        {
//            case 1:
//                newRomanNumeral += "I";
//                break;
//            case 2:
//                newRomanNumeral += "II";
//                break;
//            case 3:
//                newRomanNumeral += "III";
//                break;
//            case 4:
//                newRomanNumeral += "IV";
//                break;
//            case 5:
//                newRomanNumeral += "V";
//                break;
//            case 6:
//                newRomanNumeral += "VI";
//                break;
//            case 7:
//                newRomanNumeral += "VII";
//                break;
//            case 8:
//                newRomanNumeral += "VIII";
//                break;
//            case 9:
//                newRomanNumeral += "IX";
//                break;
//        }

//        return newRomanNumeral; //return number in string
//    }

//}