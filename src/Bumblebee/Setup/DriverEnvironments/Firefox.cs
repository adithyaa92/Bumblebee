using System;

using OpenQA.Selenium.Firefox;

namespace Bumblebee.Setup.DriverEnvironments
{
	public class Firefox : RemoteDriverEnvironment<FirefoxDriver>
	{
		public Firefox()
		{

		}

		public Firefox(TimeSpan timeToWait) : base(timeToWait)
		{
		}
	}
}
