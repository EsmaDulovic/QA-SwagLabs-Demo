using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using OpenQA.Selenium.Interactions;
using System.Net;
using System.Net.Mail;

namespace EsmaTest
{
    public class SwagLabsShopping
    {

        public static string YourCart()
        {
            
            {
                string message = "",
                      SwagLabsMessage = "";

                try
                {
                    var google = Driver.Instance.FindElement(By.Name("q"));
                    google.Click();
                    google.SendKeys("Swag Labs sauce demo");
                    google.SendKeys(Keys.Enter);

                    var SwagLabsWeb = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div:nth-child(1) .UK95Uc.jGGQ5e"));
                    SwagLabsWeb.Click();

                    var UserName = Driver.Instance.FindElement(By.Id("user-name"));
                    UserName.Click();
                    UserName.SendKeys("standard_user");

                    var Password = Driver.Instance.FindElement(By.Id("password"));
                    Password.Click();
                    Password.SendKeys("secret_sauce");

                    var LoginButton = Driver.Instance.FindElement(By.ClassName("btn_action"));
                    LoginButton.Click();




                    var ProductSort = Driver.Instance.FindElement(By.ClassName("product_sort_container"));
                    ProductSort.Click();

                    var LowToHigh = Driver.Instance.FindElement(By.CssSelector("#inventory_filter_container select :nth-child(3)"));
                    LowToHigh.Click();

                    var FleeceJacket = Driver.Instance.FindElement(By.CssSelector("#item_5_title_link div"));
                    FleeceJacket.Click();
                    Thread.Sleep(2000);
                    var FleeceAddCart = Driver.Instance.FindElement(By.CssSelector("#inventory_item_container > div > div > div > button"));
                    FleeceAddCart.Click();
                    Thread.Sleep(2000);
                    var BackButton = Driver.Instance.FindElement(By.CssSelector("#inventory_item_container > div > button"));
                    BackButton.Click();
                    Thread.Sleep(2000);

                    var BackPacks = Driver.Instance.FindElement(By.CssSelector("#inventory_container > div >:nth-child(1) .pricebar button"));
                    BackPacks.Click();
                    Thread.Sleep(2000);
                    var BikeLight = Driver.Instance.FindElement(By.CssSelector("#inventory_container :nth-child(2) >.pricebar button"));
                    BikeLight.Click();
                    Thread.Sleep(2000);
                    var Tshirt = Driver.Instance.FindElement(By.CssSelector("#inventory_container :nth-child(3) .pricebar button"));
                    Tshirt.Click();
                    Thread.Sleep(2000);
                    var Onesie = Driver.Instance.FindElement(By.CssSelector("#inventory_container > div > div:nth-child(5) > div.pricebar > button"));
                    Onesie.Click();
                    Thread.Sleep(2000);
                    var RedShirt = Driver.Instance.FindElement(By.CssSelector("#inventory_container :nth-child(6) .pricebar button"));
                    RedShirt.Click();
                    Functions.TakeScreenshot();

                    var ShoppingCart = Driver.Instance.FindElement(By.CssSelector("#shopping_cart_container > a > svg"));
                    ShoppingCart.Click();
                    Thread.Sleep(2000);
                    var FleeceInCart = Driver.Instance.FindElement(By.CssSelector("#cart_contents_container .cart_list :nth-child(3) .cart_item_label .item_pricebar button"));
                    FleeceInCart.Click();
                    Thread.Sleep(2000);
                    var OnesieInCart = Driver.Instance.FindElement(By.CssSelector("#cart_contents_container .cart_list :nth-child(7) .cart_item_label .item_pricebar button"));
                    OnesieInCart.Click();
                    Thread.Sleep(2000);

                    var ContinueShoppingButton = Driver.Instance.FindElement(By.CssSelector("#cart_contents_container .cart_footer .btn_secondary"));
                    ContinueShoppingButton.Click();
                    var OnesieAgain = Driver.Instance.FindElement(By.CssSelector("#inventory_container > div > div:nth-child(5) > div.pricebar > button"));
                    OnesieAgain.Click();
                    Thread.Sleep(2000);
                    var ShoppingCartAgain = Driver.Instance.FindElement(By.CssSelector("#shopping_cart_container > a > svg"));
                    ShoppingCartAgain.Click();
                    var CheckOut = Driver.Instance.FindElement(By.CssSelector("#cart_contents_container > div > div.cart_footer > a.btn_action.checkout_button"));
                    CheckOut.Click();
                    Functions.TakeScreenshot();

                    var Name = Driver.Instance.FindElement(By.Id("first-name"));
                    Name.Click();
                    Name.SendKeys("Esma");
                    var LastName = Driver.Instance.FindElement(By.Id("last-name"));
                    LastName.Click();
                    LastName.SendKeys("Dulovic");
                    var PostCode = Driver.Instance.FindElement(By.Id("postal-code"));
                    PostCode.Click();
                    PostCode.SendKeys("71000");
                    var ContiniueButton = Driver.Instance.FindElement(By.CssSelector("#checkout_info_container > div > form > div.checkout_buttons > input"));
                    ContiniueButton.Click();
                    var CancelButton = Driver.Instance.FindElement(By.CssSelector("#checkout_summary_container .summary_info .cart_footer .btn_secondary"));
                    CancelButton.Click();


                    var ShoppingCartFinal = Driver.Instance.FindElement(By.CssSelector("#shopping_cart_container > a > svg > path"));
                    ShoppingCartFinal.Click();
                    var CheckOutFinal = Driver.Instance.FindElement(By.CssSelector("#cart_contents_container > div > div.cart_footer > a.btn_action.checkout_button"));
                    CheckOutFinal.Click();
                    var NameFinal = Driver.Instance.FindElement(By.Id("first-name"));
                    NameFinal.Click();
                    NameFinal.SendKeys("Esma");
                    var LastNameFinal = Driver.Instance.FindElement(By.Id("last-name"));
                    LastNameFinal.Click();
                    LastNameFinal.SendKeys("Dulovic");
                    var PostCodeFinal = Driver.Instance.FindElement(By.Id("postal-code"));
                    PostCodeFinal.Click();
                    PostCodeFinal.SendKeys("71000");
                    //Functions.Screenshot();

                    var ContiniueButtonFinal = Driver.Instance.FindElement(By.CssSelector("#checkout_info_container > div > form > div.checkout_buttons > input"));
                    ContiniueButtonFinal.Click();
                    var FinishButton = Driver.Instance.FindElement(By.CssSelector("#checkout_summary_container .summary_info .cart_footer .cart_button"));
                    FinishButton.Click();
                    //Functions.Screenshot();

                    Functions.SendEmailNotification("Test Result", "The test was successful.");




                }

                catch (Exception e)
                {
                    message += "ERROR!" + e.Message;
                }

                message += SwagLabsMessage;

                return message;

            }


        }
    }
}

