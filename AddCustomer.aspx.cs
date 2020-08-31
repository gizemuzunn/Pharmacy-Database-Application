using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AddCustomer : System.Web.UI.Page
{
    SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-PQ6KTMRS\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("", ""));
            DropDownList1.Items.Add(new ListItem("101", "101"));
            DropDownList1.Items.Add(new ListItem("102", "102"));
            DropDownList1.Items.Add(new ListItem("103", "103"));
            DropDownList1.Items.Add(new ListItem("104", "104"));
            DropDownList1.Items.Add(new ListItem("105", "105"));
            DropDownList1.Items.Add(new ListItem("106", "106"));
            DropDownList1.Items.Add(new ListItem("107", "107"));
            DropDownList1.Items.Add(new ListItem("108", "108"));
            DropDownList1.Items.Add(new ListItem("109", "109"));
            DropDownList1.Items.Add(new ListItem("110", "110"));
            DropDownList1.Items.Add(new ListItem("111", "111"));
            DropDownList1.Items.Add(new ListItem("112", "112"));
            DropDownList1.Items.Add(new ListItem("113", "113"));
            DropDownList1.Items.Add(new ListItem("114", "114"));
            DropDownList1.Items.Add(new ListItem("115", "115"));
            DropDownList1.Items.Add(new ListItem("116", "116"));
            DropDownList1.Items.Add(new ListItem("117", "117"));
            DropDownList1.Items.Add(new ListItem("118", "118"));
            DropDownList1.Items.Add(new ListItem("119", "119"));
            DropDownList1.Items.Add(new ListItem("120", "120"));

            DropDownList2.Items.Add(new ListItem("", ""));
            DropDownList2.Items.Add(new ListItem("909", "909"));
            DropDownList2.Items.Add(new ListItem("908", "908"));
            DropDownList2.Items.Add(new ListItem("907", "907"));
            DropDownList2.Items.Add(new ListItem("906", "906"));
            DropDownList2.Items.Add(new ListItem("905", "905"));
            DropDownList2.Items.Add(new ListItem("904", "904"));

        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        baglanti.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;
 
        cmd.CommandText = "INSERT INTO Customers(cSSN,cName,cLastName,cGender,cBDate,cPhoneNumber,cAddress,cMedicineID,cSellerID) VALUES ('" 
            + txtSSN.Text + "','" + txtname.Text + "','" + txtlastname.Text + "','" + txtgender.Text + "','" + txtbirth.Text + "','"+ txtnumber.Text+"','"+txtadress.Text+"','"
            + Convert.ToInt32(DropDownList1.SelectedValue) + "','" + Convert.ToInt32(DropDownList2.SelectedValue) + " ')";
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
        cmd.CommandText = "UPDATE Customers SET cName='" + txtname.Text + "',cLastName='" + txtlastname.Text + "',cGender='" + txtgender.Text + "',cBDate='" + txtbirth.Text+ "',cPhoneNumber='" + txtnumber.Text + "',cAddress='" + txtadress.Text + "',cMedicineID=" + Convert.ToInt32(DropDownList1.SelectedValue) + ",cSellerID=" + Convert.ToInt32(DropDownList2.SelectedValue) + " WHERE cSSN='"+txtSSN.Text+"'";
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        baglanti.Close();

        Label1.Text = "Datas are updated successfully ! ";

    }
}