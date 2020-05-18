using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootballMerch_Classes;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        //lstOrderList.DataTextField = "CustomerID";
        lstOrderList.DataTextField = "ShippingAddress";
        lstOrderList.DataBind();

    }
    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("order.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("deleteOrder.aspx");

        }
        else
        {
            //no record selected
            lblError.Text = "Please select a record to delete";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("order.aspx");

        }
        else
        {
            //no record selected
            lblError.Text = "Please select a record to edit";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByShippingAddress(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "ShippingAddress";
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByShippingAddress("");
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "ShippingAddress";
        lstOrderList.DataBind();
    }
}