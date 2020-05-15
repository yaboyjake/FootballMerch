using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootballMerch_Classes;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of ClsStock
        ClsStock AnStock = new ClsStock();
        //get the data from the session object
        AnStock = (ClsStock)Session["AnStock"];
        //display the stock number
        Response.Write(AnStock.ProductDescript);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of ClsStock
        ClsStock AnStock = new ClsStock();
        //capture the stock
        AnStock.StockNo = txtStockNo.Text;
        //store the stock number in the session object
        Session["AnStock"] = AnStock;
        //redirect to the viewer page
        Response.Redirect("StockNumberViewer.aspx");
    }
}

