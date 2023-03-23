using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Transmission : IBreakingRisk
    {
        public event Action BreakingRisk;

        internal virtual string Type { get; }

        public void TransmissionBreak()
            {
            Console.WriteLine("Transmission is broken");
        }

        public void Broke()
        {

        }
    }

}
