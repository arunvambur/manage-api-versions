using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using OrderService;
using OrderService.Application.Feature.Order.Commands;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer()
    .AddSwaggerGen(options =>
    {
        //options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo() { Title = "Order Api Version 1", Version = "v1", Description = "Order Service Version 1" });
        //options.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo() { Title = "Order Api Version 2", Version = "v2", Description = "Order Service Version 2" });

        //options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
        //options.CustomSchemaIds(x => x.FullName);

        //options.SchemaFilter<SchemaVersionFilter>();


    })
    .AddApiVersioning(config =>
    {
        config.DefaultApiVersion = new ApiVersion(1, 0);
        config.AssumeDefaultVersionWhenUnspecified = true;
        config.ReportApiVersions = true;
    })
    .AddVersionedApiExplorer(setup =>
    {
        setup.GroupNameFormat = "'v'VVV";
        setup.SubstituteApiVersionInUrl = true;
    })
    .AddMediatR(typeof(CreateOrderCommand).Assembly)
    .AddAutoMapper(Assembly.GetExecutingAssembly())
    .AddValidatorsFromAssembly(typeof(CreateOrderCommandValidator).Assembly);
    

builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

var app = builder.Build();

var provider = app.Services.GetService<IApiVersionDescriptionProvider>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
    //options.DocumentTitle = "Order Service";
    //options.SwaggerEndpoint($"/swagger/v1/swagger.json", "v1");
    //options.SwaggerEndpoint($"/swagger/v2/swagger.json", "v2");
    //
        foreach (var description in  provider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant()); 
        } 

    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
