using System;
using System.Collections.Generic;
using System.Text;

namespace ParaHacerPruebasrapidas
{
    class ConvertirANumerosRomanos
    {
        public ConvertirANumerosRomanos()
        {
            //mostrarLosNumerosAleatorios();
            //CalcularEstacionDelAnio calcularAnio = new CalcularEstacionDelAnio();
            while (true)
            {
                Console.WriteLine("Please enter a number from 1 to 3999 to convert to a Roman numeral");
                //input string
                string input = Console.ReadLine();
                //convert to int
                int number = Int16.Parse(input);
                //if number is negative or less than 3999
                if (number <= 0 || number > 3999)
                {
                    Console.WriteLine("Incorrect number only from 1 to 3999");
                }
                //if number is greater than zero
                if (number > 0)
                {
                    //I use integer as parameter in function and save in string type variable.
                    string romanNumeral = ConverttoRomanNumera(number);

                    Console.WriteLine(romanNumeral);
                }
            }
        }

        private string ConverttoRomanNumera(int number)
        {
            if (number < 0) return "ESTOY USANDO CERO NO FUNCIONA";

            int units = 0, tens = 0, hundreds = 0, thousand = 0;

            units = number % 10; number /= 10;
            tens = number % 10; number /= 10;
            hundreds = number % 10; number /= 10;
            thousand = number % 10; number /= 10;

            string newRomanNumeral = "";

            //thousand
            switch (thousand)
            {
                case 1:
                    newRomanNumeral = "M";
                    break;
                case 2:
                    newRomanNumeral = "MM";
                    break;
                case 3:
                    newRomanNumeral = "MMM";
                    break;
            }

            //hundreds
            switch (hundreds)
            {
                case 1:
                    newRomanNumeral += "C";
                    break;
                case 2:
                    newRomanNumeral += "CC";
                    break;
                case 3:
                    newRomanNumeral += "CCC";
                    break;
                case 4:
                    newRomanNumeral += "CD";
                    break;
                case 5:
                    newRomanNumeral += "D";
                    break;
                case 6:
                    newRomanNumeral += "DC";
                    break;
                case 7:
                    newRomanNumeral += "DCC";
                    break;
                case 8:
                    newRomanNumeral += "DCCC";
                    break;
                case 9:
                    newRomanNumeral += "CM";
                    break;
            }


            //tens
            switch (tens)
            {
                case 1:
                    newRomanNumeral += "X";
                    break;
                case 2:
                    newRomanNumeral += "XX";
                    break;
                case 3:
                    newRomanNumeral += "XXX";
                    break;
                case 4:
                    newRomanNumeral += "XL";
                    break;
                case 5:
                    newRomanNumeral += "L";
                    break;
                case 6:
                    newRomanNumeral += "LX";
                    break;
                case 7:
                    newRomanNumeral += "LXX";
                    break;
                case 8:
                    newRomanNumeral += "LXXX";
                    break;
                case 9:
                    newRomanNumeral += "XC";
                    break;
            }



            //units
            switch (units)
            {
                case 1:
                    newRomanNumeral += "I";
                    break;
                case 2:
                    newRomanNumeral += "II";
                    break;
                case 3:
                    newRomanNumeral += "III";
                    break;
                case 4:
                    newRomanNumeral += "IV";
                    break;
                case 5:
                    newRomanNumeral += "V";
                    break;
                case 6:
                    newRomanNumeral += "VI";
                    break;
                case 7:
                    newRomanNumeral += "VII";
                    break;
                case 8:
                    newRomanNumeral += "VIII";
                    break;
                case 9:
                    newRomanNumeral += "IX";
                    break;
            }

            return newRomanNumeral; //return number in string


        }
    }

}
