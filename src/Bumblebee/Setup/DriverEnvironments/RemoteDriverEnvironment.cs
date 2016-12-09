using System;

using OpenQA.Selenium;

namespace Bumblebee.Setup.DriverEnvironments
{
	public abstract class RemoteDriverEnvironment<TWebDriver> : IDriverEnvironment
		where TWebDriver : IWebDriver, new()
	{
		private String RemoteUrl { get; set; }
    private DesiredCapabilities Capabilities { get; set; }

		public RemoteDriverEnvironment() : this(TimeSpan.FromSeconds(5))
		{
		}

		public RemoteDriverEnvironment(String remoteUrl, DesiredCapabilities capabilities)
		{
			RemoteUrl = remoteUrl;
      Capabilities = capabilities;
		}

		public virtual IWebDriver CreateWebDriver()
		{
			var driver = new TWebDriver();

			driver.Manage().Window.Maximize();

			driver.Manage().Timeouts().ImplicitlyWait(TimeToWait);

			return driver;
		}
	}
}
