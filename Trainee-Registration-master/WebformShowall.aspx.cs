using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class WebformShowall : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buttonsh(object sender, EventArgs e)
        {
            TraineeDataLayer tdl = new TraineeDataLayer();
            var t = tdl.GetData();
            GridView1.DataSource = t;
            GridView1.DataBind();
            
        }
    }
}