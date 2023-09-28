using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Govem;
using Govem.Financial;
using Govem.Northwind;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IFinancialService>(sp => new FinancialService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<INorthwindService>(sp => new NorthwindService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbButtonModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbTreeModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbNavbarModule),
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