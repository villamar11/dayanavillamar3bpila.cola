using PilA.ColA.tads.pc;
using System;

namespace PilA.ColA
{
    class Program
    {
        static void Main(string[] args)
        {
            pila r = new pila();
            

            r.Anadir(5);
            r.Anadir(10);
            r.Anadir(3);
            r.Anadir(8);
            r.EliminarData();
            r.Anadir(4);

            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(r.DATA[i]);

            }
            cola c = new cola();
            c.Anadirdato(6);
            c.Anadirdato(9);
            c.Anadirdato(4);
            c.Anadirdato(12);
            c.ELIMINARDATO();
            c.Anadirdato(65);
            Console.WriteLine("\ncola");
            for (int i = c.ULTIMO; i > c.PRIMERO; i--)
            {
                Console.WriteLine(c.DATO[i]);

            }
            Console.ReadKey();

        }
    }
}
