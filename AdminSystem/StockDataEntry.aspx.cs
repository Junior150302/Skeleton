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

}