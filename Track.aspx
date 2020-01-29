<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Track.aspx.cs" Inherits="FinTrack.Track" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <body>
        <form id="form1" runat="server" class="text-center border border-light p-5">
            <h1>Your Expense Tracker!</h1>
            <br />
            <div class="row">
                <div class="col-md-4 col-sm-3">
                </div>
                <div class="col-md-4 col-sm-6">
                    <span class="d-block">
                        <label id="CatLabel">Category</label>
                    </span>
                   
                    <asp:DropDownList ID="ddlCat" class="form-control mb-4" runat="server">
                        <asp:ListItem Value="-1">-- Select --</asp:ListItem>
                        <asp:ListItem>Food</asp:ListItem>
                        <asp:ListItem>Transportation</asp:ListItem>
                        <asp:ListItem>Housing</asp:ListItem>
                        <asp:ListItem>Utilities</asp:ListItem>
                        <asp:ListItem>Healthcare & Medical</asp:ListItem>
                        <asp:ListItem>Debt Repayment</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtDesc" class="form-control mb-4" runat="server" rows="4" placeholder="Description of Expense" TextMode="MultiLine"></asp:TextBox>
                    <asp:TextBox ID="txtCost" class="form-control mb-4" runat="server" placeholder="Cost"></asp:TextBox>
                    <asp:Label ID="lblError" runat="server" BackColor="White" BorderColor="Red" ForeColor="Red"></asp:Label>
                    <br />
                    <div class="row">
                        <div class="col-md-4">
                        </div>
                        <div class="col-md-4">
                            <asp:Button ID="btnSave" class="form-control mb-2 align-self-md-center" runat="server" placeholder="Add Expense" OnClick="btnSave_Click" Text="Save" />
                        </div>
                        <div class="col-md-4">
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-3">
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-1">
                </div>
                <div class="col-10">
                    <div class="row">
                        <div class="col-md-1">
                        </div>
                        <div class="col-md-10">
                            <div class="card d-none d-lg-block" style="padding: 10px;">
                                <div class="row">
                                    <div class="col-md">
                                        <asp:TextBox ID="txtStartDate" TextMode="Date" class="form-control mb-4" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-md">
                                        <asp:TextBox ID="txtEndDate" TextMode="Date" class="form-control mb-4" runat="server" ></asp:TextBox>
                                    </div>
                                    <div class="col-md">
                                        <asp:Button ID="btnFilter" runat="server" class="form-control mb-4" OnClick="btnFilter_Click" Text="Filter" />
                                    </div>
                                    <div class="col-md">
                                        <asp:Button ID="btnGenerateGraph" runat="server" class="form-control mb-4" OnClick="btnGenerateGraph_Click" Text="Generate Graph" />
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
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </body>
    </form>
        </form>
</asp:Content>
