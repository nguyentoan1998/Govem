using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Pages;
using Govem.Northwind;

namespace TestGovem
{
	[Collection("Govem")]
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
				typeof(IgbDataGridToolbarModule),
				typeof(IgbSelectModule),
				typeof(IgbTabsModule),
				typeof(IgbActionStripModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Materials>();
			Assert.NotNull(componentUnderTest);
		}
	}
}