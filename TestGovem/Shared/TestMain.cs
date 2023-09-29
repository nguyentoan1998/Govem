using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Shared;
using Govem.Financial;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestMain
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbTreeModule),
				typeof(IgbCategoryChartModule),
				typeof(IgbNavbarModule),
				typeof(IgbRippleModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<Main>();
			Assert.NotNull(componentUnderTest);
		}
	}
}