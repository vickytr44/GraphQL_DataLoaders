namespace Product_API
{
    public class Query
    {
        public List<ProductType> GetProduct([Service] ProductRepository productRepository)
        {
            return productRepository.GetProduct();
        }

        public ProductType? GetProductBy([Service] ProductRepository productRepository,string name)
        {
            return productRepository.GetProductBy(name);
        }
        public async Task<ProductType?> GetProductByWithdataLoader([Service] ProductRepository productRepository,ProductDataLoader dataLoader ,string name)
        {

            return await dataLoader.LoadAsync(name);
        }
    }
}
