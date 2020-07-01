using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            for (int i=0;i<10;i++)
            {
                Console.WriteLine("num1 = {0} ,num2 = {1}",num1,num2);
                changeNum(ref num1,ref num2);
                Console.WriteLine("num1 = {0} ,num2 = {1}", num1, num2);
                num1++;
                num2++;
            }

            Console.WriteLine("Hello World!");
            Object obj = Console.ReadKey();
            Console.WriteLine(obj.ToString());
        }

        public static void changeNum(ref int x,ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
    }
}
