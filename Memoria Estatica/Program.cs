using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Memoria_Estatica
{
    internal class Program
    { 
        static public int contadormemoria = 0;
        static void IncrementarContador()
        {
            contadormemoria++;
        }
        static void Main(string[] args)
        {
            int repeticiones = 0;
            Console.WriteLine("Memoría Estática \n" +
            "Ingresa la cantidad de veces que se quieres que se mande a llamar una parte de la memoría");
            repeticiones = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeticiones; i++)
            {
                IncrementarContador();
                if (i == 0)
                {
                    Console.WriteLine("Memoria usada: " + (i + 1) + " Ves");
                }
                else
                {
                    Console.WriteLine("Memoria usada: " + (i + 1) + " Veces");
                }
                Console.WriteLine("La cantidad de veces que se uso la memoría fue: " + contadormemoria);
            }
            Console.ReadKey();
        }
    }
}