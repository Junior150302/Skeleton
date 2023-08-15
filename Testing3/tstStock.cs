using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {

        //good test data
        //created some test data to pass to the method
        string GameNo = "1";
        string GameName = "Fifa 23";
        string GameDescription = "football game";
        string DateReleased = "29/09/2022";
        string Price = "49.99";
        string Available = "5";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AGame);
        }

        [TestMethod]
        public void GameNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AGame.GameNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AGame.GameNo, TestData);
        }

        [TestMethod]
        public void GameNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //create some test data
            string TestData = "Fifa 23";
            //assign the data to the property
            AGame.GameName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AGame.GameName, TestData);
        }

        [TestMethod]
        public void GameDecriptionOK()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //create some test data
            string TestData = "Description of game";
            //assign the data to the property
            AGame.GameDescription = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AGame.GameDescription, TestData);
        }

        [TestMethod]
        public void GamePicturePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //create some test data
            //Byte is used as images commonly use that data type
            Byte TestData = 1;
            //assign the data to the property
            AGame.GamePicture = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AGame.GamePicture, TestData);
        }

        [TestMethod]
        public void DataReleasedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AGame.DateReleased = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AGame.DateReleased, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //create some test data
            double TestData = 19.99;
            //assign the data to the property
            AGame.Price = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AGame.Price, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //create some test data
            Int32 TestData = 57;
            //assign the data to the property
            AGame.Available = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AGame.Available, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 GameNo = 1;
            //invoke the method
            Found = AGame.Find(GameNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestGameNoFound()
        {
            //create an instance of the class we want to create 
            clsStock AGame = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameNo = 1;
            //invoke the method
            Found = AGame.Find(GameNo);
            //check the game no
            if (AGame.GameNo != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestGameNameFound()
        {
            //create an instance of the class we want to create 
            clsStock AGame = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            Int32 GameNo = 1;
            //create some test data to use with the method
            String GameName = "Fifa 23";
            //invoke the method
            Found = AGame.Find(GameNo);
            //check the game name
            if (AGame.GameName != "Fifa 23")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestGameDescriptionFound()
        {
            //create an instance of the class we want to create 
            clsStock AGame = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            Int32 GameNo = 1;
            //create some test data to use with the method
            String GameDescription = "N/A";
            AGame.GameDescription = GameDescription;
            //invoke the method
            Found = AGame.Find(GameNo);
            //check the game description
            if (AGame.GameDescription != "N/A")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDateReleasedFound()
        {
            //create an instance of the class we want to create 
            clsStock AGame = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            Int32 GameNo = 1;
            //create some test data to use with the method
            DateTime TestDate = DateTime.Now.Date;
            AGame.DateReleased = TestDate;
            //invoke the method
            Found = AGame.Find(GameNo);
            //check the date released
            if (AGame.DateReleased != TestDate)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            // create an instance of the class we want to test
            clsStock AGame = new clsStock();
            // boolean variable to store the results of the validation
            bool Found = false;
            // boolean variable to record if data is OK (assume it is)
            bool OK = true;
            Int32 GameNo = 1;
            // create some test data to use with the method
            double testPrice = 49.99;
            AGame.Price = testPrice;
            // invoke the method
            Found = AGame.Find(GameNo);
            // check the price
            if (AGame.Price != testPrice)
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            // Create an instance of the class we want to test
            clsStock AGame = new clsStock();
            // Boolean variable to store the results of the validation
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            Int32 GameNo = 1;
            // Create some test data to use with the method
            int TestAvailable = 14;
            AGame.Available = TestAvailable;
            // Invoke the method
            Found = AGame.Find(GameNo);
            // Check the Available property
            if (AGame.Available != TestAvailable)
            {
                OK = false;
            }
            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            ///create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            string GameDescription = null;
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNoMinLessOne()
        {
            // create an instance of the class we want to create 
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameNo = ""; //this should trigger an error
            string GameName = "Fifa 23"; // use your defined test data
            string GameDescription = null;
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameNoMinMinusOne()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameNo = "-1"; // this should not work
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNoMin()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameNo = "1"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameNo = "2"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameNoMid()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameNo = "500"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNameMinExtreme()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameName = "A"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameNameMinMinusOne()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameName = ""; // this should fail
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GameNameMin()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameName = "A"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameName = "Aa"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameNameMid()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameName = "Call Of Duty Modern Warfare"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameNameOthers()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameName = "Fifa 23"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameDescriptionMinExtreme()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameDescription = "Football12"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameDescriptionMinMinusOne()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameDescription = "abcdefghi"; // this should not work
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameDescriptionMin()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameDescription = "Latest Game"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameDescription = "Latest Games"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameDescriptionMid()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameDescription = "This is the latest football game that has arrived on the market"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameDescriptionOthers()
        {
            //create an instance of the class we want to create
            clsStock AGame = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string GameDescription = "Fifa 23 the latest football game that has arrived age ratin 3+"; // this should be ok
            //invoke the method
            Error = AGame.Valid(GameNo, GameName, GameDescription, DateReleased, Price, Available);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
    }
}
