namespace Strategy.Core
{
    public class CustomerDataStore
    {
        private readonly List<Customer> _customers = new List<Customer>();

        public CustomerDataStore()
        {
            _customers.Add(new Customer { Id = 1, Name = "John", Type = CustomerType.Silver });
            _customers.Add(new Customer { Id = 2, Name = "Mary", Type = CustomerType.Silver });
            _customers.Add(new Customer { Id = 3, Name = "Peter", Type = CustomerType.Gold });
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customers;
        }
    }
}