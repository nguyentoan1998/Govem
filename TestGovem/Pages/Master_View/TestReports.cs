using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Pages.Master_View;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestReports
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Reports>();
			Assert.NotNull(componentUnderTest);
		}
	}
}