using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface ILogger
    {
        int Event(out int num);
        void Error();
    }

    public interface IWorker
    {
        void Work();
    }
}
