
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Localization;
using DevExpress.Blazor;
using ERCAJ_BANCO_proj.Services;
using ERCAJ_BANCO_proj.Components;
using ERCAJ_BANCO_proj;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = BootstrapVersion.v5);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("localhost") });

builder.Services.AddLocalization();

//builder.Services.AddScoped<TransactionService>();
//builder.Services.AddScoped<LookUpService>();
builder.Services.AddScoped<SimpleTransactionService>();
builder.Services.AddScoped<CAJ_BANCOValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

