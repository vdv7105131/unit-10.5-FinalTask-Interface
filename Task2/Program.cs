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
            var woreker2 = new Worker2(Logger);
            var woreker3 = new Worker3(Logger);

            woreker1.Work();
            woreker2.Work();
            woreker3.Work();

            Console.ReadKey();
        }
    }
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Logger : ILogger
    {
        void ILogger.Error(string message)
        {
            Console.WriteLine(message);
        }

        void ILogger.Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
    }

    public interface IWorker
    {
        void Work();
    }
}
