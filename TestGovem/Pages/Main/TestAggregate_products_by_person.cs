using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Pages.Main;
using Govem.Northwind;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestAggregate_products_by_person
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
				typeof(IgbDataGridToolbarModule),
				typeof(IgbTabsModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Aggregate_products_by_person>();
			Assert.NotNull(componentUnderTest);
		}
	}
}