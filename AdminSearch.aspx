<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="AdminSearch.aspx.cs" Inherits="FinTrack.AdminSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form class="text-center border border-light p-5" runat="server">
        <br />
            <div class="row">
                <div class="col-md-4 col-sm-3">
                </div>
                <div class="col-md-4 col-sm-6">
                    <span class="d-block">
                        <label id="CatLabel">Email :</label>
                    </span>
                    <asp:TextBox ID="txtSearch" class="form-control mb-4" runat="server" placeholder="Email Address"></asp:TextBox>
                    <asp:Button runat="server"  class="btn btn-outline-success waves-effect" Text="Search" ID="btnSearch" OnClick="btnSearch_Click1" />
                    <br />
                </div>
                <div class="col-md-4 col-sm-3">
                </div>
            </div>
        <div class="row">
            <div class="col">
            </div>
            <div class="col">
                <br />
                <asp:GridView ID="gvExpense" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False" AllowSorting="True" OnRowDeleting="gvExpense_RowDeleting" OnSelectedIndexChanged="gvExpense_SelectedIndexChanged" Height="213px" Width="844px">
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
    </form>
</asp:Content>
