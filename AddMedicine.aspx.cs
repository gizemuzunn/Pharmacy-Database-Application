using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AddMedicine : System.Web.UI.Page
{
    SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-PQ6KTMRS\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        baglanti.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;

        cmd.CommandText = "INSERT INTO Medicine(mCode,mName,mCompanyName,mPrice,mPrCode) VALUES ('"
            + Convert.ToInt32(txtmcode.Text) + "','" + txtname.Text + "','" + txtcompany.Text + "','" +
            Convert.ToDouble(txtprice.Text) + "','" + Convert.ToInt32(txtpro.Text) + "')";
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        baglanti.Close();

        Label1.Text = "Datas are added successfully ! ";

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("DataProje.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        baglanti.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;
        cmd.CommandText = "UPDATE Medicine SET mName='" + txtname.Text + "',mCompanyName='" + txtcompany.Text + "',mPrice='" + Convert.ToInt32(txtprice.Text) + "',mPrCode='" + Convert.ToInt32(txtpro.Text) + "' WHERE mCode='" + Convert.ToInt32(txtmcode.Text) + "'";
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        baglanti.Close();

        Label1.Text = "Datas are updated successfully ! ";
    }
}