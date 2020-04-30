using System;
using System.Collections.Generic;
using System.Text;

namespace Matrices
{
    class Matriz
    {
        private int[][] A, B, C;


        public void SetFilas(int filas)
        {
            A = new int[filas][];
            B = new int[filas][];
            C = new int[filas][];
        }

        public void SetColumnas(int columnas)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = new int[columnas];
                B[i] = new int[columnas];
                C[i] = new int[columnas];
            }
        }

        public void SetMatriz()
        {
            Console.WriteLine("Ingresa los valores para la matriz A");
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[0].Length; j++)
                {
                    Console.WriteLine($"Posición { i + 1 } { j + 1 } ");
                    A[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ingresa los valores para la matriz B");
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[0].Length; j++)
                {
                    Console.WriteLine($"Posición { i + 1 } { j + 1 } ");
                    B[i][j] = int.Parse(Console.ReadLine());
                }
            }

        }

        public void SumaMatriz()
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[0].Length; j++)
                {
                    C[i][j] = A[i][j] + B[i][j];
                }
            }
        }


        public void VerMatriz()
        {
            Console.Clear();
            Console.WriteLine("El resultado de la matriz es:");
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < C[0].Length; j++)
                {
                    Console.Write(C[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
