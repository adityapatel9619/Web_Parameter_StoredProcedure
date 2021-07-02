using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Web_Parameter_StoredProcedure
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

         protected void Button1_Click(object sender, EventArgs e)
         {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-39COJ7F\\SQLEXPRESS;Initial Catalog=SimpleStoredProc;Integrated Security=True");
            SqlCommand command = new SqlCommand("Proc_ParamWeb", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Action", "Insert");
            command.Parameters.AddWithValue("@Name", TextBox1.Text);
            command.Parameters.AddWithValue("@Age", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@Country", TextBox3.Text);
            connection.Open();
            command.ExecuteNonQuery();
            GridView1.Visible = true;
            GridView1.DataBind();
            connection.Close();
         }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-39COJ7F\\SQLEXPRESS;Initial Catalog=SimpleStoredProc;Integrated Security=True");
            SqlCommand command = new SqlCommand("Proc_ParamWeb", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            command.ExecuteNonQuery();
            GridView1.Visible = true;
            GridView1.DataBind();
            connection.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-39COJ7F\\SQLEXPRESS;Initial Catalog=SimpleStoredProc;Integrated Security=True");
            SqlCommand command = new SqlCommand("Proc_ParamWeb", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Action", "Update");
            command.Parameters.AddWithValue("@Name", TextBox1.Text);
            command.Parameters.AddWithValue("@Age", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@Country", TextBox3.Text);
            connection.Open();
            command.ExecuteNonQuery();
            GridView1.Visible = true;
            GridView1.DataBind();
            connection.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-39COJ7F\\SQLEXPRESS;Initial Catalog=SimpleStoredProc;Integrated Security=True");
            SqlCommand command = new SqlCommand("Proc_ParamWeb", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Action", "Delete");
            command.Parameters.AddWithValue("@Name", TextBox1.Text);
            command.Parameters.AddWithValue("@Age", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@Country", TextBox3.Text);
            connection.Open();
            command.ExecuteNonQuery();
            GridView1.Visible = true;
            GridView1.DataBind();
            connection.Close();
        }
    }
}