using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola_Convertir_numeros_a_letras
{
    class Program
    {
        static void Main(string[] args)
        {
            long cantidad, cantidad_digitos;
            string x, xx;
            
            Console.Write("Introduce la cantidad: ");
            long.TryParse(Console.ReadLine(), out cantidad);
            x = cantidad.ToString();
            
            cantidad_digitos = x.Length ;
            
            if (cantidad == 0)
            {
                Console.WriteLine( "Cero");
                Console.ReadLine();
            }
            else
            {

                if (cantidad_digitos <= 3)
                {
                    Console.WriteLine("{0}", Funcion_Grupo_Cien(cantidad));
                    //xx = Funcion_Grupo_Cien(cantidad);
                    Console.ReadLine();

                }

                else if (cantidad_digitos <= 6)
                {

                    Console.WriteLine("{0}", Funcion_Grupo_Mil(cantidad));
                     Console.ReadLine();
                }

                else if (cantidad_digitos <= 9)
                {
                    Console.WriteLine("{0}", Funcion_Grupo_Millon(cantidad));
                     Console.ReadLine();
                }
                else if (cantidad_digitos <= 12)
                {
                    Console.WriteLine("{0}", Funcion_Grupo_Mil_Millones(cantidad));
                     Console.ReadLine();
                }
                else if (cantidad_digitos > 12)
                {
                    Console.WriteLine("La cantidad debe ser de 12 digitos o menos");
                    Console.ReadLine();
                }

            }



        }
        public static string Funcion_Unidad_Decena(long cantidad)
        {
       
            string[] Numero = new string[100];
            string resultado;

        Numero[0] = "";
        Numero[1] = "Un";
        Numero[2] = "Dos";
        Numero[3] = "Tres";
        Numero[4] = "Cuatro";
        Numero[5] = "Cinco";
        Numero[6] = "Seis";
        Numero[7] = "Siete";
        Numero[8] = "Ocho";
        Numero[9] = "Nueve";
        Numero[10] = "Diez";
        Numero[11] = "Once";
        Numero[12] = "Doce";
        Numero[13] = "Trece";
        Numero[14] = "Catorce";
        Numero[15] = "Quince";
        Numero[16] = "Dieciseis";
        Numero[17] = "Diecisiete";
        Numero[18] = "Dieciocho";
        Numero[19] = "Diecinueve";
        Numero[20] = "Veinte";
        Numero[21] = "Veintiun";
        Numero[22] = "Veintidos";
        Numero[23] = "Veintitres";
        Numero[24] = "Veinticuatro";
        Numero[25] = "Veinticinco";
        Numero[26] = "Veintiseis";
        Numero[27] = "Veintisiete";
        Numero[28] = "Veintiocho";
        Numero[29] = "Veintinueve";
        Numero[30] = "Treinta";
        Numero[40] = "Cuarenta";
        Numero[50] = "Cincuenta";
        Numero[60] = "Sesenta";
        Numero[70] = "Setenta";
        Numero[80] = "Ochenta";
        Numero[90] = "Noventa";

        if (cantidad > 90 && cantidad <= 99)
            resultado = Numero[90] + " y " + Numero[cantidad - 90];
        else if (cantidad > 80 && cantidad <= 89)
            resultado = Numero[80] + " y " + Numero[cantidad - 80];
        else if (cantidad > 70 && cantidad <= 79)
            resultado = Numero[70] + " y " + Numero[cantidad - 70];
        else if (cantidad > 60 && cantidad <= 69)
            resultado = Numero[60] + " y " + Numero[cantidad - 60];
        else if (cantidad > 50 && cantidad <= 59)
            resultado = Numero[50] + " y " + Numero[cantidad - 50];
        else if (cantidad > 40 && cantidad <= 49)
            resultado = Numero[40] + " y " + Numero[cantidad - 40];
        else if (cantidad > 30 && cantidad <= 39)
            resultado = Numero[30] + " y " + Numero[cantidad - 30];
        else
            resultado = Numero[cantidad];

        return resultado;
        }

        public static string Funcion_Centena(long cantidad)
        {
            string resultado;

            if (cantidad >= 900)
            {
                resultado = "Novecientos ";

            }
            else if (cantidad >= 800)
            {
                resultado = "Ochocientos ";
            }
            else if (cantidad >= 700)
            {
                resultado = "Setecientos ";
            }
            else if (cantidad >= 600)
            {
                resultado = "Seiscientos ";
            }
            else if (cantidad >= 500)
            {
                resultado = "Quinientos ";
            }
            else if (cantidad >= 400)
            {
                resultado = "Cuatrocientos ";
            }
            else if (cantidad >= 300)
            {
                resultado = "Trescientos ";
            }
            else if (cantidad >= 200)
            {
                resultado = "Doscientos ";
            }
            else if (cantidad > 100)
            {
                resultado = "Ciento ";
            }
            else if (cantidad == 100)
            {
                resultado = "Cien ";
            }
            else
                resultado = "";
        
            return  resultado;
        }

        public static string Funcion_Grupo_Cien(long Cantidad)
        {
            string resultado;
            long unidad_decena, centena;

            unidad_decena = Cantidad % 100;
            centena = Cantidad;
            resultado = Funcion_Centena(centena) + Funcion_Unidad_Decena (unidad_decena) ;
            return resultado;
        
        }

        public static string Funcion_Grupo_Mil(long Cantidad)

        {
            long Grupo_100, Grupo_1000;
            string resultado;

            Grupo_100 = Cantidad % 1000;
            Grupo_1000 = (Cantidad - Grupo_100) / 1000;

            if (Grupo_1000 == 0)
            {
                resultado = " " + Funcion_Grupo_Cien(Grupo_100);
            }
            else if (Grupo_1000 == 1)
            {

                resultado = " Mil " + Funcion_Grupo_Cien(Grupo_100);
            }
            else
            {

                resultado = Funcion_Grupo_Cien(Grupo_1000) + " Mil " + Funcion_Grupo_Cien(Grupo_100);
            }

            return resultado;
        
        }

        public static string Funcion_Grupo_Millon(long Cantidad)
        {
            long Grupo_1000, Grupo_Millon;
            string resultado;

            Grupo_1000 = Cantidad % 1000000;
            Grupo_Millon = (Cantidad - Grupo_1000) / 1000000;

            if (Grupo_Millon == 0)
            {
                resultado = Funcion_Grupo_Cien(Grupo_Millon) + " " + Funcion_Grupo_Mil(Grupo_1000);
            }
            else if (Grupo_Millon == 1)
            {
                resultado = Funcion_Grupo_Cien(Grupo_Millon) + " Millon " + Funcion_Grupo_Mil(Grupo_1000);

            }
            else
            {
                resultado = Funcion_Grupo_Cien(Grupo_Millon) + " Millones " + Funcion_Grupo_Mil(Grupo_1000);
            }
       
         return resultado;
        }

        public static string Funcion_Grupo_Mil_Millones(long Cantidad)
        {
            long  Grupo_Mil_Millon, Grupo_Millon;
            string resultado;

            Grupo_Millon = Cantidad % 1000000000;
            Grupo_Mil_Millon = (Cantidad - Grupo_Millon) / 1000000000;

            if (Grupo_Mil_Millon == 0)
            {

                resultado = " " + Funcion_Grupo_Millon(Grupo_Millon); 
            }
            else if (Grupo_Mil_Millon == 1)
            {
                resultado = " Mil Millones " + Funcion_Grupo_Millon(Grupo_Millon);
            }

            else

            {
                resultado = Funcion_Grupo_Cien(Grupo_Mil_Millon) + " Mil Millones " + Funcion_Grupo_Millon(Grupo_Millon);
            }

            return resultado;
        }
    }
    
    }

