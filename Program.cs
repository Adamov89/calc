using System;



namespace Calc_2
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Кулькулятор");
            while (true)
            {
                double a, b, c; char h; c = 0.0;
                Console.WriteLine("ввести первое число"); a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ввести оператор (+) (-) (*) (/) "); h = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("ввести второе число"); b = Convert.ToDouble(Console.ReadLine());
                switch (h)
                {
                    case '+':
                        c = a + b;
                        break;
                    case '-':
                        c = a - b;
                        break;
                    case '/':
                        c = a / b;
                        break;
                    case '*':
                        c = a * b;
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("= " + c);
                Console.WriteLine("Начать заново? (y/n)");
                ConsoleKeyInfo e = Console.ReadKey();
                if (e.KeyChar == 'n') break;
                Console.WriteLine();

            }

        }
    }
}
        
    

