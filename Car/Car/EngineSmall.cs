using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class EngineSmall : Engine
    {
        internal override string Size { get { return "1.0"; } }
        internal override void Starting()
        {
            base.Starting();
            Console.WriteLine("driiiiiiiin");
        }
    }
}
