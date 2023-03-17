//EXAMPLE 1
TestClass.IsLeapYear();
TestClass.IsLeapYear(2020, 2022);
TestClass.IsLeapYear(1987, 1988, 1989, 1900);

var yearsArray = new[] { 1500, 1501 };
TestClass.IsLeapYear(yearsArray);

var yearsList =  new List<int>() { 1000, 1001, 1002 };
TestClass.IsLeapYear(yearsList.ToArray());

public class TestClass
{
    public static void IsLeapYear(params int[] years)
    {
        if (years.Length == 0)
            return;

        for (int i = 0; i < years.Length; i++)
            Console.WriteLine($"year: {years[i]}, is leap: {DateTime.IsLeapYear(years[i])}");
    }
}

//EXAMPLE WITH STRING AND MAPPING
public class TestClass2
{
    public static void One(params string[] anyValueTypes)
    {
        //todo
    }

    public static void Two(params object[] anyObjects)
    {
    }
}

//why not List<int> ... ?



//other exaples ... todo with objects and mapping .. and else if... 


//in practive - entry in console apps.. using args..

