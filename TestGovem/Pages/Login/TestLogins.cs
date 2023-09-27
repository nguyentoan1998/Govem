using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Pages.Login;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestLogins
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbSwitchModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Logins>();
			Assert.NotNull(componentUnderTest);
		}
	}
}