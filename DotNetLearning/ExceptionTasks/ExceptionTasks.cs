using System.Linq.Expressions;

namespace DotNetLearning.ExceptionTasks
{
    public class MyCustomException : Exception
    {

    }


    public class ExceptionTasks
    {
        public void ThrowBaseException()
        {
            throw new Exception();
        }

        public void ThrowMyCustomWithoutStackTraceException()
        {
            throw new MyCustomException();
        }

        public void ThrowWithStackTraceException(MyCustomException e)
        {
         Console.WriteLine(e.StackTrace);   
        }

        public void WriteToConsoleInFinally()
        {
            try
            {

            }
            finally 
            {

                Console.WriteLine("some information about exeption");
            }
        }

        private void ThrowException()
        {
            throw new Exception();
        }
    }
}
