using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class EngineStandart : Engine
    {
        internal override string Size { get { return "1.5"; } }
        internal override void Starting() 
        {
            base.Starting();
            Console.WriteLine("tru-tu-tu-tu");
        }
    }
}
