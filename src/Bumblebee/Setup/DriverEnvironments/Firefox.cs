using System;

using OpenQA.Selenium.Firefox;

namespace Bumblebee.Setup.DriverEnvironments
{
	public class Firefox : SimpleDriverEnvironment<FirefoxDriver>
	{
		public Firefox()
		{
			FirefoxProfile firefoxProfile = new FirefoxProfile();            
			DesiredCapabilities desiredCap = DesiredCapabilities.Firefox();
			firefoxProfile.SetPreference("plugin.state.flash", 0);
			desiredCap.SetCapability(FirefoxDriver.ProfileCapabilityName, firefoxProfile.ToBase64String());
		}

		public Firefox(TimeSpan timeToWait) : base(timeToWait)
		{
		}
	}
}
