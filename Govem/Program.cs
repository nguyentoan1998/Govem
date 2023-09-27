using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Govem;
using Govem.Financial;
using Govem.Northwind;
using IgniteUI.Blazor.Controls;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();


builder.Services.AddScoped<IFinancialService>(sp => new FinancialService(sp.GetRequiredService<IWebHostEnvironment>()));
builder.Services.AddScoped<INorthwindService>(sp => new NorthwindService(sp.GetRequiredService<IWebHostEnvironment>()));
RegisterIgniteUI(builder.Services);

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbTreeModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbNavbarModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbCardModule),
        typeof(IgbPieChartModule),
        typeof(IgbInputModule),
        typeof(IgbIconButtonModule),
        typeof(IgbDatePickerModule),
        typeof(IgbSelectModule),
        typeof(IgbComboModule),
        typeof(IgbGridModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbTabsModule),
        typeof(IgbActionStripModule),
        typeof(IgbRadioGroupModule),
        typeof(IgbRadioModule),
        typeof(IgbSwitchModule)
    );
}

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
