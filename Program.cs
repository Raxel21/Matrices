using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas, columnas;

            Matriz A = new Matriz();

            Console.WriteLine("Ingresa el número de filas");

            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el número de columnas");

            columnas = int.Parse(Console.ReadLine());

            A.SetFilas(filas);
            A.SetColumnas(columnas);
            A.SetMatriz();
            A.SumaMatriz();
            A.VerMatriz();
        }
    }
}
