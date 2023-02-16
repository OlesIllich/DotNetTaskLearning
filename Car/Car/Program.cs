namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What body of your car do you want?");
            Console.WriteLine("1 - Hetchback");
            Console.WriteLine("2 - Sedan");
            Console.WriteLine("3 - Universl");
            Console.WriteLine("4 - Crossover");

            int variant5;
            bool success5 = int.TryParse(Console.ReadLine(), out variant5);
            while (!success5 | variant5 > 4 | variant5 < 1)
            {
                Console.WriteLine("It is uncorrect value");
                success5 = int.TryParse(Console.ReadLine(), out variant5);

            }

            Console.WriteLine("Choose brand of your car");
            Console.WriteLine("1 - Mersedes");
            Console.WriteLine("2 - BMW");
            Console.WriteLine("3 - Wolkswagen");
            Console.WriteLine("4 - Porsche");
            int variant;
            bool success = int.TryParse(Console.ReadLine(), out variant);
            while (!success | variant > 4 | variant<1) 
            {
                    Console.WriteLine("It is uncorrect value");
                    success = int.TryParse(Console.ReadLine(), out variant);
                
            }
                      

            Console.WriteLine("Choose model of your car");
            Console.WriteLine("1 - Classic");
            Console.WriteLine("2 - Sport");
            Console.WriteLine("3 - Offroad");
            int variant2;
            bool success2 = int.TryParse(Console.ReadLine(), out variant2);
            while (!success2 | variant2>3 | variant2<1)
            {
                Console.WriteLine("It is uncorrect value");
                success = int.TryParse(Console.ReadLine(), out variant2);
            }

           
            Console.WriteLine("Choose color of your car");
            Console.WriteLine("1 - White");
            Console.WriteLine("2 - Red");
            Console.WriteLine("3 - Green");
            Console.WriteLine("4 - Blue");
            Console.WriteLine("5 - Black");
            int variant3;
            bool success3 = int.TryParse(Console.ReadLine(), out variant3);
            while (!success3 | variant3>5 | variant3 <1)
            {
                Console.WriteLine("It is uncorrect value");
                success = int.TryParse(Console.ReadLine(), out variant3);
            }

            

            Console.WriteLine("Choose size of your engine");
            Console.WriteLine("1 - 1.0");
            Console.WriteLine("2 - 1.5");
            Console.WriteLine("3 - 2.0");
            int variant4;
            bool success4 = int.TryParse(Console.ReadLine(), out variant4);
            while (!success4 | variant4 >3 | variant4<1)
            {
                Console.WriteLine("It is uncorrect value");
                success = int.TryParse(Console.ReadLine(), out variant4);
            }

            Engine engine = new Engine();
            switch (variant4)
            {
                case 1:
                    var engine1 = new EngineSmall();
                    engine = engine1;
                    break;
                case 2:
                    var engine2 = new EngineStandart();
                    engine = engine2;
                    break;
                case 3:
                    var engine3 = new EngineBig();
                    engine = engine3;
                    break;
                default:
                    Console.WriteLine($"I cant understend you)");
                    break;
            }

            Console.WriteLine("Choose transmission");
            Console.WriteLine("1 - mechanic");
            Console.WriteLine("2 - automat");
            int variant6;
            bool success6 = int.TryParse(Console.ReadLine(), out variant6);
            while (!success6 | variant4 > 2 | variant4 < 1)
            {
                Console.WriteLine("It is uncorrect value");
                success = int.TryParse(Console.ReadLine(), out variant6);
            }

            var transmission = new Transmission();
            switch (variant6)
            {
                case 1:
                    var transmissionM = new TransmissionHandle();
                    transmission = transmissionM;
                    break;
                case 2:
                    var transmissionA = new TransmissionAutomat();
                    transmission = transmissionA;
                    break;
                default:
                    Console.WriteLine($"I cant understend you)");
                    break;
            }


            var ownCar = new BasicCar(transmission, (Body)variant5-1, engine, (Mark)variant-1, (Model)variant2 - 1, (Color)variant3 - 1);
            Console.WriteLine(ownCar);

            //Console.WriteLine();
            //ownCar.WriteToFileAndConsole();
            ownCar.StartEngine(engine);

            Console.WriteLine("\n***** Speeding up *****");

            engine.BreakingRisk += () => Console.WriteLine("We can break your car");
            engine.BreakingCarComplited += ownCar.Overheet;

            ownCar.StartEngine(engine);
            //engine.Broke();


        }
    }
}
