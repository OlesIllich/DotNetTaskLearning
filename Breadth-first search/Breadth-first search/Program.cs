namespace Breadth_first_search
{
    internal class Program
    {
        static Dictionary<string, List<string>> GetGraph()
        { 
            var graph = new Dictionary<string, List<string>>();
            graph.Add("I Am", new List<string> { "Alice", "Bob", "Claire" });
            graph.Add("Bob", new List<string> { "Anuj", "Peggy"});
            graph.Add("Alice", new List<string> { "Peggy"});
            graph.Add("Claire", new List<string> { "Thom", "MangoSeller"});
            graph.Add("Anuj", new List<string> { });
            graph.Add("Peggy", new List<string> { }); 
            graph.Add("Thom", new List<string> { });
            graph.Add("Jonny", new List<string> { });
            return graph;
        }
        static void Main(string[] args)
        {

            var myGraph = GetGraph();
            var queue = new Queue<KeyValuePair<string, List<string>>>();
            var searched = new Dictionary<string, List<string>>();

            string searchingSaler = null;

            foreach (var keyValuePair in myGraph)
            {
                queue.Enqueue(keyValuePair);
            }


            while ((queue.Count > 0) && (searchingSaler != "MangoSeller"))
            {
                var something = queue.Dequeue();
                searchingSaler = something.Key;
                var salersFreands = something.Value;
                foreach (var saler in salersFreands)
                {
                    searchingSaler = saler;
                }
            }

            if (searchingSaler == "MangoSeller")
                Console.WriteLine($"Congrats! We found {searchingSaler}");
            else
                Console.WriteLine("Unfortunadly we didn't find him (((");
        }
         
        }
    }
