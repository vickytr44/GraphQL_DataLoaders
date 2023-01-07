using Customer_API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddSingleton<CustomerRepository>()
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddFiltering()
    .PublishSchemaDefinition(c => c
        .SetName("customer")
        .AddTypeExtensionsFromFile("./Stitching.graphql"));

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

app.MapGraphQL("/customer-api/graphql");

app.Run();
