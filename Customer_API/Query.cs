namespace Customer_API
{
    public class Query
    {
        public CustomerType GetCustomerByName([Service] CustomerRepository customerRepository, string name)
        {
            return customerRepository.GetCustomerBy(name);
        }

        public List<CustomerType> GetAllCustomer([Service] CustomerRepository customerRepository)
        {
            return customerRepository.GetAllCustomers();
        }
    }
}
