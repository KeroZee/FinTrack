<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FinTrack.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <body class="myTitle bg">
        <div class="row">
            <div class="col-4">
            </div>
            <div class="col-4">
                <h1 class="center title-white">Your One-stop
                <br />
                    <span class="text-primary">Personal Finance</span><br />
                    Platform</h1>
            </div>
            <div class="col-4">
            </div>
        </div>
        <div class="bodylink">
            <a href="Ask.aspx" class="btn custom hoverable btn-light-blue px-4"><i class="fas fa-comment-alt fa-2x"></i>
                <br />
                Ask</a>
            <a href="Learn.aspx" class="btn custom hoverable btn-light-blue px-4"><i class="fas fa-book fa-2x"></i>
                <br />
                Learn</a>
            <a href="Track.aspx" class="btn custom hoverable btn-light-blue px-4"><i class="fas fa-chart-line fa-2x"></i>
                <br />
                Track</a>
            <a href="#" class="btn custom hoverable btn-light-blue px-4"><i class="fas fa-plane-departure fa-2x"></i>
                <br />
                Travel</a>
        </div>
    </body>
</asp:Content>
