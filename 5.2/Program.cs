using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введiть значення радiуса основи конуса:");
            int R1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введiть значення висоти конуса:");
            int H1 = Convert.ToInt32(Console.ReadLine());
            Cone inf = new Cone(R1,H1);
            Console.WriteLine($"Площа основи конуса:{inf.Square()}");
            Console.WriteLine($"Об'єм конуса:{inf.Size()}");

            
            int R2= Convert.ToInt32(Console.ReadLine());
            ZrCone zr = new ZrCone(R1,H1,R2);
            Console.WriteLine($"Об'єм зрізаного конуса:{zr.Size1()}");
            Console.ReadKey();
        }
    }
    class Cone
    {
        
        public int R1
        {
            get;set;
            
        }
        public int H1
        {
            get; set;
        }
        public double Square()
        {
            double s = (R1*R1) * Math.PI;
            return s;
            
        }
       public double Size()
        {
            double v = (Math.PI * H1 * (R1 * R1)) / 3;
            return v;
        }
        public Cone(int r1, int h1)
        {
            this.H1 = h1;
            this.R1 = r1;
        }
        
    }
    class ZrCone : Cone
    {
       
        public int R2
        {
            get; set;
        }
        public ZrCone(int r1, int h1,int r2) : base(r1,h1)
        {
            
            this.R2 = r2;

        }
        
        public double Size1()
        {
            double v1 = Math.PI * H1 * ((R1 * R1) + (R2 * R2) + (R2 * R1)) / 3;
            return v1;
        }

    }

}
