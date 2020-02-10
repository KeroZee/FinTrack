<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="UpdateTrack.aspx.cs" Inherits="FinTrack.UpdateTrack" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
        <table class="w-100" style="width: 80%; height: 115px">
            <tr>
                <td style="width: 91px">ID:</td>
                <td style="width: 1396px">
                    <asp:TextBox ID="txtID" runat="server" ReadOnly="True" Width="39px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px; height: 26px">Description:</td>
                <td style="width: 1396px; height: 26px">
                    <asp:TextBox ID="txtUpdateDesc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">Category:</td>
                <td style="width: 1396px">
                    <asp:DropDownList ID="ddlCat" runat="server">
                        <asp:ListItem>-- Select --</asp:ListItem>
                        <asp:ListItem>Food</asp:ListItem>
                        <asp:ListItem>Transportation</asp:ListItem>
                        <asp:ListItem>Housing</asp:ListItem>
                        <asp:ListItem>Utilities</asp:ListItem>
                        <asp:ListItem>Healthcare & Medical</asp:ListItem>
                        <asp:ListItem>Debt Repayment</asp:ListItem> 
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">Cost:</td>
                <td style="width: 1396px">
                    <asp:TextBox ID="txtUpdateCost" runat="server" style="margin-top: 36"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">&nbsp;</td>
                <td style="width: 1396px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 91px">&nbsp;</td>
                <td style="width: 1396px">
                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                </td>
            </tr>
            <tr>
                <td style="width: 91px">&nbsp;</td>
                <td style="width: 1396px">
                    <asp:Label ID="LblMsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
