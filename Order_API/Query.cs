using HotChocolate.Resolvers;
using System;

namespace Order_API
{   
    public class Query 
    {
        [UsePaging(IncludeTotalCount =true)]
        [UseFiltering(typeof(CustomOrderFilterType))]
        [UseSorting(typeof(CustomOrderSortType))]
        public List<OrderType> GetOrder([Service] OrderRepository orderRepository)
        {
            return orderRepository.GetOrder();
        }

        [UsePaging(IncludeTotalCount = true)]
        [UseFiltering(typeof(CustomOrderFilterType))]
        [UseSorting(typeof(CustomOrderSortType))]
        public List<OrderType> GetOrderBy([Service] OrderRepository orderRepository,string name)
        {
            return orderRepository.GetOrderBy(name);
        }

        public async Task<IEnumerable<OrderType>> GetOrderByWithDataLoaderDelegate(string name, IResolverContext context, [Service] OrderRepository repository)
        {
            return await context.GroupDataLoader<string, OrderType>(
                    async (keys, ct) =>
                    {
                        var result = await repository.GetOrderBy(keys);
                        return result;
                    })
                .LoadAsync(name);
        }

        [UsePaging(IncludeTotalCount = true)]
        [UseFiltering(typeof(CustomOrderFilterType))]
        [UseSorting(typeof(CustomOrderSortType))]
        public async Task<IEnumerable<OrderType>> GetOrderByWithDataLoader(OrderDataLoader dataLoader, string name)
        {
            return await dataLoader.LoadAsync(name);
        }
    }
}
