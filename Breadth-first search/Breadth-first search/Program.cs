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
            graph.Add("Claire", new List<string> { "Thom", "MangoSeller" });
            graph.Add("Anuj", new List<string> { });
            graph.Add("Peggy", new List<string> { }); 
            graph.Add("Thom", new List<string> { });
            graph.Add("Jonny", new List<string> { "MangoSeller" });
            return graph;
        }
        static void Main(string[] args)
        {

            var myGraph = GetGraph();
            var queue = new Queue<string>();
            var searched = new Dictionary<string, List<string>>();

            string searchingSaler = null;

            foreach (var value in myGraph.First().Value)
            {
                queue.Enqueue(value);
            }


            while ((queue.Count > 0) && (searchingSaler != "MangoSeller"))
            {
                var something = queue.Dequeue();

                if (something == "MangoSeller")
                {
                    Console.WriteLine($"Congrats! We found {searchingSaler}");
                    return;
                }


                foreach (var saler in myGraph[something])
                {
                    queue.Enqueue(saler);
                }
            }

            
                Console.WriteLine("Unfortunadly we didn't find him (((");
        }
         
        }
    }
