using System.Runtime.InteropServices;

namespace myList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCustomList<int> myCustomList = new MyCustomList<int>();
            myCustomList.Add(1);
            myCustomList.Add(2);
            myCustomList.Add(3);
            myCustomList.Add(4);
            myCustomList.Add(5);
            //myCustomList.Remove(2);

            //for (int i = 0; i < myCustomList.Count; i++)
            //{ 
            //    Console.WriteLine(myCustomList[i]);
            //}


            foreach (int item in myCustomList)
            {
  
                Console.WriteLine(myCustomList[item]);

            }
        }
    }
}