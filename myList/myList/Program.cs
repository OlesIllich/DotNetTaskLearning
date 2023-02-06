using System.Runtime.InteropServices;

namespace myList
{
    internal class Program
    {
        static void Main(string[] args)


        {

            List<string> list = new List<string>();
            MyCustomList<string> myCustomList = new MyCustomList<string>();
            myCustomList.Add("1");
            myCustomList.Add("2");
            myCustomList.Add("3");
            myCustomList.Add("4");
            myCustomList.Add("5");
            myCustomList.Remove(2);

            //for (int i = 0; i < myCustomList.Count; i++)
            //{
            //    Console.WriteLine(myCustomList[i]);
            //}


            foreach (var item in myCustomList)
            {
                 Console.WriteLine(item);

            }
        }
    }
}