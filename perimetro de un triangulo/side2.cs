using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimetro_de_un_triangulo
{
    internal class side2: side1
    {
        protected double two_side;

        public double S2
        {
            get { return two_side; }
            set { two_side = value; }
        }

        //constructors
        public side2() : base()
        {
            two_side = 0;
        }

        public side2(double two_side, double one_side) : base(one_side)
        {
            this.two_side = two_side;
        }

        public override string ToString()
        {
            return  "" + base.ToString() + "" + "," + two_side;
        }
        public double Getperimeter(side2 s)
        {
            return s.two_side + s.one_side;
        }
        public static void PrintMessage()
        {
            Console.WriteLine("this is the perimeter of the square ");
        }

        ~side2()
        {
            Console.WriteLine("Destructor de side1 llamado.");
            Console.ReadKey();
        }
    }
}
