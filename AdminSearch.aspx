<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="AdminSearch.aspx.cs" Inherits="FinTrack.AdminSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="row">
        <div class="col">
            <asp:TextBox runat="server" class="form-control mb-4" ID="txtSearch"></asp:TextBox>
        </div>
        <div class="col">
            <asp:Button runat="server" class="form-control mb-4" Text="Search" ID="btnSearch" OnClick="btnSearch_Click" />
        </div>
    </div>
    <div class="row">
        <div class="col">
        </div>
        <div class="col">
            <br />
            <asp:GridView ID="gvExpense" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False" AllowSorting="True" OnRowDeleting="gvExpense_RowDeleting" OnRowEditing="gvExpense_RowEditing" OnRowUpdating="gvExpense_RowUpdating" OnSelectedIndexChanged="gvExpense_SelectedIndexChanged" Height="213px" Width="844px">
                <columns>
                                                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                                                <asp:BoundField DataField="Category" HeaderText="Category" />
                                                <asp:BoundField DataField="Description" HeaderText="Description" />
                                                <asp:BoundField DataField="Cost" DataFormatString="{0:N2}" HeaderText="Cost" />
                                                <asp:BoundField DataField="Date" DataFormatString="{0:d}" HeaderText="Date" ReadOnly="True" />
                                                <asp:CommandField ShowDeleteButton="True" />
                                                <asp:CommandField ShowSelectButton="True" />
                                            </columns>
            </asp:GridView>
        </div>
        <div class="col">
        </div>
    </div>
</asp:Content>
