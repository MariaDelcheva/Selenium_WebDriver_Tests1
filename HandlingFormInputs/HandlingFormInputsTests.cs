using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HandlingFormInputs
{
    public class HandlingFormInputsTests

    {
        WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://practice.bpbonline.com/");
        }

        public void TearDown()  
        {
            driver.Quit();
            driver.Dispose();
        }


        [Test]
        public void HandlingFormInputs()
        {
            // click in my account button

            driver.FindElements(By.XPath("//span[@class='ui-button-text']"))[2].Click();

            // click continue button 

            driver.FindElement(By.LinkText("Continue")).Click();

            // click male radio button 

            driver.FindElement(By.XPath("//input[@type='radio'][@value='m']")).Click();

            //fill value in  first name field 
            driver.FindElement(By.XPath("//input[@type='text'][@name='firstname']")).SendKeys("Maria");

            //fill value in  last name field 
            driver.FindElement(By.XPath("//input[@type='text'][@name='lastname']")).SendKeys("Delcheva");

            //fill value in date of birth field 

            driver.FindElement(By.XPath("//input[@type='text'][@name='dob']")).SendKeys("05/26/1990");


            // create unique email address

            Random random = new Random();   
            int randomNumber = random.Next(1000, 9999);

            string email = "Maria" + randomNumber.ToString() + "@gmail.com";

            // fill email field 
            driver.FindElement(By.XPath("//input[@type='text'][@name='email_address']")).SendKeys(email);



            // fill value in company name field

            driver.FindElement(By.XPath("//input[@type='text'][@name='company']")).SendKeys("Example company");


            // fill value in street address field

            driver.FindElement(By.XPath("//input[@type='text'][@name='street_address']")).SendKeys("Boulevard Vitosha 12");


            // fill value in Suburb field

            driver.FindElement(By.XPath("//input[@type='text'][@name='suburb']")).SendKeys("Sofia");

            // fill value in Post Code field

            driver.FindElement(By.XPath("//input[@type='text'][@name='postcode']")).SendKeys("1000");


            // fill value in City field

            driver.FindElement(By.XPath("//input[@type='text'][@name='city']")).SendKeys("Sofia");


            // fill value in State/Province field

            driver.FindElement(By.XPath("//input[@type='text'][@name='state']")).SendKeys("Sofia");


            // select from Country dropdown field

            new SelectElement(driver.FindElement(By.Name("country"))).SelectByText("Bulgaria");


            // fill value in Telephone Number field

            driver.FindElement(By.XPath("//input[@type='text'][@name='telephone']")).SendKeys("0884156341");


            // click checkbox Newsletter

            driver.FindElement(By.XPath("//input[@type='checkbox'][@name='newsletter']")).Click();


            // fill value in Password field

            driver.FindElement(By.XPath("//input[@type='password'][@name='password']")).SendKeys("123456");


            // fill value inPassword Confirmation field

            driver.FindElement(By.XPath("//input[@type='password'][@name='confirmation']")).SendKeys("123456");


            // click submit form (Continue button)  // 

            driver.FindElements(By.XPath("//span[@class='ui-button-icon-primary ui-icon ui-icon-person']//following-sibling::span"))[1].Click();


            //Assert message for success

            Assert.AreEqual(driver.FindElement(By.CssSelector("h1")).Text,"Your Account Has Been Created!");

            // click Log off  button 

            driver.FindElement(By.LinkText("Log Off")).Click();


            // click Continue  button

            driver.FindElement(By.LinkText("Continue")).Click();


            //Print message to the console

            Console.WriteLine($"User  Acount Created with email:{email}"); 

        }
    }
}