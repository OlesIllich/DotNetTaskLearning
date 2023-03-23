namespace greedyAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            {"mt", "wa", "or", "id", "nv", "ut", "ca", "az"};

            Dictionary<string, List<string>> stations = new Dictionary<string, List<string>>


            {
                ["kone"] = new List<string> { "id", "nv", "ut" },
                ["ktwe"] = new List<string> { "wa", "id", "mt", "az" },
                ["kthree"] = new List<string> { "or", "nv", "ca" },
                ["kthree"] = new List<string> { "nv", "ut" },
                ["kfour"] = new List<string> { "ca", "az"},

            };

            
            
            List<string> finalStations = new List<string>();
            List<string> statesNeded = new List<string>();
            List<string> statesForStation = new List<string>();
            KeyValuePair <string, List<string>> bestStation = new KeyValuePair<string, List<string>>();
            bestStation = stations.First();
            foreach (var value in stations)
            {
                if (bestStation.Value.Count() < value.Value.Count())
                {
                    bestStation = value;
                }


            }

            Console.WriteLine(bestStation.Key.ToString());
 
        }
    }
}