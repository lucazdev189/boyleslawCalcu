using System;

Console.WriteLine("Boyle's Law Calculator");
Console.WriteLine("by lucazdev189");
Console.WriteLine("Pick: (1)P1 (2)V1 (3)P2 (4)V2");
int choice = Convert.ToInt32(Console.ReadLine());
double fa;
double ffa;

switch (choice)
{
    case 1:
        Console.WriteLine("Enter V1");
        double v1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter V2");
        double v2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter P2");
        double p2 = Convert.ToDouble(Console.ReadLine());

        fa = (p2 * v2) / v1;
        ffa = Math.Round(fa, 2);
        Console.WriteLine("P1 = "+fa+" atm");
        break;
    case 2:
        Console.WriteLine("Enter P1");
        double p1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter V2");
        double v2two = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter P2");
        double p2two = Convert.ToDouble(Console.ReadLine());

        fa = (p2two * v2two) / p1;
        ffa = Math.Round(fa, 2);
        Console.WriteLine("V1 = "+ffa+" L");
        break;

    case 3:
        Console.WriteLine("Enter P1");
        double p1three = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter V1");
        double v1three = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter V2");
        double v2three = Convert.ToDouble(Console.ReadLine());

        fa = (p1three * v1three) / v2three;
        ffa = Math.Round(fa, 2);
        Console.WriteLine("P2 = "+ffa+" atm");
        break;

    case 4:
        Console.WriteLine("Enter P1");
        double p1four = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter V1");
        double v1four = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter P2");
        double p2four = Convert.ToDouble(Console.ReadLine());

        fa = (p1four * v1four) / p2four;
        ffa = Math.Round(fa, 2);
        Console.WriteLine("V2 = "+ffa+" L");
        break;

    default:
        Console.WriteLine("Error");
        break;
}