using HtmlAgilityPack;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Text;
using System.Xml;
using static System.Net.WebRequestMethods;


namespace parsing
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            

            Console.WriteLine("Enter Google request:");
            string myrequest = Console.ReadLine();

            string url = "https://www.google.com/search?q=" + myrequest ;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string html;

            using (var client = new HttpClient())
            {
                html = await client.GetStringAsync(new Uri(url));
            }
 
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            StringBuilder sb = new StringBuilder();
            foreach (HtmlTextNode node in doc.DocumentNode.SelectNodes("//text()"))
            {
                sb.AppendLine(node.Text);
            }
            string final = sb.ToString();
            StreamWriter sw = new StreamWriter("C:\\Users\\zsirc\\OneDrive\\Documents\\GitHub\\DotNetTaskLearning\\parsing\\Test.txt");
            sw.WriteLine(final);
            sw.Close();
            Console.WriteLine(final);

        }
    }
}