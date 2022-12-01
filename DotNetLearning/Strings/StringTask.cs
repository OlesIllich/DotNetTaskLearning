namespace DotNetLearning.Strings
{
    public class StringTask
    {
        public char GetFirst(string str)
        {
            char first = str.First();
            return first;
        }

        public int GetStringLength(string str)
        {
            int length = str.Length - 1;
            return length;
        }

        public string GetUpperCase(string str)
        {
            str = str.ToUpper();
            return str;
        }

        public string Concatenate(string firstStr, string secondStr)
        {
            string str = firstStr + secondStr;
            return str;
        }
    }
}