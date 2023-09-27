using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Govem.Pages.Main;
using Govem.Northwind;

namespace TestGovem
{
	[Collection("Govem")]
	public class TestMember
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
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbDatePickerModule),
				typeof(IgbSelectModule),
				typeof(IgbComboModule),
				typeof(IgbGridModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Member>();
			Assert.NotNull(componentUnderTest);
		}
	}
}