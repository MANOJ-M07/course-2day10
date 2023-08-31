using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblInfo.Visible = false;
            }
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo.Text = "Registration Success!!!";
            lblInfo.Text += "<br/>Name: " + TxtName.Text;
            lblInfo.Text += "<br/>Password: " + TxtPwd.Text;
            lblInfo.Text += "<br/>Confirm Password: " + TxtCPwd.Text;
            lblInfo.Text += "<br/>Email: " + TxtEmail.Text;
            lblInfo.Text += "<br/>PinCode: " + TxtPinCode.Text;
            lblInfo.Text += "<br/>Age: " + TxtAge.Text;
            lblInfo.Text += "<br/>Date of Joining: " + CalDOJ.SelectedDate;
        }
    }
}