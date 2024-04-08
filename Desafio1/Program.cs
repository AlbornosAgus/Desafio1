using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("G","Moto");

            Console.WriteLine("El telefono es un "+t1.Marca+" "+ t1.Modelo);
            Console.WriteLine("");
            Console.WriteLine(t1.Llamar());
            Console.WriteLine("");
            Console.WriteLine(t1.Llamar("Antonio"));
            Console.WriteLine("");
            t1.NumeroTelefonico = "1522437231";
            Console.WriteLine(t1.NumeroTelefonico);
        }
    }
}
