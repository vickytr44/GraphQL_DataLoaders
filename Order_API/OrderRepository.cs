namespace Order_API
{
    public class OrderRepository
    {
        private readonly List<OrderType> _order;

        public OrderRepository()
        {
            _order = new OrderType[]
            {
                new OrderType(1,Convert.ToDateTime("2022-01-01"), 1000,"Ava",new List<ProductName>(){ new ProductName("Watch"),new ProductName("Laptop"),new ProductName("Mobile") }),
                new OrderType(2,Convert.ToDateTime("2022-01-01"), 150,"Jeeva",new List<ProductName>(){ new ProductName("Mobile") }),
                new OrderType(3,Convert.ToDateTime("2022-02-01"), 50,"Ava",new List<ProductName>(){ new ProductName("Perfume") }),
                new OrderType(4,Convert.ToDateTime("2022-03-01"), 1100,"Ava",new List<ProductName>(){ new ProductName("Sheo"),new ProductName("Shirt") }),
                new OrderType(5,Convert.ToDateTime("2022-03-01"), 200,"Ava",new List<ProductName>(){ new ProductName("Jean") })
            }.ToList();
        }

        public List<OrderType> GetOrder() => _order;
        public List<OrderType> GetOrderBy(string name) => _order.Where(x => x.CustomerName == name).ToList();
    }
}
