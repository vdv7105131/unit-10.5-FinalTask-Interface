using System;

namespace Task2
{
    // Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
    // Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var woreker1 = new Worker1(Logger);

            woreker1.Work(out int num1, out int num2);

            Console.ReadKey();
        }
    }
    public interface ILogger
    {
        int Event(out int num);
        int Error(bool input);
    }

    public class Logger : ILogger
    {
        int ILogger.Error(bool input)
        {
            int num1; 
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите число повторно:");
            var isNumber1 = int.TryParse(Console.ReadLine(), out num1);
            while (isNumber1 == false)
            {
                Console.WriteLine("Введите число повторно:");
                isNumber1 = int.TryParse(Console.ReadLine(), out num1);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            return num1;
        }

        int ILogger.Event(out int num)
        {
            var isNumber = int.TryParse(Console.ReadLine(), out num);
            return num;
        }
    }

    public interface IWorker
    {
        void Work();
    }
}
