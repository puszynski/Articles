namespace FlyweightPattern.Pattern
{
    public class Invoice
    {
        public string InvoiceName { get; set; }
        public string UserFullName { get; set; }
        public ProductFlyweight Product { get; set; }
    }
}
