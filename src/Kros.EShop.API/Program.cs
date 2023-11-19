﻿using Kros.UnitTestsWorkshop.EShop;
using Microsoft.Extensions.Options;
using Refit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ApiKeyHandler>();
builder.Services.AddSingleton<IClientRepository, ClientRepository>();
builder.Services.AddRefitClient<IFreecurrencyApi>()
    .ConfigureHttpClient((f, c) =>
    {
        var config = f.GetRequiredService<IOptions<FreecurrencyApiConfig>>().Value;
        c.BaseAddress = new Uri(config.BaseUrl);
    })
    .AddHttpMessageHandler<ApiKeyHandler>();

builder.Services.Configure<FreecurrencyApiConfig>(builder.Configuration.GetSection("FreecurrencyApi"));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/products", async (Product product, IFreecurrencyApi freecurrencyApi) =>
{
    var rates = await freecurrencyApi.GetRatesAsync("EUR");
    product.PriceUsd = product.Price * rates.Data["USD"];
    product.PriceGbp = product.Price * rates.Data["GBP"];
    product.PriceCzk = product.Price * rates.Data["CZK"];
    product.PricePln = product.Price * rates.Data["PLN"];

    return product;
});

app.MapGet("/recalculate/{baseCurrency}/{targetCurrency}",
    async (string baseCurrency, string targetCurrency, decimal price, IFreecurrencyApi freecurrencyApi) =>
    {
        var rates = await freecurrencyApi.GetRatesAsync(baseCurrency);

        return price * rates.Data[targetCurrency];
    });

app.MapGet("/api/clients", (IClientRepository repository) => repository.GetAll());
app.MapGet("/api/clients/{id}", (Guid id, IClientRepository repository) =>
{
    var client = repository.GetById(id);
    return client is null ? Results.NotFound() : Results.Ok(client);
});
app.MapPost("/api/clients", (Client client, IClientRepository repository) =>
{
    Guid id = repository.Save(client);
    return Results.Created($"/api/clients/{id}", id);
});

app.Run();

public partial class Program { }