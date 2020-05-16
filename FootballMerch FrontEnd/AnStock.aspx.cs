using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootballMerch_Classes;


public partial class AnStock : System.Web.UI.Page
{
    private object txtStockNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of ClsStock 
        ClsStock AnStock = new ClsStock();
        //get the data from the session object
        AnStock = (ClsStock)Session["AnStock"];
        //display football merch
        Response.Write(AnStock.ProductDescript);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of ClsStock
        ClsStock AnStock = new ClsStock
        {
            //capture the stock
            StockNo = txtStockNo.Text
        };
        //store the stock number in the session object
        Session["AnStock"] = AnStock;
        //redirect to the viewer page
        Response.Redirect("StockNumberViewer.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        
    }

    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {

    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void ImageButton1_Click2(object sender, ImageClickEventArgs e)
    {

    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {

    }
}