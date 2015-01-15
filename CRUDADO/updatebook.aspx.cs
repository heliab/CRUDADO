using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDADO
{
    public partial class updatebook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGetDetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from TB_Books where IdBook = @bookid", con);
                cmd.Parameters.AddWithValue("@bookid", txtBookid.Text);
                //Thye data reader is only present in Select, due its function is to read and the we can display those readen values
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // display data in textboxes
                    txtTitle.Text = dr["Title"].ToString();
                    txtAuthors.Text = dr["Authors"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                    txtPublisher.Text = dr["Publisher"].ToString();
                    btnUpdate.Enabled = true;
                }
                else
                {
                    lblMsg.Text = "Sorry! Invalid Book Id";
                    btnUpdate.Enabled = false;
                }
                dr.Close();
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
        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Database.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update TB_Books set Title=@title, Authors = @authors, Price = @price, Publisher = @publisher where IdBook = @bookid", con);
                cmd.Parameters.AddWithValue("@bookid", txtBookid.Text);
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@authors", txtAuthors.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    lblMsg.Text = "Updated Successfully!";
                }
                else
                {
                    lblMsg.Text = "Sorry! Could not update";
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