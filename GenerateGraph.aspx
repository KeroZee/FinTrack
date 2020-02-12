<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="GenerateGraph.aspx.cs" Inherits="FinTrack.GenerateGraph" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div style="background-image: url(https://i.redd.it/34woefmjsl911.jpg)">
        <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        <form id="form1" runat="server">
            <div class="card" align="center" dir="auto">
                <br />
                <h1>Your Expense Overview</h1>
                <asp:Chart ID="ExpenseChart" runat="server" Height="456px" Width="1420px" style="font-weight: bold">
                    <series>
                <asp:Series Name="Series1">
                </asp:Series>
            </series>
                    <chartareas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Title="Category"></AxisX>
                    <AxisY Title="Cost"></AxisY>
                </asp:ChartArea>
            </chartareas>
                </asp:Chart>
            </div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </form>
    </div>
</asp:Content>
