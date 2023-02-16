using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal  class Engine
    {
        Action BreakingCar;
        public event Action BreakingCarComplited;
        public event Action BreakingRisk;

        
        internal virtual string Size { get; }
        internal virtual void Starting() => Console.WriteLine("Let's go!!!");


        public void Broke()
        {
            BreakingCarComplited?.Invoke();
        }

        public void AccelerateEngine()
        {
            for (int i = 0; i < 8000; i += 1000)
            {
                if (i == 6000)
                {
                    BreakingRisk?.Invoke();
                }

                if (i >= 6500)
                {
                    BreakingCarComplited?.Invoke();
                    break;
                }
                Console.WriteLine($"Our engine rotates {i} per minute");

            }
        }

    }

}
