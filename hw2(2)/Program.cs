using System;
public class Rectangle
{
    public double w { get; set; }
    public double h { get; set; }
    public Rectangle(double w1, double h1)
    {
        w = w1;
        h = h1;
    }
    public double getValue()
    {
        return w * h;
    }
}
public class Circle
{
    public double r { get; set; }
    public Circle(double R)
    {
        r = R;
    }
    public double getValue()
    {
        return r * r * 3.1415926;
    }
}
public class Square
{
    public double w { get; set; }
    public Square(double w1)
    {
        w = w1;
    }
    public double getValue()
    {
        return w * w;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("循环5次求随机创造10个形状对象的面积和");
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            double s = 0;
            for (int j = 0; j < 10; j++)
            {
                int r = random.Next(0, 3);
                switch (r)
                {
                    case 0:
                        {
                            double q = random.NextDouble() * 19 + 1;
                            double p = random.NextDouble() * 19 + 1;
                            Rectangle rectangle = new Rectangle(q, p);
                            s += rectangle.getValue();
                        }
                        break;
                    case 1:
                        {
                            double q = random.NextDouble() * 19 + 1;
                            Circle circle = new Circle(q);
                            s += circle.getValue();
                        }
                        break;
                    case 2:
                        {
                            double q = random.NextDouble() * 19 + 1;
                            Square square = new Square(q);
                            s += square.getValue();
                        }
                        break;
                }
            }
            string S = s.ToString("F2");
            Console.WriteLine("第" + (i+1)+" 次"+"面积:" + S);
        }
    }
}
