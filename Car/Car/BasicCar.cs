using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Car
{


    internal class BasicCar
    {

        
        private string _transmission;
        private string _engineSize;

        public Mark Mark { get; set; }
        public Model Model { get; set; }
        public Color Color { get; set; }
        public Body Body { get; set; }

        public BasicCar(Transmission transmission, Body body, Engine engine, Mark variant, Model model, Color color) 
        {
            Body = body;
            Mark = variant;
            Model = model;
            Color = color;
            _transmission = transmission.Type;
            _engineSize = engine.Size;

            engine.BreakingRisk  += () => Console.WriteLine("We can break your car") ;
            transmission.BreakingRisk += Overheet;
        }

      

        public void StartEngine(Engine engine)
        {
            engine.Starting();
            engine.AccelerateEngine();
        }

        public void WriteToFileAndConsole()
        {
            Console.WriteLine($"Your car is {Body} {Color} {Mark} {Model} {_engineSize} {_transmission}");
            StreamWriter sw = new StreamWriter("C:\\Users\\zsirc\\OneDrive\\Documents\\GitHub\\DotNetTaskLearning\\Test.txt");
            sw.WriteLine($"Your car is {Body} {Color} {Mark} {Model} {_engineSize} {_transmission}");
            sw.Close();
         }

        public override string ToString()
        {
            return "car: " + " " + _transmission + " " + _engineSize + " " + Body + " " + Mark + " " + Model + " " + Color;
        }

        public void Overheet() => Console.WriteLine("Your engine was broken!");



    }
}
