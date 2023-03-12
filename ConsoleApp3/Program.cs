/* Завдання 2:
Додаток має відображати усі прості числа від 0 до 1000. Для
відображення чисел використовуйте клас «Task». Основний потік
має очікувати завершення завдання */
using System;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Task task = Task.Run(() =>
            {
                for (int i = 2; i <= 1000; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine(i);
                    }
                }
            });

            // Очікуємо завершення задачі
            task.Wait();

            Console.WriteLine("Усі прості числа від 0 до 1000 відображено.");
            Console.ReadKey();
        }
    }
}
