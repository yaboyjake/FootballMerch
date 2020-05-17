using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using FootballMerch_Classes;
using System.Web.UI.WebControls;

public partial class order : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrder();
            }
        }
        

    }

    void DisplayOrder()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ThisOrder.Find(OrderID);
        txtOrderID.Text = Orders.ThisOrder.OrderID.ToString();
        txtCustomerID.Text = Orders.ThisOrder.CustomerID.ToString();
        txtShippingAddress.Text = Orders.ThisOrder.ShippingAddress.ToString();
        txtOrderDate.Text = Orders.ThisOrder.OrderDate.ToString();
        chkShipped.Checked = Orders.ThisOrder.OrderShipped;


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
            clsOrderCollection Orders = new clsOrderCollection();
            //if adding a new order
            if (OrderID == -1)
            {
                Orders.ThisOrder = Order;
                Orders.Add();
            }
            //if updating an order
            else
            {
                Orders.ThisOrder.Find(OrderID);
                Orders.ThisOrder = Order;
                Orders.Update();
            }
            // Session["Order"] = Order;
            lblError.Text = "OrderSubmitted";
            Response.Redirect("orderList.aspx");
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