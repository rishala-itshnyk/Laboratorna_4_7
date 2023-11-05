using System;

class Program
{
    static void Main()
    {
        double xp, xk, x, dx, eps, a = 0, R = 0, S = 0;
        int n = 0;

        Console.Write("xp = ");
        xp = Convert.ToDouble(Console.ReadLine());

        Console.Write("xk = ");
        xk = Convert.ToDouble(Console.ReadLine());

        Console.Write("dx = ");
        dx = Convert.ToDouble(Console.ReadLine());

        Console.Write("eps = ");
        eps = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("|" + " x " + "|" + " log((1.0 + x)/(1.0-x)) " + "|" + " S " + "|" + " n " + "|");
        Console.WriteLine("-------------------------------------------------");

        x = xp;
        while (x <= xk)
        {
            n = 0;
            a = 2.0 * x;
            S = a;

            do
            {
                n++;
                R = 2.0 * ((x * x) * ((2.0 * n - 1.0) / (2.0 * n + 1.0))); 
                a *= R;
                S += a;
            } while (Math.Abs(a) >= eps);

            Console.WriteLine("|" + x.ToString("F2") + " |" + Math.Log((1.0 + x) / (1.0 - x)).ToString("F5") + " |" + S.ToString("F5") + " |" + n + " |");

            x += dx;
        }

        Console.WriteLine("-------------------------------------------------");
    }
}