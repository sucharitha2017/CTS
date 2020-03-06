using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class WebformEnterData : System.Web.UI.Page
    {
        private RepTr r = new RepTr();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonIns(object sender, EventArgs e)
        {
            r.tid = Convert.ToInt32(tid.Text);
            r.tname = name.Text;
            r.location = DropDownList1.SelectedItem.Value;
            r.techdomain = DropDownList2.SelectedItem.Value;
            r.startdate = Calendar1.SelectedDate;

            TraineeDataLayer tdl = new TraineeDataLayer();
            tdl.Insert(r);
            val.Text = "Inserted Successfully";
        }
    }
}