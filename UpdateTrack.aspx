<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="UpdateTrack.aspx.cs" Inherits="FinTrack.UpdateTrack" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div style="background-image: url(https://i.redd.it/34woefmjsl911.jpg)">
        <form id="form1" runat="server">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <div class="row">
                <div class="col-md-4 col-sm-3">
                </div>
                <div class="card col-md-4 col-sm-6">
                    <h1 align="center">Update Your Expense!</h1>
                    <br />
                    <div>
                        <label for="txtID">ID</label>
                        <asp:TextBox ID="txtID" class="form-control mb-4" runat="server" ForeColor="Silver" ReadOnly="True"></asp:TextBox>
                    </div>
                    <label>Category</label>
                    <asp:DropDownList ID="ddlCat" class="form-control mb-4" runat="server">
                        <asp:ListItem Value="-1">-- Select --</asp:ListItem>
                        <asp:ListItem>Food</asp:ListItem>
                        <asp:ListItem>Transportation</asp:ListItem>
                        <asp:ListItem>Housing</asp:ListItem>
                        <asp:ListItem>Utilities</asp:ListItem>
                        <asp:ListItem>Healthcare & Medical</asp:ListItem>
                        <asp:ListItem>Debt Repayment</asp:ListItem>
                    </asp:DropDownList>
                    <div>
                        <label for="DescLabel">Description of Expense</label>
                        <asp:TextBox ID="txtUpdateDesc" class="form-control mb-4" runat="server" rows="4" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    <div>
                        <label for="txtUpdateCost">Cost of Expense</label>
                        <asp:TextBox ID="txtUpdateCost" class="form-control mb-4" runat="server"></asp:TextBox>
                    </div>
                    <asp:Label ID="LblMsg" runat="server" BackColor="White" BorderColor="Red" ForeColor="Red"></asp:Label>
                    <br />
                    <div class="row">
                        <div class="col-md-4">
                        </div>
                        <div class="col-md-4">
                            <asp:Button ID="btnUpdate" class="btn btn-outline-success waves-effect mb-2 align-self-md-center" runat="server" placeholder="Add Expense" OnClick="btnUpdate_Click" Text="Save" />
                        </div>
                        <div class="col-md-4">
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-3">
                </div>
            </div>
            <br />
            <br />
            <br />
            <br />
        </form>
    </div>
</asp:Content>
