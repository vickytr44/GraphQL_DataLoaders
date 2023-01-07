
using System;

namespace Order_API
{
    public class OrderDataLoader : GroupedDataLoader<string, OrderType>
    {
        private readonly OrderRepository _repository;

        public OrderDataLoader(
            OrderRepository repository,
            IBatchScheduler batchScheduler)
            : base(batchScheduler)
        {
            _repository = repository;
        }


        protected override async Task<ILookup<string, OrderType>> LoadGroupedBatchAsync(IReadOnlyList<string> names,CancellationToken cancellationToken)
        {
            var orders = await _repository.GetOrderBy(names);
            return orders;
        }
    }
}