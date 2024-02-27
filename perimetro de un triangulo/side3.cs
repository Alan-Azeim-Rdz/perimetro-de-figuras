using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimetro_de_un_triangulo
{
    internal class side3: side2
    {
        private double three_side;

        public double S3
        {
            get { return three_side; }
            set { three_side = value; }
        }

        //constructors
        public side3() : base()
        {
            three_side = 0;
        }

        public side3(double three_side, double two_side, double one_side) : base(two_side,  one_side)
        {
            this.three_side = three_side;
        }

        public override string ToString()
        {
            return  "" + base.ToString() + " ," + three_side;
        }
        public double Getperimeter(side3 side)
        {
            return S1 + S2 + three_side + side.three_side +side.one_side + side.two_side;
        }
        public static void PrintMessage()
        {
            Console.WriteLine("this is the perimeter of the hexagon ");
        }
        ~side3()
        {
            Console.WriteLine("Destructor de side1 llamado.");
            Console.ReadKey();
        }

    }
}
