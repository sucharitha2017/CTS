using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class Webform : System.Web.UI.Page
    {
       // private RepTr r = new RepTr();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buttonsp(object sender, EventArgs e)
        {
            RepTr r = new RepTr();
            r.tid = int.Parse(tidp.Text);

            TraineeDataLayer tdl = new TraineeDataLayer();
            var l = tdl.GetparData(r);

            GridView2.DataSource = l;
            GridView2.DataBind();
        }
    }
}