using System;

namespace _2
{
    class Program
    {
        static void Main()
        {
            int up;//上限
            int down;//下限
            Console.WriteLine("请输入上限");
            up = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入下限");
            down = int.Parse(Console.ReadLine());
            int count = 0;//判断是否等于0个数
            for (int i=down; i <= up; i++) {
                int p = -1;//判断是否为素数
                for (int j = 2; j < i; j++) {
                    if (i % j == 0)//不是素数则跳出循环
                    {
                        p = 0;
                        break;
                    }
                }
                if (p != 0) {
                    Console.Write(i+" ");
                    count++;

                }
                if (count == 10)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
        }
    }
}
