<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web_Parameter_StoredProcedure.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <h1>Parameterized Stored Procedure</h1>
            <br />
            <table style="margin-left:250px;">
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Country</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click"/>
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Select" OnClick="Button2_Click"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click"/>
                    </td>
                    <td>
                        <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click"/>
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="Id">
                <Columns>
                    <asp:BoundField  DataField="Id" HeaderText="Id" SortExpression ="Id" InsertVisible="False" ReadOnly="True"/>
                    <asp:BoundField  DataField="Name" HeaderText="Name" SortExpression ="Name"/>
                    <asp:BoundField  DataField="Age" HeaderText="Age" SortExpression ="Age"/>
                    <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                </Columns>
            </asp:GridView>
            
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SimpleStoredProcConnectionString %>" SelectCommand="SELECT * FROM [Info]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
