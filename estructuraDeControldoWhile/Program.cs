using System;

namespace estructuradecontroldoWhile // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizaremos el ciclo do-while, cuando queremos usar sentencias,
            //de dho(hacer) y el while(mientras)
            Console.WriteLine("Hello World!");
            Random numero = new Random();
            int aleatorio = numero.Next(0, 10);
            int elnumero;
            int intentos = 0;
            Console.WriteLine("Introduce un numero del 0 al 10");
            do
            {
                intentos++;
                elnumero = int.Parse(Console.ReadLine());
                if (elnumero > aleatorio)
                {
                    Console.WriteLine("El no° es más bajo");
                }
                if (elnumero < aleatorio)
                {
                    Console.WriteLine("El no° es más alto");
                }

            } 
                while (aleatorio != elnumero) ;
                Console.WriteLine($" Exito, Lograste empatar en el intento {intentos}");
     
        }
    }
}