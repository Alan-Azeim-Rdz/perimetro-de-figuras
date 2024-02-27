using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimetro_de_un_triangulo
{
    internal class side1
    {
        protected double one_side;

        public double S1
        {
            get { return one_side; } 
            set { one_side = value; }
        }

        //constructors
        public side1()
        {
            one_side = 0;
        }

        public side1(double one_side)
        {
            this.one_side = one_side;
        }

        public override string ToString()
        {
            return "" + one_side;
        }
        public double Getperimeter(side1 s, side1 sid)
        {
            return one_side + s.one_side + sid.one_side;
        }
        public static void PrintMessage()
        {
            Console.WriteLine("this is the perimeter of the triangle  ");
        }

        // Destructor (finalizador)
        ~side1()
        {
            Console.WriteLine("Destructor de side1 llamado.");
            Console.ReadKey();
        }
    }
}
