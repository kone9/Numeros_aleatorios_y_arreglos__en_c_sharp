using System;
using System.Collections.Generic;
using System.Text;

namespace ParaHacerPruebasrapidas
{
    class CalcularEstacionDelAnio //OJO ESTE EJERCICIO NO ESTA TERMINADO, HAY PROBLEMA CON LAS FECHAS
    {

        public CalcularEstacionDelAnio()//metodo contructor esto es c# se llama desde el Main
        {
            Console.WriteLine("Ingrese MES:");
            int mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese DIA:");
            int dia = Convert.ToInt32(Console.ReadLine()); ;

            EsFechaInvierno(mes, dia);
            EsFechaPrivamera(mes, dia);
            EsFechaVerano(mes, dia);
            EsFechaOtonio(mes, dia);
            ErrorEnFecha();
        }
        private void EsFechaInvierno(int mes, int dia)
        {
            if (mes == 11 && dia >= 21 || mes == 2 && dia < 20)// ojo esta mal calculado
            {
                Console.WriteLine("estamos en invierno");
            }
        }

        private void EsFechaPrivamera(int mes, int dia)
        {
            if (mes == 2 && dia >= 21 || mes == 5 && dia < 21)
            {
                Console.WriteLine("estamos en Primavera");
            }
        }

        private void EsFechaVerano(int mes, int dia)
        {
            if (mes == 5 && dia >= 21 || mes == 8 && dia < 22)
            {
                Console.WriteLine("estamos en verano");
            }
        }

        private void EsFechaOtonio(int mes, int dia)
        {
            if (mes == 8 && dia >= 22 || mes == 11 && dia < 21)
            {
                Console.WriteLine("estamos en verano");
            }
        }

        private void ErrorEnFecha()
        {
            Console.WriteLine("la fecha ingresada es incorrecta");
        }

    }
}
