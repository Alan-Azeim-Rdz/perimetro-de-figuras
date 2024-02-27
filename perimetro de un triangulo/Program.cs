using perimetro_de_un_triangulo;

Console.WriteLine("What figure do you want?  (1) tringule   (2) square   (3) hexagon  (4) exit");
int r = int.Parse(Console.ReadLine());

while (r != 4)
{


    //triangule
    side1 s1 = new side1(4);

    //square
    side2 s2 = new side2(7, 5);

    //hexagon
    side3 s3 = new side3(4, 4, 4);
    side3 s4 = new side3(4, 4, 4);


    if (r == 1)
    {
        side1.PrintMessage();
        Console.WriteLine(s1.Getperimeter(s1, s1));
        Console.ReadLine();
        Console.Clear();

    }
    else if (r == 2)
    {
        side2.PrintMessage();
        Console.WriteLine(s2.Getperimeter(s2));
        Console.ReadLine();
        Console.Clear();
    }
    else if (r == 3)
    {
        side3.PrintMessage();
        Console.WriteLine(s3.Getperimeter(s4));
        Console.ReadLine();
        Console.Clear();
    }

    Console.WriteLine("What figure do you want?  (1) tringule   (2) square   (3) hexagon  (4) exit");
    r = int.Parse(Console.ReadLine());
    
}



