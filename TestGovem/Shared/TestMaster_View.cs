using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Shared;
using Govem.Financial;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestMaster_View
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbTreeModule),
				typeof(IgbCategoryChartModule),
				typeof(IgbNavbarModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<Master_View>();
			Assert.NotNull(componentUnderTest);
		}
	}
}