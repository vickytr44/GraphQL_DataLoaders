using HotChocolate.Data.Sorting;

namespace Order_API
{
    public class CustomOrderSortType: SortInputType<OrderType>
    {
        protected override void Configure(ISortInputTypeDescriptor<OrderType> descriptor)
        {
            descriptor.Ignore(x => x.ProductNames);
            descriptor.Description("Removes sorting capabilities by product name");
        }
    }
}
