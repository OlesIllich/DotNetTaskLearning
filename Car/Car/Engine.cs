using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal  class Engine
    {
        internal virtual string Size { get; }
        internal virtual void Starting()
        {
            Console.WriteLine("Let's go!!!");
        }
    }
}
