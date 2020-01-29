<%@ Page Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="LearnDetailed.aspx.cs" Inherits="FinTrack.LearnDetailed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form id="form1" runat="server">
        <div class="container">
            <div class="card mt-3">
                <div class="card-body">
                    <div class="row mt-3">
                <hr />
                <div class="col-4">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/img/DefaultImage.jpg" style="width: 200px; height: 200px;" />
                </div>
                <div class="col-8">
                    <div class="row">
                            <asp:Label ID="LblTitle" class="font-weight-bold text-primary" runat="server" Text="" style="display: inline-block"></asp:Label>                      
                    </div>
                    <div class="row">
                            <asp:Label ID="LblDescription" runat="server" Text="" style="display: inline-block"></asp:Label>                      
                    </div>
                    <hr />
                    <div class="row">
                            Created on:  <asp:Label ID="LblDatePosted" runat="server" Text="" style="display: inline-block"></asp:Label>                      
                    </div>
                    <div class="row">
                            Created by: <asp:Label ID="LblAuthor" runat="server" Text="" style="display: inline-block"></asp:Label>                      
                    </div>
                </div>
            </div>
                </div>
            </div>
            


        </div>
    </form>


</asp:Content>


