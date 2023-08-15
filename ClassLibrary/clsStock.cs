using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the game number property
        private Int32 mGameNo;
        public bool Active { get; set; }
        public Int32 GameNo
        {
            get
            {
                //this line of code sends data out the property
                return mGameNo;
            }
            set
            {
                //this line of code allows data into the property
                mGameNo = value;
            }
        }
        //private data member for the game name property
        private string mGameName;
        public string GameName
        {
            get
            {
                //this line of code sends data out the property
                return mGameName;
            }
            set
            {
                //this line of code allows data into the property
                mGameName = value;
            }
        }
        private string mGameDescription;
        public string GameDescription
        {
            get
            {
                //this line of code send data out the property
                return mGameDescription;
            }
            set
            {
                //this line of code allows data into the property
                mGameDescription = value;
            }
        }
        private byte mGamePicture;
        public byte GamePicture
        {
            get
            {
                //this line of code sends data out the property
                return mGamePicture;
            }
            set
            {
                //this line of code allows data into the property
                mGamePicture = value;
            }
        }
        private DateTime mDateReleased;
        public DateTime DateReleased
        {
            get
            {
                //this line of code sends data out the property
                return mDateReleased;
            }
            set
            {
                //this line of code allows data into the property
                mDateReleased = value;
            }
        }
        private double mPrice;
        public double Price
        {
            get
            {
                //this line of code sends data out the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }
        private int mAvailable;
        public int Available
        {
            get
            {
                //this line of code sends data out the property
                return mAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mAvailable = value;
            }
        }

        public bool Find(int GameNo)
        {
            //create an instane of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the game number to search for
            DB.AddParameter("@GameNo", GameNo);
            //execute the stored procedure
            DB.Execute("sproc_tblGame_FilterByGameNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private members
                mGameNo = Convert.ToInt32(DB.DataTable.Rows[0]["GameNo"]);
                mGameName = Convert.ToString(DB.DataTable.Rows[0]["GameName"]);
                mGameDescription = Convert.ToString(DB.DataTable.Rows[0]["GameDescription"]);
                mDateReleased = Convert.ToDateTime(DB.DataTable.Rows[0]["DateRelased"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToInt32(DB.DataTable.Rows[0]["Avaialble"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string gameNo, string gameName, string gameDescription, string dateReleased, string price, string avialble)
        {
            //create a string variable to store the error
            String Error = "";
            // if the GameNo is blank
            if (gameNo.Length == 0)
            {
                //record the error
                Error = Error + "The game no may not be blank : ";
            }
            //if the GameName is blank
            if (gameName.Length == 0)
            {
                //record the error
                Error = Error + "The game name may not be blank : ";
            }
            //return any error messages
            return Error;
        }
    }
}