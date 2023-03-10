using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diseñado por Ruth

            //Fecha: 12/02/2023
            Console.WindowHeight = 40;
            Console.WindowWidth = 70;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            //Título
            Console.Title = "Calculo de Resistencias...";
            //Declaración de variables
            String banda1, banda2, banda3, banda4;
            int b1, b2, c1;
            Double total = 0;
            //Entrada
            Console.WriteLine("\n");
            Console.Write("\t****************************************************");
            Console.WriteLine("\n                COLOR   DE   LA    PRIMER    BANDA       ");
            Console.WriteLine("\t  [N] - NEGRO     [M] - MARRON     [R] - ROJO       ");
            Console.WriteLine("\t  [O] - NARANJA   [Y] - AMARILLO   [V] - VERDE      ");
            Console.WriteLine("\t  [B] - AZUL      [P] - VIOLETA    [G] - GRIS       ");
            Console.WriteLine("\t  [W] - BLANCO ");
            Console.WriteLine("\t****************************************************");
            Console.Write("\tDigitar la primer letra de la Banda 1 segun su color: ");
            banda1 = Console.ReadLine();

            // Calculos de la primer banda
            switch (banda1)
            {
                case "N":
                case "n":
                    b1 = 10;
                    b2 = 0;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la primer banda es: " + c1);
                    break;
                case "M":
                case "m":
                    b1 = 10;
                    b2 = 1;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la primer banda es: " + c1);
                    break;
                case "R":
                case "r":
                    b1 = 10;
                    b2 = 2;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la primer banda es: " + c1);
                    break;
                case "O":
                case "o":
                    b1 = 10;
                    b2 = 3;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la primer banda es: " + c1);
                    break;
                case "Y":
                case "y":
                    b1 = 10;
                    b2 = 4;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la primer banda es: " + c1);
                    break;
                case "V":
                case "v":
                    b1 = 10;
                    b2 = 5;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la primer banda es: " + c1);
                    break;
                case "B":
                case "b":
                    b1 = 10;
                    b2 = 6;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la primer banda es: " + c1);
                    break;
                case "P":
                case "p":
                    b1 = 10;
                    b2 = 7;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la primer banda es: " + c1);
                    break;
                case "G":
                case "g":
                    b1 = 10;
                    b2 = 8;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la primer banda es: " + c1);
                    break;
                case "W":
                case "w":
                    b1 = 10;
                    b2 = 9;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la primer banda es: " + c1);
                    break;
            }
            Console.WriteLine("\n");
            //Console.Write("\tEl valor de la primer banda es: " + total);   
            Console.WriteLine("\n");

            Console.Write("\t****************************************************");
            Console.WriteLine("\n                COLOR   DE   LA    SEGUNDA    BANDA       ");
            Console.WriteLine("\t  [N] - NEGRO     [M] - MARRON     [R] - ROJO       ");
            Console.WriteLine("\t  [O] - NARANJA   [Y] - AMARILLO   [V] - VERDE      ");
            Console.WriteLine("\t  [B] - AZUL      [P] - VIOLETA    [G] - GRIS       ");
            Console.WriteLine("\t  [W] - BLANCO ");
            Console.WriteLine("\t****************************************************");
            Console.Write("\tDigitar la primer letra de la Banda 2 segun su color: ");
            banda2 = Console.ReadLine();

            // Calculos segunda banda
            switch (banda2)
            {
                case "N":
                case "n":
                    b1 = 1;
                    b2 = 0;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la segunda banda es: " + c1);
                    break;
                case "M":
                case "m":
                    b1 = 1;
                    b2 = 1;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la segunda banda es: " + c1);
                    break;
                case "R":
                case "r":
                    b1 = 1;
                    b2 = 2;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la segunda banda es: " + c1);
                    break;
                case "O":
                case "o":
                    b1 = 1;
                    b2 = 3;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la segunda banda es: " + c1);
                    break;
                case "Y":
                case "y":
                    b1 = 1;
                    b2 = 4;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la segunda banda es: " + c1);
                    break;
                case "V":
                case "v":
                    b1 = 1;
                    b2 = 5;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la segunda banda es: " + c1);
                    break;
                case "B":
                case "b":
                    b1 = 1;
                    b2 = 6;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la segunda banda es: " + c1);
                    break;
                case "P":
                case "p":
                    b1 = 1;
                    b2 = 7;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la segunda banda es: " + c1);
                    break;
                case "G":
                case "g":
                    b1 = 1;
                    b2 = 8;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la segunda banda es: " + c1);
                    break;
                case "W":
                case "w":
                    b1 = 1;
                    b2 = 9;
                    c1 = b2 * b1;
                    total = total + c1;
                    Console.Write("\tEl valor de la segunda banda es: " + c1);
                    break;
            }
            Console.WriteLine("\n");
            Console.WriteLine("\tEl valor de las 2 bandas es: " + total);
            Console.Write("\tPresione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n");
            Console.Write("\t****************************************************");
            Console.WriteLine("\n                COLOR   DE   LA    TERCER    BANDA       ");
            Console.WriteLine("\t  [N] - NEGRO     [M] - MARRON     [R] - ROJO       ");
            Console.WriteLine("\t  [O] - NARANJA   [Y] - AMARILLO   [V] - VERDE      ");
            Console.WriteLine("\t  [B] - AZUL      [P] - VIOLETA    [G] - GRIS       ");
            Console.WriteLine("\t  [W] - BLANCO ");
            Console.WriteLine("\t****************************************************");
            Console.Write("\tDigitar la primer letra de la Banda 3 segun su color: ");
            banda3 = Console.ReadLine();

            // Calculos tercer banda
            switch (banda3)
            {
                case "N":
                case "n":
                    // negro vale 1
                    b1 = 1;
                    b2 = 1;
                    total = total * b1;
                    //Console.WriteLine("\tEl valor de la tercer banda es: " + b1);
                    Console.Write("\tEl valor de las 3 bandas es: " + total + " ohmios");
                    break;
                case "M":
                case "m":
                    // marron vale 10
                    b1 = 10;
                    b2 = 1;
                    total = total * b1;
                    //Console.WriteLine("\tEl valor de la tercer banda es: " + b1);
                    Console.Write("\tEl valor de las 3 bandas es: " + total + " ohmios");
                    break;
                case "R":
                case "r":
                    // rojo vale 100
                    b1 = 100;
                    b2 = 2;
                    total = total * b1;
                    total = total / 1000;
                    //Console.WriteLine("\tEl valor de la tercer banda es: " + b1);
                    Console.Write("\tEl valor de las 3 bandas es: " + total + "K ohmios");
                    break;
                case "O":
                case "o":
                    // naranja vale 1,000
                    b1 = 1000;
                    b2 = 3;
                    total = total * b1;
                    total = total / 1000;
                    //Console.WriteLine("\tEl valor de la tercer banda es: " + b1);
                    Console.Write("\tEl valor de las 3 bandas es: " + total + "K ohmios");
                    break;
                case "Y":
                case "y":
                    // amarillo vale 10,000
                    b1 = 10000;
                    b2 = 4;
                    total = total * b1;
                    total = total / 1000;
                    //Console.WriteLine("\tEl valor de la tercer banda es: " + b1);
                    Console.Write("\tEl valor de las 3 bandas es: " + total + "K ohmios");
                    break;
                case "V":
                case "v":
                    // verde vale 100,000
                    b1 = 100000;
                    b2 = 5;
                    total = total * b1;
                    total = total / 1000000;
                    //Console.WriteLine("\tEl valor de la tercer banda es: " + b1);
                    Console.Write("\tEl valor de las 3 bandas es: " + total + "M ohmios");
                    break;
                case "B":
                case "b":
                    // azul vale 1,000,000
                    b1 = 1000000;
                    b2 = 6;
                    total = total * b1;
                    total = total / 1000000;
                    //Console.WriteLine("\tEl valor de la tercer banda es: " + b1);
                    Console.Write("\tEl valor de las 3 bandas es: " + total + "M ohmios");
                    break;
                case "P":
                case "p":
                    // morado vale 10,000,000
                    b1 = 10000000;
                    b2 = 7;
                    total = total * b1;
                    total = total / 1000000;
                    //Console.WriteLine("\tEl valor de la tercer banda es: " + b1);
                    Console.Write("\tEl valor de las 3 bandas es: " + total + "M ohmios");
                    break;
                case "G":
                case "g":
                    // gris vale 100,000,000
                    b1 = 100000000;
                    b2 = 8;
                    total = total * b1;
                    total = total / 1000000000;
                    //Console.WriteLine("\tEl valor de la tercer banda es: " + b1);
                    Console.Write("\tEl valor de las 3 bandas es: " + total + "G ohmios");
                    break;
                case "W":
                case "w":
                    // blanco vale 1,000,000,000
                    b1 = 1000000000;
                    b2 = 9;
                    total = total * b1;
                    total = total / 1000000000;
                    //Console.WriteLine("\tEl valor de la tercer banda es: " + b1);
                    Console.Write("\tEl valor de las 3 bandas es: " + total + "G ohmios");
                    break;
            }
            Console.WriteLine("\n");
            //Console.Write("\tEl valor de las 3 bandas es: " + total + "K ohmios");   
            Console.Write("\t****************************************************");
            Console.WriteLine("\n                COLOR   DE   LA    TOLERANCIA       ");
            Console.WriteLine("\t  [M] - MARRON     [R] - ROJO      [X] - SIN BANDA  ");
            Console.WriteLine("\t  [D] - DORADO     [P] - PLATEADO                   ");
            Console.WriteLine("\t****************************************************");
            Console.Write("\tDigitar la primer letra de la Banda 4 segun su color: ");
            banda4 = Console.ReadLine();
            // Calculos tercer banda
            switch (banda4)
            {
                case "M":
                case "m":
                    // marron vale 1%
                    //Console.WriteLine("\tEl valor de las 3 bandas es: " + total + " ohmios");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tcon 1% de tolerancia");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "R":
                case "r":
                    // rojo vale 2%
                    //Console.Write("\tEl valor de las 3 bandas es: " + total + "K ohmios");  
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tcon 2% de tolerancia");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "D":
                case "d":
                    // dorado vale 5%
                    //Console.Write("\tEl valor de las 3 bandas es: " + total + "K ohmios");  
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tcon 5% de tolerancia");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "P":
                case "p":
                    // plateado vale 10%
                    //Console.Write("\tEl valor de las 3 bandas es: " + total + "K ohmios");  
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tcon 10% de tolerancia");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    // sin color vale 20%
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\tcon 20% de tolerancia");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
            Console.WriteLine("\n");
            //Pantalla opcional
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*     Este programa fue diseñado por:       *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*                RUTH CORTEZ                 *");
            Console.WriteLine("\t*                                           *");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();






        }
    }
}
