using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormXML
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLerXML_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds.ReadXml(Server.MapPath("~/Dados/ListaProdutos.xml"));

            gv.DataSource = ds.Tables[0];

            gv.DataBind();
        }
    }
}