using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Pages;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbPieChartModule),
				typeof(IgbCategoryChartModule));
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}