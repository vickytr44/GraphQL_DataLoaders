namespace Order_API
{
    public class OrderType
    {
        public OrderType(long orderNumber, DateTime orderDate, double totalAmount, string? customerName, List<ProductName> productNames)
        {
            OrderNumber = orderNumber;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            CustomerName = customerName;
            ProductNames = productNames;
        }

        public long OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public String?  CustomerName { get; set; }
        public List<ProductName>? ProductNames { get; set; }
    }

    public class ProductName {

        public ProductName(string name)
        {
            Name = name;
        }
        public string? Name { get; set; }
    }

}
