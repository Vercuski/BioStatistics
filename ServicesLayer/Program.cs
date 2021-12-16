using GraphQL.Server.Ui.Voyager;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts;
using Repository.Interfaces;
using Repository.Objects;
using ServicesLayer.Mutations;
using ServicesLayer.Queries;

const string version = "v1";

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json", false, true);

builder.Services.AddScoped<IBioStatisticsRepository, BioStatisticsRepository>();
builder.Services.AddScoped<BioStatisticsQuery>();
builder.Services.AddGraphQLServer()
    .AddQueryType<BioStatisticsQuery>()
    .AddMutationType<BioStatisticsMutation>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<BioStatisticsDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BioStatistics")));

builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc(version, new() { Title = "BioStatistics GraphQL", Version = version });
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint($"/swagger/{version}/swagger.json", $"BioStatistics GraphQL {version}"));
}

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.UseGraphQLVoyager(new VoyagerOptions()
{
    GraphQLEndPoint = "/graphql"
}, "/graphql-voyager");

app.Run();
