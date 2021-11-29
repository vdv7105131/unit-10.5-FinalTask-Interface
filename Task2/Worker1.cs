using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    public class Worker1 : IWorker
    {
        ILogger Logger { get; }
        public Worker1(ILogger logger)
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
}
