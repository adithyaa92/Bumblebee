using Bumblebee.Extensions;
using Bumblebee.IntegrationTests.Shared.Hosting;
using Bumblebee.IntegrationTests.Shared.Pages.Implementation;
using Bumblebee.Setup;
using Bumblebee.Setup.DriverEnvironments;

using FluentAssertions;

using NUnit.Framework;

namespace Bumblebee.IntegrationTests.Implementation
{
	// ReSharper disable InconsistentNaming
	[TestFixture]
	public class Given_numeric_field : HostTestFixture
	{
		[TestFixtureSetUp]
		public void TestFixtureSetUp()
		{
			Threaded<Session>
				.With<PhantomJS>()
				.NavigateTo<NumericFieldPage>(GetUrl("NumericField.html"));
		}

		[TestFixtureTearDown]
		public void TestFixtureTearDown()
		{
			Threaded<Session>
				.End();
		}

		[Test]
		public void When_entering_number_Then_text_and_value_work()
		{
			Threaded<Session>
				.CurrentBlock<NumericFieldPage>()
				.Number.EnterNumber(5)
				.VerifyThat(x => x.Number.Value.Should().Be(5))
				.VerifyThat(x => x.Number.Text.Should().Be("5"));
		}
	}
}