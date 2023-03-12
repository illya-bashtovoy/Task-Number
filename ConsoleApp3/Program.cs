/* Завдання 3:
Модифікуйте завдання 2. Необхідно передати завданню межі для
генерації простих чисел. Основний потік має очікувати на
завершення завдання. Після завершення завдання основний
потік виводить кількість простих чисел. */
using System;
using System.Threading.Tasks;

namespace TaskExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Визначаємо межі для генерації простих чисел
            int start = 2;
            int end = 1000;

            // Створюємо задачу, яка буде рахувати прості числа
            Task<int> task = new Task<int>(() => {
                int count = 0;
                for (int i = start; i <= end; i++)
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
                        count++;
                    }
                }
                return count;
            });

            // Запускаємо задачу
            task.Start();

            // Очікуємо завершення задачі та отримуємо результат
            int result = task.Result;

            Console.WriteLine("Знайдено {0} простих чисел від {1} до {2}.", result, start, end);
        }
    }
}
