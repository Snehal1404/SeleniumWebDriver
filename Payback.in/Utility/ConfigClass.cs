using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Payback_Po.Utility
{
    public class ConfigClass
    {
        public static IWebDriver? driver;
        public static string chromeDriverPath = @"D:\CAPGEMINI\C# Practice\Payback.in\Payback.in\Payback.in\Driver\chromedriver_win32\";
       // public static string geckoDriverPath = @"C:\Users\username\source\repos\SeleniumSpecFlowPO\SeleniumSpecFlowPO\drivers\";
       
        public static string url = "https://www.payback.in/";

        public static string filePath = @"D:\CAPGEMINI\C# Practice\Payback.in\Payback.in\Payback.in\ScreenShot\";

        public static int PAGE_LOAD_TIMEOUT = 10;
        public static int IMPLICIT_WAIT = 10;

        public static Actions? action;
    }
}
