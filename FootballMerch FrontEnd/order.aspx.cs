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
        clsOrder Order = new clsOrder();
        Order = (clsOrder)Session["Order"];
        Response.Write(Order.OrderID);

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder Order = new clsOrder();
        Order.OrderID = Int32.Parse(txtOrderID.Text);
        Order.CustomerID = Int32.Parse(txtCustomerID.Text);
        Order.ShippingAddress= txtShippingAddress.Text;
        Order.OrderShipped = chkShipped.Checked;
        Order.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        Session["Order"] = Order;
        Response.Redirect("OrderViewer.aspx");
        
    }
}