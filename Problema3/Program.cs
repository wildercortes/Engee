using System;
using System.Diagnostics;
using System.Threading;

namespace Problema3
{
    class Program
    {
        public static int _terminos = 0;

        static void Main(string[] args)
        {

            Thread t1 = new Thread(() => Proceso(0, 500000));
            Thread t2 = new Thread(() => Proceso(500000, 1000000));

            t1.Name = "hilo 1";
            t2.Name = "hilo 2";

            t1.Start();
            t2.Start();
        }


        private static void Proceso(int inicio, int fin)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            var input = 0;
            var terminos = 0;

            for (int i = inicio; i < fin; i++)
            {
                var itemp = i;

                var contador = 0;
                while (itemp > 1)
                {
                    if (itemp % 2 == 0)
                        itemp = itemp /= 2;
                    else
                        itemp = 3 * itemp + 1;

                    contador++;
                }

                if (contador > terminos)
                {
                    terminos = contador++;
                    input = i;
                }
            }
      
            sw.Stop();
            Console.WriteLine("Tiempo de ejecucion: {0}  {1}", sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff"), Thread.CurrentThread.Name); // Mostrar el tiempo transcurriodo con un formato hh:mm:ss.000           
            Console.WriteLine($"Memoria: { GC.GetTotalMemory(true)}  {Thread.CurrentThread.Name} ");
            Console.WriteLine($"el input: { input} tiene: {terminos} terminos  {Thread.CurrentThread.Name}");
        }
    }


}



