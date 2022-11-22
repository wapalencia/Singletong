using System;
using System.Reflection;
using System.Threading;

namespace SingletonMutex
{
    class Program
    {
        //public int tiket[];
        static void Main()
        {

            var appName = Assembly.GetEntryAssembly().GetName().Name;
            var notAlreadyRunning = true;

            using (var mutex = new Mutex(true, appName + "Singleton", out notAlreadyRunning))
            {

                if (notAlreadyRunning)
                {
                    // do work here:

                    // var tiket[] = new tiket[5];

                    Console.WriteLine("\n BOLETO GANADOR...");
                    int[] arreglo = { 28, 11, 96, 21, 6, 45 };

                    for (int indice = 0; indice < arreglo.Length; indice++)
                    {
                        var elemento = 0;
                        Console.Write("[");
                        elemento = arreglo[indice];

                        // tiket[indice] = elemento;

                        Console.Write(elemento);
                        // Imprimir también una coma
                        Console.Write("], ");

                    }


                    Console.WriteLine("\n Running. Press any key to exit...");
                    Console.Write(appName);
                    Console.ReadKey();

                }
                else
                    Console.Error.WriteLine(appName + " is already running.");
                Console.WriteLine("\n BOLETO GANADOR...");
                //Console.WriteLine(tiket[]);
                Console.WriteLine("\n PRECIONE UNA TECLA Y PRUEBE SU SUERTE...");
                Console.ReadKey();
                int[] arreglo2 = { 0, 0, 0, 0, 0, 0 };
                Random rnd = new Random();
                for (int indice = 0; indice < arreglo2.Length; indice++)
                {
                    Console.Write("[");
                    int elemento = rnd.Next(0, 45);
                    Console.Write(elemento);
                    Console.Write("], ");
                    //Console.WriteLine(rnd.Next(0, 45)); // returns random integers >= 10 and < 19
                }

                Console.ReadKey();
            }
        }
    }
}
