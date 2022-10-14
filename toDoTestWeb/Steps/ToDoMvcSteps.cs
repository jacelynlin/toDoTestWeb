using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace toDoTestWeb.Steps
{
    [Binding]
    public sealed class ToDoMvcSteps
    {
        string URL = "https://todomvc.com/examples/react";
        
        string itemName1 = "Task 1";

        IWebDriver driver;

        private readonly ScenarioContext context;

        public ToDoMvcSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I navigated to ToDoMvc")]
        public void GivenINavigatedToToDoMvc()
        {
            driver = new ChromeDriver();
            driver.Url = URL;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }
        
        [When(@"I add 10 tasks in the todo list")]
        public void WhenIEnteredFirstItemInTheTextbox()
        {
            IWebElement enterkey = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            
            IWebElement toDoTextBox = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            toDoTextBox.SendKeys("Task 1");
            enterkey.SendKeys(Keys.Return);

            IWebElement toDoTextBox2 = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            toDoTextBox2.SendKeys("Task 2");
            enterkey.SendKeys(Keys.Return);

            IWebElement toDoTextBox3 = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            toDoTextBox3.SendKeys("Task 3");
            enterkey.SendKeys(Keys.Return);

            IWebElement toDoTextBox4 = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            toDoTextBox4.SendKeys("Task 4");
            enterkey.SendKeys(Keys.Return);

            IWebElement toDoTextBox5 = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            toDoTextBox5.SendKeys("Task 5");
            enterkey.SendKeys(Keys.Return);

            IWebElement toDoTextBox6 = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            toDoTextBox6.SendKeys("Task 6");
            enterkey.SendKeys(Keys.Return);

            IWebElement toDoTextBox7 = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            toDoTextBox7.SendKeys("Task 7");
            enterkey.SendKeys(Keys.Return);

            IWebElement toDoTextBox8 = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            toDoTextBox8.SendKeys("Task 8");
            enterkey.SendKeys(Keys.Return);

            IWebElement toDoTextBox9 = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            toDoTextBox9.SendKeys("Task 9");
            enterkey.SendKeys(Keys.Return);

            IWebElement toDoTextBox10 = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            toDoTextBox10.SendKeys("Task 10");
            enterkey.SendKeys(Keys.Return);

        }

        [When(@"I click enter to add the task in the list")]
        public void WhenIClickEnterToAddTheTaskInTheList()
        {
            IWebElement toDoTextBox = driver.FindElement(By.XPath("//input[@class='new-todo']"));
            toDoTextBox.SendKeys(Keys.Return);
        }

        [Then(@"New task is added to ToDoMvc List")]
        public void ThenNewTaskIsAddedToToDoMvcList()
        {
            // Verified Added Item name
            IWebElement itemtext1 = driver.FindElement(By.XPath("/html/body/section/div/section/ul/li"));

            string getText1 = itemtext1.Text;

            // Check if the newly added item is present or not using
            // Condition constraint (Boolean)
            Assert.That((itemName1.Contains(getText1)), Is.True);

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"I select 5 tasks to mark as completed")]
        public void GivenISelectTasksToMarkAsCompleted()
        {
            IWebElement checkbox1 = driver.FindElement(By.XPath("//ul[@class='todo-list']//li[5]//div//input[@class='toggle']"));
            IWebElement checkbox2 = driver.FindElement(By.XPath("//ul[@class='todo-list']//li[3]//div//input[@class='toggle']"));
            IWebElement checkbox3 = driver.FindElement(By.XPath("//ul[@class='todo-list']//li[8]//div//input[@class='toggle']"));
            IWebElement checkbox4 = driver.FindElement(By.XPath("//ul[@class='todo-list']//li[9]//div//input[@class='toggle']"));
            IWebElement checkbox5 = driver.FindElement(By.XPath("//ul[@class='todo-list']//li[10]//div//input[@class='toggle']"));
            checkbox1.Click();
            checkbox2.Click();
            checkbox3.Click();
            checkbox4.Click();
            checkbox5.Click();

            System.Threading.Thread.Sleep(2000);
        }

        [When(@"I click on view completed")]
        public void WhenIClickOnViewCompleted()
        {
            IWebElement completedBtn = driver.FindElement(By.LinkText("Completed"));
            completedBtn.Click();

            System.Threading.Thread.Sleep(2000);
        }

        [When(@"I click on clear completed")]
        public void WhenIClickOnClearCompleted()
        {
            IWebElement clearCompletedBtn = driver.FindElement(By.XPath("//button[@class='clear-completed']"));
            clearCompletedBtn.Click();

            System.Threading.Thread.Sleep(2000);
        }

        [When(@"I click on view active")]
        public void WhenIClickOnViewActive()
        {
            IWebElement activeBtn = driver.FindElement(By.LinkText("Active"));
            activeBtn.Click();

            System.Threading.Thread.Sleep(2000);
        }


        [Then(@"close the browser instance")]
        public void ThenCloseTheBrowserInstance()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
