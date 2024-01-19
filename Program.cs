using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = rand.Next(1, 24);
            int b = rand.Next(1, 24);
            int c = rand.Next(1, 24);
            int count = 1;
            int Score = 0;
            Console.WriteLine("Компьютер загадал три числа, попробуйте отгадать их");
            Console.WriteLine("Введите число:");
            int k = Convert.ToInt32(Console.ReadLine());




            while (count <= 3)
            {
                if (a == k || b == k || c == k)
                {
                    count = 1;
                    Score++;
                    Console.WriteLine("Верно! Счётчик баллов: " + Score + "");
                    Console.WriteLine("Компьютер снова загадал три чесла, попробуй отгадать, у Вас три попытки");
                    Console.WriteLine("Введите число:");
                    a = rand.Next(1, 24);
                    b = rand.Next(1, 24);
                    c = rand.Next(1, 24);
                    k = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                    
                        Console.WriteLine("Попытки закончились, Ваш счёт "+Score+ "");
                        break;                      
                    }  
                    
                    Console.WriteLine("Нет, это не " + k + ",  это были числа: " + a + ", " + b + ", " + c + " Попытка № " + count + ":");
                    k = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
            

        }
    }
}
