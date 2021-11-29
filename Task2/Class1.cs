using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    public class Class1 : IWorker
    {
        ILogger Logger { get; }
        public Class1(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Console.WriteLine("Введите первое число:");
            var isNumber1 = Logger.Event(out int num);

            Console.WriteLine("Введите второе число:");
            var isNumber2 = Logger.Event(out int num1);

            var sum = isNumber1 + isNumber2;

            Console.WriteLine("Сумма двух чисел равна: " + sum);
        }
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

}
