using System;
using System.Collections.Generic;
using System.Text;

namespace ParaHacerPruebasrapidas
{
    class ConvertirDeNumerosRomanosAEnteros
    {
        public ConvertirDeNumerosRomanosAEnteros()
        {
            Console.WriteLine(Decode("D"));
        }

        private int Decode(string roman)
        {
            int result = 0;
            int lenghtRomanNumber = roman.Length;

            Dictionary<string, int> RomanTONumber = new Dictionary<string, int>();
            RomanTONumber.Add("I", 1);
            RomanTONumber.Add("V", 5);
            RomanTONumber.Add("X", 10);
            RomanTONumber.Add("L", 50);
            RomanTONumber.Add("C", 100);
            RomanTONumber.Add("D", 500);
            RomanTONumber.Add("M", 1000);


            for (int i = 0; i < lenghtRomanNumber - 1; i++)
            {
                int currentValue = RomanTONumber[ roman [ i ].ToString() ];
                if (currentValue < RomanTONumber[ roman [ i + 1 ].ToString()])
                {
                    result -= currentValue;
                }
                else
                {
                    result += currentValue;
                }
            }

            result = result + RomanTONumber[roman[roman.Length - 1].ToString()];

            return result;
        }
    }
}
