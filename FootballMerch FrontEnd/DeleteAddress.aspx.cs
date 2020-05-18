using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootballMerch_Classes;


public partial class DeleteAddress : System.Web.UI.Page
{
    //var to store the priamry key value of the record to be deleted
    Int32 ProductNo;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the product ID to be deleted from the session object
        ProductNo = Convert.ToInt32(Session["ProductNo"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the stock book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to delete
        StockBook.ThisStock.Find(ProductNo);
        //delete the record
        StockBook.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}