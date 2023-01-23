namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Historic Car Calculator");
            Console.WriteLine("Please enter the brand of your car");
            var make = Console.ReadLine();

            Console.WriteLine("Please enter the model of your car.");
            var model = Console.ReadLine();

            Console.WriteLine("Please enter the year your car was made.");
            int year = Convert.ToInt32(Console.ReadLine());

            var car = new Car(make, model, year);

            Console.WriteLine(car.ToString());
        }
    }
}