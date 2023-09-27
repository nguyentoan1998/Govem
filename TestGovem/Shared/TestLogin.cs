using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Shared;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestLogin
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Login>();
			Assert.NotNull(componentUnderTest);
		}
	}
}