using System;
using System.Diagnostics;

namespace Problema1
{
    class Program
    {
        public static int _input = 0;
        public static int _terms = 0;

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 1000000; i++)
                Process(i);

            Console.WriteLine($"el input: { _input} tiene: {_terms} terminos");

            Console.WriteLine($"Memoria: { GC.GetTotalMemory(true)}");

            sw.Stop();
            Console.WriteLine("Tiempo de ejecucion: {0}", sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff")); 
        }


        private static void Process(int input)
        {
            var contador = 0;
            var inputAUX = input;

            while (input > 1)
            {
                if (input % 2 == 0)
                    input = input /= 2;
                else
                    input = 3 * input + 1;

                contador++;
            }

            if (contador > _terms)
            {
                _terms = contador++;
                _input = inputAUX;

            }
        }

    }
}
