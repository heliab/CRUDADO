using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

namespace CRUDADO
{
    public partial class listbooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(Database.ConnectionString);
                SqlDataAdapter da = new SqlDataAdapter("select * from TB_Books order by Title", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "TB_Books");
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
        }
    }
}