using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class EngineBig : Engine
    {
        internal override string Size { get { return "2.0"; } }
        internal override void Starting()
        {
            base.Starting();
            Console.WriteLine("druun-dun-dun");
        }
    }
}
