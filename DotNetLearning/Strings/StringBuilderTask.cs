using System.Text;

namespace DotNetLearning.Strings
{
    public class StringBuilderTask
    {
        public StringBuilder SetStringBuilder(string str1, string str2, string str3)
        {
            StringBuilder sb = new StringBuilder(str1);
            sb.Append(str2);
            sb.Append(str3);
            return sb;
            string newStr = sb.ToString();  
            return newStr;
        }
    }
}
