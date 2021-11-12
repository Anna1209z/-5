using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть довжину сторони квадрата:");
            Square sqr = new Square();
            sqr.A1 = Convert.ToInt32(Console.ReadLine());
            sqr.Draw();
            Console.ReadKey();
        }
    }
    class Square
    {
        private int a1;
        public int A1
        {
            get
            {
                return a1;
            }
            set
            {
                a1 = value;
            }
        }
        public void Draw()
        {
            if (a1>0)
            {
                var str = new String('#', a1);
                Console.WriteLine(str);
                int i = 0;
                while (i != a1 - 2)
                {
                    Console.WriteLine("#" + new string(' ', a1 - 2) + "#");
                    i++;
                }
                Console.WriteLine(str);
               
            }
            else
            {
                Console.WriteLine("Введенно невірне значення");
            }
        }
    }
}
