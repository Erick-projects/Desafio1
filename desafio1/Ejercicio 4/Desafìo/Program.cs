using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafìo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 20;
            Console.WindowWidth = 65;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.Title = "Cálculo de salario semanal";

            double horas, horasextra, valor, porcentaje;
            Console.WriteLine("\nDigite número de horas trabajadas");
            horas = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite valor de salario establecido");
            valor = double.Parse(Console.ReadLine());
            Console.Clear();


            if (horas <= 30)
            {
                horas = horas * valor;
                Console.WriteLine("\n\tEl salario a pagar es de: $" + horas);
            }
            else
            {
                if (horas>30);
              {
                    horas = horas * valor;
                    Console.WriteLine("\n\tInserte horas extras trabajadas");
                    horasextra = double.Parse(Console.ReadLine());
                    Console.Clear();

                porcentaje = ((30 * valor) / 125);
                horasextra = horasextra * porcentaje;
                Console.WriteLine("\n\tEl salario a pagar es de: $" + horas);
                Console.WriteLine("\n\tLa bonificaciòn sumada es de: $" + horasextra);
              }
            }
            Console.Write("\n\n");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("\t* *");
            Console.WriteLine("\t*       Este programa fue diseñado por:   *");
            Console.WriteLine("\t* *");
            Console.WriteLine("\t*                Gabriela Gómez          *");
            Console.WriteLine("\t* *");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
    }
}
