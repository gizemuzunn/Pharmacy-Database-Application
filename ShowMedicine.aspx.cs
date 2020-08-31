using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class ShowMedicine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-PQ6KTMRS\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");

    private void LoadAuthorsGrid1(String mname)
    {
        try
        {
            cnn.Open();
            string query = "select mCode,mName,mCompanyName,mPrice,prUsageArea,prRepercussion,prStorageCondition,prSpacies,prColor from Medicine,Prospectus WHERE Medicine.mPrCode=Prospectus.prCode AND mName='" + mname + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView2.DataSource = dr;
            GridView2.DataBind();
            lblRecorCount.Text = query;

        }
        finally
        {
            cnn.Close();
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String mname = TextBox2.Text;
        LoadAuthorsGrid1(mname);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("DataProje.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        cnn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cnn;
        cmd.CommandText = "DELETE FROM Medicine WHERE mCode='" + Convert.ToInt32(TextBox2.Text) + "'";
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cnn.Close();
        lblRecorCount.Text = "Medicine removed from database succesfully";
    }
}