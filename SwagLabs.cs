using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EsmaTest
{
    [TestClass]
    public class SwagLabs
    {
        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
        }
        [TestMethod]
        public void TestMethod1()
        {
            string subject = "",
                    body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            SwagLabsLogIn.ValidLogIn();
            string SwagLabsLogInMessage = SwagLabsLogIn.ValidLogIn();

            //SwagLabsWrongLogIn.InvalidLogIn();
            //string SwagLabsLogInMessage = SwagLabsWrongLogIn.InvalidLogIn();


            if (!SwagLabsLogInMessage.Contains("ERROR"))
            {
                subject = "Passed" + subject;
                body = "Test je prošao" + "\n" + SwagLabsLogInMessage;
                Console.WriteLine("Subject: " + subject);
                Console.WriteLine("Body: " + body);
            }
            else
            {
                subject = "Epic sadface: Username and password do not match any user in this service" + subject;
                body = SwagLabsLogInMessage;
                Console.WriteLine("Subject: " + subject);
                Console.WriteLine("Body: " + body);
            }

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}