using HotChocolate.Data.Filters;

namespace Order_API
{
    public class CustomOrderFilterType: FilterInputType<OrderType>
    {
        protected override void Configure(IFilterInputTypeDescriptor<OrderType> descriptor)
        {
            descriptor.Ignore(x => x.OrderDate);
            descriptor.Description("Removes filter capabilities by order date");
        }
    }
}
