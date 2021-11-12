using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace лб5
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            Console.WriteLine($"Матриця:");
            matrix.Start();
            Console.WriteLine("Одинична матриця:");
            IdentityMatrix matrix1 = new IdentityMatrix();
            matrix1.Next1();
            Console.WriteLine("Вверхня трикутна матриця");
            UpperTriangularMatrix matrix2 = new UpperTriangularMatrix();
            matrix2.Finall();
            Console.ReadKey();
          
        }
    }
    class Matrix
    {
        public void Start()
        {
            int[,] array = new int[4, 4];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(100);
                }
            }
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    Console.Write(array[x, y] + "\t");
                }
                Console.WriteLine();
            }

        }
        
         
    }
    class IdentityMatrix
    {
        public void Next1()
        {

            int[,] array1 = new int[4, 4];

            for (int y = 0; y < array1.GetLength(0); y++)
            {
                for (int x = 0; x < array1.GetLength(1); x++)
                {
                    if (y == x)
                    {
                        array1[x, y] = 1;
                    }
                    else
                    {
                        array1[x, y] = 0;
                    }
                }
            }
            for (int y = 0; y < array1.GetLength(0); y++)
            {
                for (int x = 0; x < array1.GetLength(1); x++)
                {
                    Console.Write(array1[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
    class UpperTriangularMatrix
    {
        public void Finall()
        {

            int[,] array2 = new int[4, 4];
            Random random = new Random();

            for (int y = 0; y < array2.GetLength(0); y++)
            {
                for (int x = 0; x < array2.GetLength(1); x++)
                {
                    if (y <=x)
                    {
                        array2[x, y] = random.Next(100);
                    } 
                    else
                    {
                        array2[x, y] = 0;
                    }
                }
            }
            for (int y = 0; y < array2.GetLength(0); y++)
            {
                for (int x = 0; x < array2.GetLength(1); x++)
                {
                    Console.Write(array2[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

