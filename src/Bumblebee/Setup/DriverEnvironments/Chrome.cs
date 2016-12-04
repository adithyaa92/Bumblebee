using System;
using OpenQA.Selenium.Chrome;

namespace Bumblebee.Setup.DriverEnvironments
{
	public class Chrome : SimpleDriverEnvironment<ChromeDriver>
	{
		public Chrome()
		{
			DesiredCapabilities capability;
			ChromeOptions chromeOptions = new ChromeOptions();
			chromeOptions.AddArgument("--disable-plugins");
			chromeOptions.AddAdditionalCapability("excludeSwitches", "disable-popup-blocking");
			capability = (DesiredCapabilities)chromeOptions.ToCapabilities();
		}

		public Chrome(TimeSpan timeToWait) : base(timeToWait)
		{
		}
	}
}
