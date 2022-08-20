using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace ActionsClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ActionMoveElement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);
            //actions.MoveToElement(driver.FindElement(By.Id("div2")));

            actions.MoveToElement(driver.FindElement(By.Id("div2")), 20, 20);

            actions.ContextClick();

            actions.Build();
            actions.Perform();



        }


        [TestMethod]
        public void ActionClick()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            Thread.Sleep(5000);
            Actions actions = new Actions(driver);
            // IWebElement Clickme= driver.FindElement(By.Name("click"));
            // actions.MoveToElement(Clickme);

            //

            actions.Click(driver.FindElement(By.Name("click"))); // with parameters
            actions.Build();
            actions.Perform();
            Thread.Sleep(16000);
            driver.Quit();









        }
        [TestMethod]
        public void ActionDoubleClick()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/test/simple_context_menu.html";
            //Thread.Sleep(5000);
            Actions actions = new Actions(driver);
            // IWebElement Clickme= driver.FindElement(By.Name("click"));
            // actions.MoveToElement(Clickme);

            //

            actions.DoubleClick(driver.FindElement(By.CssSelector("#authentication > button"))); // with parameters
            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsClickAndholdRelease()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);


            //  actions.MoveToElement(driver.FindElement(By.Name("one"))); // without parameters
            //  actions.ClickAndHold();
            //  actions.MoveToElement(driver.FindElement(By.Name("twelve")));
            actions.ClickAndHold(driver.FindElement(By.Name("one")));//with parameters
            actions.MoveToElement(driver.FindElement(By.Name("twelve")));
            actions.Release();
            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsClickContext()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);


            actions.MoveToElement(driver.FindElement(By.Name("four"))); // without parameters

            actions.ContextClick(driver.FindElement(By.Name("four")));


            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsMoveByOffset()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);

            actions.MoveByOffset(200, 200);
            actions.ContextClick();




            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsDragandDrop()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);

            IWebElement drag = driver.FindElement(By.Id("draggable"));
            IWebElement drop = driver.FindElement(By.Id("droppable"));


            actions.DragAndDrop(drag, drop);




            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsDragandDropOffset()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);

            IWebElement drag = driver.FindElement(By.Id("draggable"));
            //IWebElement drop = driver.FindElement(By.Id("droppable"));


            actions.DragAndDropToOffset(drag, 150, 20);




            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsKeyDownKeyUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);

            actions.KeyDown(Keys.Control);

            actions.KeyDown(Keys.Control).Click(driver.FindElement(By.Name("one")));
            actions.KeyDown(Keys.Control).Click(driver.FindElement(By.Name("six")));
            actions.KeyDown(Keys.Control).Click(driver.FindElement(By.Name("eleven")));
            actions.KeyUp(Keys.Control);





            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsSendKeys()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);

            actions.SendKeys(Keys.End);
            actions.Perform();
            Thread.Sleep(2000);
            actions.SendKeys(Keys.Home);
            actions.Perform();


            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsCleartextwithoutClear()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/";

            Actions actions = new Actions(driver);

            driver.FindElement(By.Name("emailid")).SendKeys("test@test.com");


            Thread.Sleep(2000);

            actions.Click(driver.FindElement(By.Name("emailid")))
                .KeyDown(Keys.Control)
                .SendKeys("a")
            .KeyUp(Keys.Control)
            .SendKeys(Keys.Backspace)
            .Build();


            actions.Perform();
            Thread.Sleep(2000);

            driver.Quit();
        }
        [TestMethod]
        public void ThreadWaitimplicit()
        {


            //WebDriverManager.
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.ebay.com.au/";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);

           IWebElement element = driver.FindElement(By.XPath("//*[@id=\"mainContent\"]/ div[1]/ul/li[3]/a"));

           Actions action=new Actions(driver);
            action.MoveToElement(element).Perform();
            //Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"mainContent\"]/ div[1]/ul/li[3]/div[2]/div[1]/nav[2]/ul/li[1]/a")).Click();
            //driver.Quit();


        }
        
            
        
    }


}






      