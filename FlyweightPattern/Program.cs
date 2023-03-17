using FlyweightPattern.NoPattern;
var isPatternExample = true; //change to switch 

if (isPatternExample)
{
    var items = new List<FlyweightPattern.Pattern.Invoice>();
    var random = new Random();

    for (int i = 0; i < 100000000; i++)
    {
        bool isItemA = random.NextDouble() >= 0.5;

        var item = new FlyweightPattern.Pattern.Invoice()
        {
            InvoiceName = random.Next(100, 999).ToString(),
            UserFullName = random.Next(100, 999).ToString(),
            Product = FlyweightPattern.Pattern.ProductFlyweightFactory.GetProductFlyweight(isItemA ? "ItemA" : "ItemB", isItemA ? 33.3m : 9.99m, isItemA ? "PLN" : "EUR")
        };

        items.Add(item);
    }

    Console.ReadLine();
}


else
{
    var items = new List<Invoice>();
    var random = new Random();

    for (int i = 0; i < 100000000; i++)
    {
        bool isItemA = random.NextDouble() >= 0.5;

        var item = new Invoice()
        {
            InvoiceName = random.Next(100, 999).ToString(),
            UserFullName = random.Next(100, 999).ToString(),
            ProductName = isItemA ? "ItemA" : "ItemB",
            Currency = isItemA ? "PLN" : "EUR",
            Value = isItemA ? 33.3m : 9.99m
        };

        items.Add(item);
    }

    Console.ReadLine();
}
