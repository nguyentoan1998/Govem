using Bunit;
using Microsoft.Extensions.DependencyInjection;
using InventoryManagement.Pages;
using InventoryManagement.ECommerce;
using InventoryManagement.InventoryApp;

namespace TestInventoryManagement
{
	[Collection("InventoryManagement")]
	public class TestProducts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbSelectModule),
				typeof(IgbComboModule),
				typeof(IgbInputModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbCheckboxModule));
			ctx.Services.AddScoped<IECommerceService>(sp => new MockECommerceService());
			ctx.Services.AddScoped<IInventoryAppService>(sp => new MockInventoryAppService());
			var componentUnderTest = ctx.RenderComponent<Products>();
			Assert.NotNull(componentUnderTest);
		}
	}
}