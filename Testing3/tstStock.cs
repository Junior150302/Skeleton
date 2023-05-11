using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
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







    }
}
