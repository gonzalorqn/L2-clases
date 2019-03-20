using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Sello.color = ConsoleColor.Gray;
        }

        private static string ArmarFormatoMensaje()
        {
            string retorno = "";
            for(int i=0;i<Sello.mensaje.Length +2 ;i++)
            {
                retorno += "*";
            }
            return retorno + "\n*" + Sello.mensaje + "*\n" + retorno;
        }
    }
}
