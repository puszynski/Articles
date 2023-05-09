// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var products = new List<Product> { new Product { Name = "A", Popularity = 10, Price = 20.00m }, new Product { Name = "B", Popularity = 5, Price = 50.00m } };

var context = new SortingContext();

context.SetSortingStrategy(new PopularitySortingStrategy());
var productsSortedByPopularity = context.ExecuteStrategy(products);

context.SetSortingStrategy(new PriceSortingStrategy());
var productsSortedByPrice = context.ExecuteStrategy(products);

interface ISortingStrategy
{
    List<Product> Sort(List<Product> products);
}

class SortingContext
{
    private ISortingStrategy _strategy;

    public SortingContext() 
        => _strategy = new PriceSortingStrategy();

    public void SetSortingStrategy(ISortingStrategy strategy) 
        => _strategy = strategy;

    public List<Product> ExecuteStrategy(List<Product> products) 
        => _strategy.Sort(products);
}

class PopularitySortingStrategy : ISortingStrategy
{
    public List<Product> Sort(List<Product> products) 
        => products.OrderBy(x => x.Popularity).ToList();
}

class PriceSortingStrategy : ISortingStrategy
{
    public List<Product> Sort(List<Product> products) 
        => products.OrderBy(x => x.Price).ToList();
}

class Product
{
    public string Name { get; set; }
    public int Popularity { get; set; }
    public decimal Price { get; set; }
}