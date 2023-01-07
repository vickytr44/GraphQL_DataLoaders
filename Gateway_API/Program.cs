using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

var Customer = "customer";
var Order = "order";
var Product = "product";
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient(Customer, c => c.BaseAddress = new Uri("https://localhost:7190/customer-api/graphql/"));
builder.Services.AddHttpClient(Order, c => c.BaseAddress = new Uri("https://localhost:7236/order-api/graphql/"));
builder.Services.AddHttpClient(Product, c => c.BaseAddress = new Uri("https://localhost:7046/product-api/graphql/"));


builder.Services
    .AddGraphQLServer()
    .AddRemoteSchema(Customer)
        .AddRemoteSchema(Order)
        .AddRemoteSchema(Product)
    .ConfigureSchema(sb => sb.ModifyOptions(opts => opts.StrictValidation = false));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL("/gateway/graphql");

app.Run();
