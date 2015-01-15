using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDADO
{
    public partial class deletebook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from books where bookid = @bookid", con);
                cmd.Parameters.AddWithValue("@bookid", txtBookid.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    lblMsg.Text = "Book Deleted Successfully!";
                }
                else
                {
                    lblMsg.Text = "Sorry! Could Not Delete Book.";
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error --> " + ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

    }
}