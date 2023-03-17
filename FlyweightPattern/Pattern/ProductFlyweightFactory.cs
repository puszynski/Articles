namespace FlyweightPattern.Pattern
{
    public class ProductFlyweightFactory
    {
        private static List<ProductFlyweight> _productFlyweights = new List<ProductFlyweight>();

        public static ProductFlyweight GetProductFlyweight(string productName, decimal value, string currency)
        {
            var result = _productFlyweights
                .SingleOrDefault(x => x.ProductName == productName 
                    && x.Value == value 
                    && x.Currency == currency);

            if (result.Equals(default(ProductFlyweight))) 
                _productFlyweights.Add(new ProductFlyweight
                {
                    ProductName = productName,
                    Value = value,
                    Currency = currency
                });

            return result;
        }
    }
}