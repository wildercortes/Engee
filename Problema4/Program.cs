using System;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            var matriz = GetMatriz();

            Console.WriteLine($"Mi matriz:");

            PrintMatriz(matriz);

            var subMatrix = ExtractSubMatriz(matriz, 4, 4);

            Console.WriteLine($"Mi Submatriz:");

            PrintMatriz(subMatrix);

            Console.WriteLine($"Output solicitado:");

            SpiralPrint(4, 4, subMatrix);

            Console.WriteLine();

        }

        private static int[][] GetMatriz()
        {
            return new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{5,6,7,8},
                new int[]{7,3,5,1},
                new int[]{9,8,3,4},
                new int[]{1,1,8,3},
            };
        }

        private static void SpiralPrint(int filas, int columnas, int[][] matriz)
        {
            int i, filaInicial = 0, columnaInicial = 0;

            while (filaInicial < filas && columnaInicial < columnas)
            {
                /* Print the first row from the remaining rows */
                for (i = columnaInicial; i < columnas; ++i)
                    Console.Write(matriz[filaInicial][i]);

                filaInicial++;

                /* Print the last column from the remaining columns */
                for (i = filaInicial; i < filas; ++i)
                    Console.Write(matriz[i][columnas - 1]);

                columnas--;

                /* Print the last row from the remaining rows */
                if (filaInicial < filas)
                {
                    for (i = columnas - 1; i >= columnaInicial; --i)
                        Console.Write(matriz[filas - 1][i]);
                    filas--;
                }

                /* Print the first column from the remaining columns */
                if (columnaInicial < columnas)
                {
                    for (i = filas - 1; i >= filaInicial; --i)
                        Console.Write(matriz[i][columnaInicial]);

                    columnaInicial++;
                }
            }
        }

        private static int[][] ExtractSubMatriz(int[][] matrix, int filas, int columnas)
        {
            var result = new int[filas][];

            for (int i = 0; i < filas; i++)
            {
                result[i] = new int[columnas];

                for (int j = 0; j < columnas; j++)
                    result[i][j] = matrix[i][j];

            }
            return result;
        }

        private static void PrintMatriz(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                foreach (var col in row)
                    Console.Write($"{col} ");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
