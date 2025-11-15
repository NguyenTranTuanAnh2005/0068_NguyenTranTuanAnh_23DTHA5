using System;
using System.Text;

public class PhuongTrinhBacNhat
{
    protected double A { get; set; }
    protected double B { get; set; }

    public PhuongTrinhBacNhat(double a, double b)
    {
        A = a;
        B = b;
    }

    public virtual string Giai()
    {
        if (A == 0)
        {
            if (B == 0)
            {
                return "Phương trình có vô số nghiệm.";
            }
            else
            {
                return "Phương trình vô nghiệm.";
            }
        }
        else
        {
            double x = -B / A;
            return $"Phương trình có một nghiệm duy nhất: x = {x}";
        }
    }
}

public class PhuongTrinhBacHai : PhuongTrinhBacNhat
{
    protected double C { get; set; }

    public PhuongTrinhBacHai(double a, double b, double c) : base(a, b)
    {
        C = c;
    }

    public override string Giai()
    {
        if (A == 0)
        {
            PhuongTrinhBacNhat ptbn = new PhuongTrinhBacNhat(B, C);
            return $"Khi A=0, đây là phương trình bậc nhất: {B}x + {C} = 0\n" + ptbn.Giai();
        }

        else
        {
            double delta = B * B - 4 * A * C;

            if (delta < 0)
            {
                return $"Delta = {delta}. Phương trình vô nghiệm thực.";
            }

            else if (delta == 0)
            {
                double x = -B / (2 * A);
                return $"Delta = 0. Phương trình có nghiệm kép: x1 = x2 = {x}";
            }

            else
            {
                double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
                return $"Delta = {delta}. Phương trình có hai nghiệm phân biệt:\nx1 = {x1}\nx2 = {x2}";
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("--- PT: x^2 - 5x + 6 = 0 ---");
        PhuongTrinhBacHai pt1 = new PhuongTrinhBacHai(1, -5, 6);
        Console.WriteLine(pt1.Giai());

        Console.WriteLine("\n--- PT: 0x^2 + 3x + 5 = 0 (Bậc nhất) ---");
        PhuongTrinhBacHai pt4 = new PhuongTrinhBacHai(0, 3, 5);
        Console.WriteLine(pt4.Giai());

        Console.WriteLine("\n--- PT: 2x - 8 = 0 (Bậc nhất trực tiếp) ---");
        PhuongTrinhBacNhat pt6 = new PhuongTrinhBacNhat(2, -8);
        Console.WriteLine(pt6.Giai());
    }
}