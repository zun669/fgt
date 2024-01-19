using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = rand.Next(1, 24);           
            int count = 1;
            int Score = 0;
            Console.WriteLine("Компьютер загадал три чесла, попробуй отгадать, у Вас три попытки");
            Console.WriteLine("Введите число:");
            int k = Convert.ToInt32(Console.ReadLine());

            while (count <=3)
            
            {
                if ( a == k)
                {
                    Score++;
                    Console.WriteLine("Верно! Счётчик баллов: " + Score + "");
                    
                        break;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("Попытки закончились");
                        break;
                    }
                    Console.WriteLine("Нет, это не " + k + ", это " + a + "!Попытка № " + count + ":");
                    k = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();

        }
    }
}
