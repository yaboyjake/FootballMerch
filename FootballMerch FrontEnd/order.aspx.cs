using System;
using System.Collections.Generic;
using System.Linq;
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
        Order.OrderID = txtOrderID.Text;
        Session["Order"] = Order;
        Response.Redirect("OrderViewer.aspx");
    }
}