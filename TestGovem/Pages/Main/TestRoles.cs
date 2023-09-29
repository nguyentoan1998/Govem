using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Pages.Main;
using Govem.Northwind;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestRoles
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
			var componentUnderTest = ctx.RenderComponent<Roles>();
			Assert.NotNull(componentUnderTest);
		}
	}
}