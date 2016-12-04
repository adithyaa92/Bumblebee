using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumTest {
  class Program {
    static void Main(string[] args) {
      IWebDriver driver;
      DesiredCapabilities capability = DesiredCapabilities.Firefox();
      capability.SetCapability("browserstack.user", "USERNAME");		//Update with BStack username
      capability.SetCapability("browserstack.key", "ACCESS_KEY");		//update with BStack password
      capability.SetCapability("browser", "Firefox");
	  capability.SetCapability("browser_version", "3.6");
	  capability.SetCapability("os", "Windows");
	  capability.SetCapability("os_version", "7");
	  capability.SetCapability("resolution", "1024x768");
	  capability.SetCapability("acceptSslCerts", "true");
	  capability.SetCapability("browserstack.debug", "true");

      driver = new RemoteWebDriver(
        new Uri("http://hub-cloud.browserstack.com/wd/hub/"), capability
      );
      driver.Navigate().GoToUrl("http://www.google.com");
      Console.WriteLine(driver.Title);

      IWebElement query = driver.FindElement(By.Name("q"));
      query.SendKeys("Browserstack");
      query.Submit();
      Console.WriteLine(driver.Title);

      driver.Quit();
    }
  }
}