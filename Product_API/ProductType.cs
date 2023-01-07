namespace Product_API
{
    public class ProductType
    {
        public ProductType(long serialNumber, string? name, Category category)
        {
            SerialNumber = serialNumber;
            Name = name;
            Category = category;
        }

        public long SerialNumber { get; set; }
        public String? Name { get; set; }
        public Category Category { get; set; }
    }

    public enum Category{ 
    FASHION,
    TECH
    }
}
