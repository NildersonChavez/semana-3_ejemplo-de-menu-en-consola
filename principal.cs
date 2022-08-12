using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static semana_3_ejemplo_de_menu_en_consola.Ejemplo_if;
using static semana_3_ejemplo_de_menu_en_consola.Ejemplo_Switch;
using static semana_3_ejemplo_de_menu_en_consola.Ejemplo_for;
using static semana_3_ejemplo_de_menu_en_consola.Ejemplo_dowhile;
using static semana_3_ejemplo_de_menu_en_consola. Ejemplo_While;

namespace semana_3_ejemplo_de_menu_en_consola
{
    class principal
    {
        //Funcion principal que inicia el programa
        static void Main(string[] args)
        {
            System.Console.WriteLine("Proyecto de Menu");
            System.Console.WriteLine("Primer Programa Usando Estructuras");

            System.Console.ReadKey();

            int repetir;

            //menu_interno();
            do
            {
                Console.Clear();
                 menu_interno();

                System.Console.WriteLine("Ingrese 1 para repetir menú");
                System.Console.WriteLine("Ingrese 2 para salir");
                repetir = Int32.Parse(Console.ReadLine());

            } while (repetir == 1);
        }//Cierre de función principal;
        //Inicio de funciones interna
        static void menu_interno()
        {
            string opcion;
            int opcionint;

            System.Console.WriteLine("Menu Principal");
            System.Console.WriteLine("1. Ejemplo If");
            System.Console.WriteLine("2. Ejemplo Switch");
            System.Console.WriteLine("3. Ejemplo For");
            System.Console.WriteLine("4. Ejemplo Wor");
            System.Console.WriteLine("5. Ejemplo Do While");

            System.Console.WriteLine("Selecciona tu opcion: ");
            opcion = Console.ReadLine();
            opcionint = Int32.Parse(opcion);

            switch (opcionint)
            {
                case 1:

                    programa_if();

                    break;

                case 2:

                    programa_switch();
                    break;

                case 3:

                    programa_for();
                    break;

                case 4:

                    programa_while();
                    break;
                case 5:

                    programa_dowhile();
                    break;

                default:
                    System.Console.WriteLine("opcion no valida");
                    break;

            }



        }
   


