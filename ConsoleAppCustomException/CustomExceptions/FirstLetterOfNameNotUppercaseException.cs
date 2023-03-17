namespace ConsoleAppCustomException.CustomExceptions
{
    internal class FirstLetterOfNameNotUpperCaseException : Exception
    {
        public FirstLetterOfNameNotUpperCaseException() : base()
        {
        }

        public FirstLetterOfNameNotUpperCaseException(string message) : base(message)
        {
        }

        public FirstLetterOfNameNotUpperCaseException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
