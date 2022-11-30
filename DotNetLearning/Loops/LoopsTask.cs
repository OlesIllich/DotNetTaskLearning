namespace DotNetLearning.Loops
{
    public class LoopsTask
    {
        public string GetAllExceptA(string str)
        {
            str = str.Replace("a", "");
            return str;
        }

        public string ReturnMirror(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
