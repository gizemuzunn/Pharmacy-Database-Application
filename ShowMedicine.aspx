<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowMedicine.aspx.cs" Inherits="ShowMedicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Medicine</title>
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


            <div class="card text-center">
                <div class="card-body">

                    <div class="input-group mb-3">
                       
                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"  placeholder="Medicine Name"></asp:TextBox>
                        <div class="input-group-append">
                            <asp:Button ID="Button2" runat="server" Text="Show" CssClass="btn btn-outline-secondary" OnClick="Button2_Click" />
                            <asp:Button ID="Button1" CssClass="btn btn-info" runat="server" Text="Back" OnClick="Button1_Click" />
                            <asp:Button ID="Button3" CssClass="btn btn-danger" runat="server" Text="Delete" OnClick="Button3_Click" />
                        </div>
                    </div>

                    <asp:GridView ID="GridView2" runat="server" size="auto" CssClass="table table-bordered table-striped table-responsive">
                    </asp:GridView>
                </div>
                <div class="card-footer text-muted">
                    <asp:Label ID="lblRecorCount" runat="server" Text="0"></asp:Label>
                    
                </div>
                
            </div>
            

        </div>
    </form>
</body>
</html>
