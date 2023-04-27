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

    }
}
