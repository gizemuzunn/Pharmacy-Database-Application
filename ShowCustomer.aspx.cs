using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-PQ6KTMRS\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");

    private void LoadAuthorsGrid(String ssn)
    {
        try
        {
            cnn.Open();
            string query = "Select cSSN,cName,cLastName,cGender,cBDate,cPhoneNumber,cAddress,mName,eFName From Customers,Medicine,Employees WHERE Customers.cMedicineID=Medicine.mCode AND Customers.cSellerID=Employees.eID AND cSSN='" + ssn + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);

            SqlDataReader dr = cmd.ExecuteReader();

            GridView1.DataSource = dr;
            GridView1.DataBind();

            lblRecorCount.Text = query;
        }
        finally
        {
            cnn.Close();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String ssn = TextBox1.Text;
        LoadAuthorsGrid(ssn);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("DataProje.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        cnn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cnn;
        cmd.CommandText = "DELETE FROM Customers WHERE cSSN='"+TextBox1.Text+"'";
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cnn.Close();
        lblRecorCount.Text = "Customer removed from database succesfully";

    }
}