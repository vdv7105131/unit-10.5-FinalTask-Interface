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
            Logger.Event("Worker1 начал свою работу");
            Thread.Sleep(500);
            Logger.Event("Worker1 окончил свою работу");
            Thread.Sleep(500);
        }
    }
    public class Worker2 : IWorker
    {
        ILogger Logger { get; }
        public Worker2(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker2 начал свою работу");
            Thread.Sleep(500);
            Logger.Event("Worker2 окончил свою работу");
            Thread.Sleep(500);
        }
    }

    public class Worker3 : IWorker
    {
        ILogger Logger { get; }
        public Worker3(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker3 начал свою работу");
            Thread.Sleep(500);
            Logger.Event("Worker3 окончил свою работу");
            Thread.Sleep(500);
        }
    }
}
