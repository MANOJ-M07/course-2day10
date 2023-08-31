using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RblGender.Items.Add("Male");
            RblGender.Items.Add("Female");

            CblHobbies.Items.Add("Cricket");
            CblHobbies.Items.Add("Reading");
            CblHobbies.Items.Add("Writing");
            CblHobbies.Items.Add("Blogs Vlogs");
            CblHobbies.Items.Add("Music");
            CblHobbies.Items.Add("Football");

            DdlCity.Items.Add("Delhi");
            DdlCity.Items.Add("Mumbai");
            DdlCity.Items.Add("Pune");
            DdlCity.Items.Add("Goa");
            DdlCity.Items.Add("Hyderabad");
            DdlCity.Items.Add("Noida");
            DdlCity.Items.Add("Other");
        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string hob = "";
            foreach (ListItem li in CblHobbies.Items)
            {
                if (li.Selected)
                {
                    hob += li.Text;
                }
            }
            lblInfo.Text = "User Details as follows";
            lblInfo.Text += "<br>Name: " + TxtName.Text;
            lblInfo.Text += "<br>Gender: " + RblGender.Text;
            lblInfo.Text += "<br> City: " + DdlCity.Text;
            lblInfo.Text += "<br> Hobbies " + hob;

        }
    }
}