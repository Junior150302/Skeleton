using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AGame = new clsStock();
        //capture the game number
        AGame.GameNo = Int32.Parse(txtGameNo.Text);
        //capture the game name
        AGame.GameName = txtGameName.Text;
        //capture the game description
        AGame.GameDescription = txtGameDescription.Text;
        //store the name in the session object
        //capture the date released
        AGame.DateReleased = DateTime.Parse(txtDateReleased.Text);
        //capture the price
        AGame.Price = double.Parse(txtPrice.Text);
        //capture the available quantity
        AGame.Available = int.Parse(txtAvailable.Text);
        Session["AGame"] = AGame;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStock AGame = new clsStock();
        //variable to store the primary key
        Int32 GameNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        GameNo = Convert.ToInt32(txtGameNo.Text);
        //find the record
        Found = AGame.Find(GameNo);
        //if found 
        if (Found == true)
        {
            //display the value of properties in the form
            txtGameNo.Text = AGame.GameNo.ToString();
            txtGameName.Text = AGame.GameName;
            txtGameDescription.Text = AGame.GameDescription;
            txtGamePicture.Text = AGame.GamePicture.ToString();
            txtDateReleased.Text = AGame.DateReleased.ToString();
            txtPrice.Text = AGame.Price.ToString();
            txtAvailable.Text = AGame.Available.ToString();

        }
    }
}