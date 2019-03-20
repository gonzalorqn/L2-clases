using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "hola";
            Console.WriteLine(Sello.Imprimir());
            Console.ReadLine();

            Sello.color = ConsoleColor.DarkGreen;
            Sello.ImprimirEnColor();
            Console.ReadLine();
            
            Sello.ImprimirEnColor();
            Console.ReadLine();
        }
    }
}
