namespace ConsoleAppCustomException.CustomExceptions
{
    internal class MyFancyCustomException : Exception
    {
        public MyFancyCustomException() : base()
        {
        }

        public MyFancyCustomException(string message) : base(message)
        {
        }

        public MyFancyCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
