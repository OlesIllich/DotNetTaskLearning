namespace DotNetLearning.ExceptionTasks
{
    public class MyCustomException : Exception
    {

    }


    public class ExceptionTasks
    {
        public void ThrowBaseException()
        {

        }

        public void ThrowMyCustomWithoutStackTraceException()
        {

        }

        public void ThrowWithStackTraceException()
        {

        }

        public void WriteToConsoleInFinally()
        {

        }

        private void ThrowException()
        {
            throw new Exception();
        }
    }
}
