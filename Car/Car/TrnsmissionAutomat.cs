using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class TransmissionAutomat : Transmission
    {
        internal override string Type { get { return "ACPP"; } }
    }
}
