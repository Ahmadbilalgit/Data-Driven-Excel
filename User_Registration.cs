using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Threading.Tasks;

namespace User_Registeration_Excel_Data
{
    public class User_Registration
    {
        //IWebDriver driver;


        [SetUp]
        public void Initialize()
        {

           // ExcelUtil util = new ExcelUtil();

            ExcelUtil.PopulateInCollection(@"D:\Test.xlsx");
           // string result = util.ReadData(1, "Firstname");


            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");

        }

        [Test, Order(1)]
        public void OpenWebsite()
        {
            Registration.Reg();
            Thread.Sleep(3000);
        }

        [TearDown]
        public void EndTest()
        {

            Driver.driver.Close();


            Driver.driver.Quit(); // This is require otherwise chromeexe will keep running in the background.


        }

    }
}