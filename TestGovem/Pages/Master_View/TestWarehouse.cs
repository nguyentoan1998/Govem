using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Pages.Master_View;
using Govem.Northwind;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestWarehouse
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
			var componentUnderTest = ctx.RenderComponent<Warehouse>();
			Assert.NotNull(componentUnderTest);
		}
	}
}