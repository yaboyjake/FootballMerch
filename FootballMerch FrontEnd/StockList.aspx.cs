﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootballMerch_Classes;

public partial class StockList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        //create an instance of the County Collection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to the list of counties in the collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductNo";
        //set the data field to display
        lstStockList.DataTextField = "ProductDescript";
        //bind the data to the list
        lstStockList.DataBind();
    }

    //event handler for the add button
    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ProductNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnStock.aspx");
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key of the record to be deleted
        Int32 ProductNo;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ProductNo = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ProductNo"] = ProductNo;
            //redirect to the delete page
            Response.Redirect("DeleteStock.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key of the record to be deleted
        Int32 ProductNo;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductNo = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ProductNo"] = ProductNo;
            //redirect to the edit page
            Response.Redirect("AnStock.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void ButtonApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByProductDescript(txtFilter.Text);
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "ProductNo";
        lstStockList.DataTextField = "ProductDescript";
        lstStockList.DataBind();
    }

    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByProductDescript("");
        txtFilter.Text = "";
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "ProductNo";
        lstStockList.DataTextField = "ProductDescript";
        lstStockList.DataBind();
    }
}