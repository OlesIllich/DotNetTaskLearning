﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Transmission
    {
        internal virtual string Type { get; }

        public void TransmissionBreak()
            {
            Console.WriteLine("Transmission is broken");
        }
    }

}
