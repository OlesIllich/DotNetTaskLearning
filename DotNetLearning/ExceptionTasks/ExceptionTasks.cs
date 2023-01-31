using System.Diagnostics;
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
            ThrowException();
        }

        public void ThrowMyCustomWithoutStackTraceException()
        {
            try
            {
                ThrowException();
            }
            catch (Exception)
            {

                throw new MyCustomException();
            }
        }

        public void ThrowWithStackTraceException()
        {
            try
            {
                ThrowException();
            }
            catch (Exception)
            {
                Console.WriteLine("throw");
                throw;
            }

              
            
        }

        public void WriteToConsoleInFinally()
        {
            try
            {
                ThrowException();
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
