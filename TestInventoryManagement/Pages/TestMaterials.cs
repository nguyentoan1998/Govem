using Bunit;
using Microsoft.Extensions.DependencyInjection;
using InventoryManagement.Pages;
using InventoryManagement.Northwind;

namespace TestInventoryManagement
{
	[Collection("InventoryManagement")]
	public class TestMaterials
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbInputModule),
				typeof(IgbGridModule),
				typeof(IgbDataGridToolbarModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Materials>();
			Assert.NotNull(componentUnderTest);
		}
	}
}