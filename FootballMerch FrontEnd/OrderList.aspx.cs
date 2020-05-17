using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        FootballMerch_Classes.clsOrderCollection Orders = new FootballMerch_Classes.clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "CustomerID";
        lstOrderList.DataBind();

    }
    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}