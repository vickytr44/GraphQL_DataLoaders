namespace Customer_API
{
    public class CustomerRepository
    {
        private readonly Dictionary<string, CustomerType> _customer;

        public CustomerRepository()
        {
            _customer = new CustomerType[]
            {
                new CustomerType("John", 18, true),
                new CustomerType("Jeeva", 22, false),
                new CustomerType("Ava", 20, false)
            }.ToDictionary(t => t.Name);
        }

        public CustomerType GetCustomerBy(string name) => _customer[name];
    }
}
