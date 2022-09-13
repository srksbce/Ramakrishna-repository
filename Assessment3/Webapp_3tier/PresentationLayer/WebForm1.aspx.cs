using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string st = "select * from emp";
            EmpBusiness EB = new EmpBusiness();
            DataSet ds=new DataSet();
            ds=EB.GetData(st);
            GridView1.DataSource = ds;
            GridView1.DataBind();



        }
    }
}