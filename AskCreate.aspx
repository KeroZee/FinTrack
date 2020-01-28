<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="AskCreate.aspx.cs" Inherits="FinTrack.AskCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
    <h3 style="margin-top:20px">Ask a question</h3>
        <hr />
        <br />
        <asp:DropDownList ID="DdlCategory" runat="server" CssClass="form-control" Width="50%">
            <asp:ListItem Value="Finance"></asp:ListItem>
            <asp:ListItem Value="Career"></asp:ListItem>
            <asp:ListItem Value="Insurance"></asp:ListItem>
            <asp:ListItem Value="Property"></asp:ListItem>
            <asp:ListItem Value="Misc"></asp:ListItem>
        </asp:DropDownList>


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
            margin-top:25px;
            margin-bottom:10px;
            text-align:left;
        }   
        #post{
            float:right;
        }
        .form-control{
            resize: none;
            margin:auto;
        }
    </style>
    </form>
</asp:Content>
