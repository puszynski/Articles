using ConsoleAppCustomException.CustomExceptions;
using ConsoleAppCustomException.NotImportant;

Console.WriteLine("FirstOperation.");
throw new MyFancyCustomException();
Console.WriteLine("SecondOperation.");



//BUT WE CAN USE CUSTOM ONCE (to name it specyfic for our needs)  => docs => https://learn.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions




//REAL LIFE EXAMPLE
var generator = new UserNameGenerator();
var userWithIncorrectName = new User { Name = "james" };

try
{
    generator.VerifyUser(userWithIncorrectName);
}
catch (FirstLetterOfNameNotUpperCaseException)
{
    Console.WriteLine("User has incorrect name.");
}
catch (ArgumentNullException)
{
    Console.WriteLine("Please provide required data.");
}


// basic rules about what to do, what not: https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/using-standard-exception-types

//DONT throw basic exception
//throw new Exception();
//throw new SystemException();

//DO - use builtin dotnet exception
throw new InvalidOperationException();  //Unhandled exception. System.InvalidOperationException: Operation is not valid due to the current state of the object.

//DO
throw new ArgumentException();  //Unhandled exception. System.ArgumentException: Value does not fall within the expected range.
throw new ArgumentNullException();
throw new ArgumentOutOfRangeException();
throw new DuplicateWaitObjectException();

//FIRST USE PREDEFINED EXCEPTIONS - full list: https://learn.microsoft.com/en-us/dotnet/api/system.exception?view=net-7.0:
throw new Microsoft.CSharp.RuntimeBinder.RuntimeBinderException();
throw new Microsoft.CSharp.RuntimeBinder.RuntimeBinderInternalCompilerException();
throw new Microsoft.VisualBasic.CompilerServices.IncompleteInitialization();
throw new Microsoft.VisualBasic.FileIO.MalformedLineException();
throw new AggregateException();
throw new ApplicationException();
throw new System.ComponentModel.DataAnnotations.ValidationException();
throw new System.Diagnostics.Tracing.EventSourceException();
throw new System.Formats.Asn1.AsnContentException();
throw new InvalidTimeZoneException();
throw new System.IO.IsolatedStorage.IsolatedStorageException();
throw new System.Net.Http.HttpRequestException();
throw new System.Net.Mail.SmtpException();
throw new System.Reflection.Metadata.ImageFormatLimitationException();
throw new System.Runtime.AmbiguousImplementationException();
throw new System.Runtime.Serialization.InvalidDataContractException();
throw new System.SystemException();
throw new System.Text.Json.JsonException();
throw new System.Threading.BarrierPostPhaseException();
throw new System.Threading.LockRecursionException();
throw new System.Threading.Tasks.TaskSchedulerException();
throw new System.TimeZoneNotFoundException();




//best pratice with exceptions => https://learn.microsoft.com/en-us/dotnet/standard/exceptions/best-practices-for-exceptions

Console.WriteLine("That line will not be executed, program will stop due to exception!");

