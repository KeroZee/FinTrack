<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="AskCreate.aspx.cs" Inherits="FinTrack.AskCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
    <div class="card">
        <h5 class="card-header"><asp:TextBox CssClass="form-control" placeholder="Title" runat="server" ID="TbTitle"></asp:TextBox></h5>
        <div class="card-body">   
            <p class="card-title"><asp:TextBox CssClass="form-control" placeholder="Text..." runat="server" ID="TbContent" Rows="5"  TextMode="MultiLine"></asp:TextBox></p>
            <div id="post">
                <asp:Button ID="BtnSubmit" CssClass="btn btn-primary btn-sm" runat="server" Text="Post" OnClick="BtnSubmit_Click" />
                </div>
        </div>
    </div>
    <style>
        a{
            text-decoration:none;
            color:black;
        }
        .card{
            width:50%;
            margin:auto;
            margin-top:50px;
            margin-bottom:10px;
            text-align:left;
        }   
        #post{
            float:right;
        }
        .form-control{
            resize: none;
        }
    </style>
    </form>
</asp:Content>
