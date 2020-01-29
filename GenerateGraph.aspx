<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="GenerateGraph.aspx.cs" Inherits="FinTrack.GenerateGraph" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Select Graph Type : "></asp:Label>
        <asp:DropDownList ID="ddlGraphType" runat="server" OnSelectedIndexChanged="ddlGraphType_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:Chart ID="ExpenseChart" runat="server" DataSourceID="SqlDataSource1">
            <Titles>
                <asp:Title Text="Cost of Expense"></asp:Title>
            </Titles>
            <Series>
                <asp:Series ChartType="Column" Name="ExpenseSeries" XValueMember="date" YValueMembers="price">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Title="Date"></AxisX>
                    <AxisY Title="Cost"></AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [category], [date], [price] FROM [Expense]"></asp:SqlDataSource>
    </form>
</asp:Content>
