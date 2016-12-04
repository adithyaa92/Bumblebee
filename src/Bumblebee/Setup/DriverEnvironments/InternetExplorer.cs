using System;

using OpenQA.Selenium.IE;

namespace Bumblebee.Setup.DriverEnvironments
{
	public class InternetExplorer : SimpleDriverEnvironment<InternetExplorerDriver>
	{
		public InternetExplorer()
		{
			desiredCap.SetCapability("browserstack.ie.noFlash", "true");
			desiredCap.SetCapability("browserstack.ie.enablePopups", "true");
		}

		public InternetExplorer(TimeSpan timeToWait) : base(timeToWait)
		{
		}
	}
}
