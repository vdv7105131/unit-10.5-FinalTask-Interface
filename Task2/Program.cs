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

            woreker1.Work();

            Console.ReadKey();
        }
    }
    public interface ILogger
    {
        int Event(out int num);
        void Error();
    }

    public class Logger : ILogger
    {
        void ILogger.Error()
        {

        }

        int ILogger.Event(out int num)
        {
            var isNumber = int.TryParse(Console.ReadLine(), out num);
            if (isNumber == false)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Введите число повторно:");
                var isNumber1 = int.TryParse(Console.ReadLine(), out num);
                while (isNumber1 == false)
                {
                    Console.WriteLine("Введите число повторно:");
                    isNumber1 = int.TryParse(Console.ReadLine(), out num);
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            return num;
        }
    }

    public interface IWorker
    {
        void Work();
    }
}
