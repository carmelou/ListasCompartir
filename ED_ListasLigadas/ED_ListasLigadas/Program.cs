using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_ListasLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista=new Lista();
            if(lista.EstaVacia())
                {
            Console.WriteLine("esta vacia");
            }
            else {
            Console.WriteLine("no esta vacia");}
            lista.AgregarNodo("uno");
lista.AgregarNodo("dos");
lista.AgregarNodo("tres");
            Console.ReadKey();


        }
    }
}
