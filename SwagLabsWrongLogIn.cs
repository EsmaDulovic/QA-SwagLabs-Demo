using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace EsmaTest
{
    public class SwagLabsWrongLogIn
    {

        public static string InvalidLogIn()
        {
            var usernames = new List<string>
             {
                "Esma",
                "Esma Dulovic"
             };
            {
                string message = "",
                      SwagLabsLogInMessage = "";

                try
                {
                    var google = Driver.Instance.FindElement(By.Name("q"));
                    google.Click();
                    google.SendKeys("Swag Labs sauce demo");
                    google.SendKeys(Keys.Enter);

                    var SwagLabsWeb = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div:nth-child(1) .UK95Uc.jGGQ5e"));
                    SwagLabsWeb.Click();

                    Random random = new Random();
                    int index = random.Next(usernames.Count);
                    string username = usernames[index];

                    var UserName = Driver.Instance.FindElement(By.CssSelector("#user-name"));
                    UserName.Click();
                    UserName.SendKeys(username);

                    var Password = Driver.Instance.FindElement(By.CssSelector("#password"));
                    Password.Click();
                    Password.SendKeys("secret_sauce");

                    var LoginButton = Driver.Instance.FindElement(By.ClassName("btn_action"));
                    LoginButton.Click();

                    var errorMessage = Driver.Instance.FindElement(By.CssSelector("#login_button_container form h3"));
                    message = errorMessage.Text;

                }

                catch (Exception e)
                {
                    message += "ERROR!" + e.Message;
                }

                message += SwagLabsLogInMessage;

                return message;

            }


        }
    }
}

