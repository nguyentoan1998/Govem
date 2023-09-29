using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Pages.Main;
using Govem.Northwind;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestFund
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbGridModule),
				typeof(IgbDataGridToolbarModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Fund>();
			Assert.NotNull(componentUnderTest);
		}
	}
}