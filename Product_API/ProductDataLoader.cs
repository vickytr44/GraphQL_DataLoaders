namespace Product_API
{
    public class ProductDataLoader : BatchDataLoader<string, ProductType>
    {
        private readonly ProductRepository _repository;

        public ProductDataLoader(
            ProductRepository repository,
            IBatchScheduler batchScheduler)
            : base(batchScheduler)
        {
            _repository = repository;
        }

        protected override async Task<IReadOnlyDictionary<string, ProductType?>> LoadBatchAsync(
            IReadOnlyList<string> keys,
            CancellationToken cancellationToken)
        {
            var products = _repository.GetProductBy(keys);
            return products.ToDictionary(x => x.Name);
        }
    }
}