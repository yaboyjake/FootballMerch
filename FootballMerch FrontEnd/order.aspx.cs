using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using FootballMerch_Classes;
using System.Web.UI.WebControls;

public partial class order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // clsOrder Order = new clsOrder();
        //Order = (clsOrder)Session["Order"];
        //Response.Write(Order.OrderID);

    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        clsOrder Order = new clsOrder();

        string CustomerID = txtCustomerID.Text;
        string ShippingAddress = txtShippingAddress.Text;
        string OrderDate = txtOrderDate.Text;

        string Error = "";

        Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
        if (Error == "")
        {
            Order.CustomerID = Convert.ToInt32(CustomerID);
            Order.ShippingAddress = ShippingAddress;
            Order.OrderDate = Convert.ToDateTime(OrderDate);
            Session["Order"] = Order;
            lblError.Text = "OrderSubmitted";
            Response.Write("orderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder Order = new clsOrder();
        Int32 OrderID;
        Boolean Found = true;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = Order.Find(OrderID);
        if (Found == true)
        {
            txtCustomerID.Text = Convert.ToString(Order.CustomerID);
            txtShippingAddress.Text = Convert.ToString(Order.ShippingAddress);
            txtOrderDate.Text = Convert.ToString(Order.OrderDate);
            chkShipped.Checked = Order.OrderShipped;
            
        }
    }

    
}