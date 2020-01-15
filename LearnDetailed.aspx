<%@ Page Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="LearnDetailed.aspx.cs" Inherits="FinTrack.LearnDetailed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form id="form1" runat="server">
        <div class="container">
            <div class="row mt-4">
                <hr />
                <div class="col-4">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/img/beggar.png" style="width: 200px; height: 200px;" />
                </div>
                <div class="col-8">
                    <div class="row">
                            <asp:Label ID="Label1" runat="server" Text="Label" style="display: inline-block"></asp:Label>                      
                    </div>
                </div>
            </div>


        </div>
    </form>


</asp:Content>


