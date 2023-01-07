using HotChocolate.Resolvers;
using System;

namespace Product_API
{
    public class Query
    {
        public List<ProductType> GetProduct([Service] ProductRepository productRepository)
        {
            return productRepository.GetProduct();
        }

        public ProductType? GetProductBy([Service] ProductRepository productRepository, string name)
        {
            return productRepository.GetProductBy(name);
        }
        public async Task<ProductType?> GetProductByWithdataLoader([Service] ProductRepository productRepository, ProductDataLoader dataLoader, string name)
        {

            return await dataLoader.LoadAsync(name);
        }

        public Task<ProductType> GetProductByWithdataLoaderDelegate(string name,IResolverContext context,[Service] ProductRepository repository)
        {
            return context.BatchDataLoader<string, ProductType>(
                    async (keys, ct) =>
                    {
                        var result = repository.GetProductBy(keys);
                        return result.ToDictionary(x => x.Name);
                    })
                .LoadAsync(name);
        }
    }
}
