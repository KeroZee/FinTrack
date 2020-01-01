<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Track.aspx.cs" Inherits="FinTrack.Track" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



    <form id="form1" runat="server" class="md-form">
        <table class="w-100">
            <tr>
                <td style="width: 183px">Description of Expense :</td>
                <td>    
                    <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 183px">Category :</td>
                <td>
                    <asp:DropDownList ID="ddlCat" class="browser-default custom-select ddl-custom" style="width:183px" runat="server">
                        <asp:ListItem Value="-1">-- Select --</asp:ListItem>
                        <asp:ListItem>Food</asp:ListItem>
                        <asp:ListItem>Transport</asp:ListItem>
                        <asp:ListItem>Miscellaneous</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 183px; height: 26px">Cost :</td>
                <td style="height: 26px">
                    <asp:TextBox ID="txtCost" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 183px; height: 26px"></td>
                <td style="height: 26px">
                    <asp:Label ID="lblError" runat="server" BackColor="White" BorderColor="Red" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 183px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 183px">&nbsp;</td>
                <td>
                    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
                </td>
            </tr>
            <tr>
                <td style="width: 183px; height: 26px;"></td>
                <td style="height: 26px"></td>
            </tr>
            <tr>
                <td style="width: 183px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="gvExpense" runat="server" AutoGenerateColumns="False" AllowSorting="True" OnRowDeleting="gvExpense_RowDeleting" OnRowEditing="gvExpense_RowEditing" OnRowUpdating="gvExpense_RowUpdating" OnSelectedIndexChanged="gvExpense_SelectedIndexChanged">
            <columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="Category" HeaderText="Category" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="Cost" DataFormatString="{0:C2}" HeaderText="Cost" />
                <asp:BoundField DataField="Date" DataFormatString="{0:d}" HeaderText="Date" ReadOnly="True" />
                <asp:CommandField DeleteText="X" ShowDeleteButton="True" />
                <asp:CommandField ShowSelectButton="True" />
            </columns>
        </asp:GridView>
    </form>
</asp:Content>
