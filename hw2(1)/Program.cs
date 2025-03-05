
using System;
public interface Iforshape
{
    double getValue();
    bool getCheck();
}
public class Rectangle : Iforshape
{
    public double w { get; set; }
    public double h { get; set; }
    public Rectangle(double w1, double h1)
    {
        w = w1;
        h = h1;
    }
    public bool getCheck()
    {
        if (w > 0 && h > 0)
        {
            return true;
        }
        else
            return false;
    }
    public double getValue()
    {
        return w * h;
    }
}
public class Circle : Iforshape
{
    public double r { get; set; }
    public Circle(double R)
    {
        r = R;
    }
    public bool getCheck()
    {
        if (r > 0)
        {
            return true;
        }
        else
            return false;
    }
    public double getValue()
    {
        return r * r * 3.1415926;
    }
}
public class Square : Iforshape
{
    public double w { get; set; }
    public bool getCheck()
    {
        if (w > 0)
        {
            return true;
        }
        else
            return false;
    }
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
        while (true)
        {
            Console.WriteLine("输入1求长方形");
            Console.WriteLine("输入2求圆形");
            Console.WriteLine("输入3求正方形");
            Console.WriteLine("输入4退出");
            string s = Console.ReadLine();
            int S = int.Parse(s);
            Iforshape shape = null;
            switch (S)
            {
                case 1:
                    {
                        Console.WriteLine("请输入长");
                        string w = Console.ReadLine();
                        double W = double.Parse(w);
                        Console.WriteLine("请输入宽");
                        string h = Console.ReadLine();
                        double H = double.Parse(h);
                        shape = new Rectangle(W, H);
                        if (shape.getCheck())
                        {   
                            Console.WriteLine("长方形的面积:" + shape.getValue());
                        }
                        else
                            Console.WriteLine("错误请重新输入");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("请输入半径");
                        string r = Console.ReadLine();
                        double R = double.Parse(r);
                        shape = new Circle(R);
                        if (shape.getCheck())
                        {
                            string c = shape.getValue().ToString("F2");
                            Console.WriteLine("圆的面积:" + c);
                        }
                        else
                            Console.WriteLine("错误请重新输入");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("请输入边长");
                        string r = Console.ReadLine();
                        double R = double.Parse(r);
                        shape = new Square(R);
                        if (shape.getCheck())
                        {   
                            Console.WriteLine("正方形:" + shape.getValue());
                        }
                        else
                            Console.WriteLine("错误请重新输入");
                    }
                    break;
                case 4:
                    Console.Write("Bye");
                    break;
                default:
                    Console.Write("请重新输入");
                    break;
            }
            if (S == 4)
                break;
        }
    }
}