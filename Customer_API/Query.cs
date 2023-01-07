namespace Customer_API
{
    public class Query
    {
        [UseFiltering]
        public CustomerType GetCustomerByName([Service] CustomerRepository customerRepository, string name)
        {
            return customerRepository.GetCustomerBy(name);
        }
    }
}
