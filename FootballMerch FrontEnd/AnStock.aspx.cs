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
        ClsStock AnStock = new ClsStock();
        //capture the Product ID
        AnStock.ProductNo = txtProductNo.Text;
        //capture the product description
        AnStock.ProductDescript = txtProductDescript.Text;
        //capture the price of the product
        AnStock.Cost = txtCost.Text;
        //capture the date the product was added
        AnStock.DateAdded = txtDateAdded.Text;
        //capture the stock number
        AnStock.StockNo = txtStockNo.Text;
        //capture the stock check
        AnStock.InStck = txtInStck.Text;
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


    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}