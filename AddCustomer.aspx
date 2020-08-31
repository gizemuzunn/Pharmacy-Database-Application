<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCustomer.aspx.cs" Inherits="AddCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Query</title>
    <link href="StyleSheet.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron" id="div">
                <h1 class="display-4">
                    <asp:Image ID="Image1" runat="server" CssClass="image1" src="logo.jpg" Height="132px" Width="135px" />
                    Pharmacy Database Application</h1>
            </div>

            <div class="jumbotron" id="div2">
                <h5 class="card-header">Please Choose To Make An Option</h5>
                </br>

                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group-text">SSN&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                    </div>
                    <asp:TextBox ID="txtSSN" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
                </br>
                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group-text">First & Last Name&nbsp;&nbsp;&nbsp;&nbsp;</span>
                    </div>
                    <asp:TextBox ID="txtname" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtlastname" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                </br>
                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group-text">Gender & Birth Date</span>
                    </div>
                    <asp:TextBox ID="txtgender" CssClass="form-control" runat="server" placeholder="(W)omen/(M)an" ></asp:TextBox>
                    <asp:TextBox ID="txtbirth" CssClass="form-control" runat="server" placeholder="YYYY-MM-DD"></asp:TextBox>
                </div>
                </br>
                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group-text">Number & Adress&nbsp;&nbsp;&nbsp;&nbsp;</span>
                    </div>
                    <asp:TextBox ID="txtnumber" CssClass="form-control" runat="server" placeholder="0(---)-------" ></asp:TextBox>
                    <asp:TextBox ID="txtadress" CssClass="form-control" runat="server" placeholder="Town"></asp:TextBox>
                </div>
                </br>
                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group-text">Medicine ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                    </div>
                    
                    <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
                </br>
                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group-text">Seller ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                    </div>
                   
                    <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
                </br>
                <asp:Button ID="Button1" CssClass="btn btn-primary btn-lg" runat="server" Text="Add" OnClick="Button1_Click" />&nbsp;&nbsp;
                <asp:Button ID="Button3" CssClass="btn btn-primary btn-lg" runat="server" Text="Update" OnClick="Button3_Click" />&nbsp;&nbsp;
                <asp:Button ID="Button2" CssClass="btn btn-secondary btn-lg" runat="server" Text="Back" OnClick="Button2_Click" />




            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server"></asp:Label>




            </div>


        </div>
    </form>
</body>
</html>
