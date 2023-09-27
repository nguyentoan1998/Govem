using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Pages.Master_View;
using Govem.Northwind;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestUsers
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
				typeof(IgbSelectModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Users>();
			Assert.NotNull(componentUnderTest);
		}
	}
}