using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class WebformEdit : System.Web.UI.Page
    {
        //private RepTr r = new RepTr();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buttonupd1(object sender, EventArgs e)
        {
            RepTr r = new RepTr();
            r.tid = int.Parse(tidu.Text);
            r.tname = nameu.Text;

            TraineeDataLayer tdl = new TraineeDataLayer();
            tdl.Update(r);
            temp.Text = "Updated Successfully";
        }
    }
}