using System;

namespace Task2
{
    /// Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
    /// Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var woreker1 = new Class1(Logger);

            woreker1.Work();

            Console.ReadKey();
        }
    }
}
