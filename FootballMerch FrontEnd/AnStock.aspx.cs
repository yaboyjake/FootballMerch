using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootballMerch_Classes;



public partial class AnStock : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ProductNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the product ID to be processed
        ProductNo = Convert.ToInt32(Session["ProductNo"]);
        if (IsPostBack == false)
        {
            //display the current data for the record
            if (ProductNo != -1)
            {
                //display the current data fpr the ercord 
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    { 
        //create an instance of the County Collection
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update
        StockBook.ThisStock.Find(ProductNo);
        //display the data for this record
        txtProductNo.Text = StockBook.ThisStock.ProductNo.ToString();
        txtProductDescript.Text = StockBook.ThisStock.ProductDescript();
        txtCost.Text = StockBook.ThisStock.Cost();
        txtStockNo.Text = StockBook.ThisStock.StockNo();
        chkInStck.Text = StockBook.ThisStock.Instck();
        txtDataeAdded.Text = StockBook.ThisStock.DateAdded.ToString();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ButtonOK_Click2(object sender, EventArgs e)
    {
        //create a new instance of ClsStock
        ClsStock AnStock = new ClsStock();
        //capture the product description
        string ProductDescript = txtProductDescript.Text;
        //capture the price of the product
        string Cost = txtCost.Text;
        //capture the date the product was added
        string DateAdded = txtDateAdded.Text;
        //capture the stock number
        string StockNo = txtStockNo.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
        if (Error == "")
        {
            //capture the product ID
            AnStock.StockNo = StockNo;
            //capture the produt description
            AnStock.ProductDescript = ProductDescript;
            //capture the cost
            AnStock.Cost = Cost;
            //capture the date the stock was added
            AnStock.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the stock quantity
            AnStock.StockNo = StockNo;
            //capture the in stock
            AnStock.InStck = chkInStck.Checked;
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();

            if (ProductNo == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AnStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an updte
            else
            {
                //find the record to update
                StockList.ThisStock.Find(ProductNo);
                //set the ThisStock property
                StockList.ThisStock = AnStock;
                //update the record
                StockList.Update();
            }
            //redirect to the viewer page
            Response.Write("StockNoViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
}