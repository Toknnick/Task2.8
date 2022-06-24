using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "12345";
            int tryCount = 3;

            for (int i = 0; i <= tryCount; tryCount--)
            {
                Console.WriteLine("Введите пароль");
                string inputWordByUser = Console.ReadLine();

                if(inputWordByUser == password)
                {
                    Console.WriteLine("Секретная фраза");
                    break;
                }
                else
                {
                    Console.WriteLine($"Неверно! У Вас осталось {tryCount} попыток");
                }
            }
        }
    }
}
