using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Bumblebee.Setup.DriverEnvironments
{
  class Browserstack : RemoteDriverEnvironment<BrowserstackDriver>
  {
    DesiredCapabilities Capabilities

    public Browserstack()
		{

		}

		public Browserstack(DesiredCapabilities capabilities)
		{
      Capabilities = capabilities
      Capabilities.SetCapability("browserstack.user", "USERNAME");
      Capabilities.SetCapability("browserstack.key", "ACCESS_KEY");

		}
  }
}
