using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AGame = new clsStock();
        //get data from the session object
        AGame = (clsStock)Session["AGame"];
        //display the game number for this entry 
        Response.Write("Game No: " + AGame.GameNo.ToString() + "<br>");
        //display the game name for this entry
        Response.Write("Game Name: " + AGame.GameName + "<br>");
        //display the game description for this entry
        Response.Write("Game Description: " + AGame.GameDescription + "<br/>");
        //display the date released for this entry
        Response.Write("Date Released: " + AGame.DateReleased.ToString("dd/MM/yyyy") + "<br/>");
        //display the price for this entry
        Response.Write("Price: " + AGame.Price.ToString("C") + "<br/>");
        //display the available quantity for this entry
        Response.Write("Available: " + AGame.Available.ToString() + "<br/>");
    }
    
}