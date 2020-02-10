<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="AskUpdate.aspx.cs" Inherits="FinTrack.AskUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
    <h3 style="margin-top:20px; text-align:center">Edit your question</h3>
        <hr />
        <br />
        <div style="margin:auto; width:50%">
        <label for="DdlCategory" style="text-align:left;">Category</label>
        <asp:DropDownList ID="DdlCategory" runat="server" CssClass="form-control" >
            <asp:ListItem Value="Finance"></asp:ListItem>
            <asp:ListItem Value="Career"></asp:ListItem>
            <asp:ListItem Value="Insurance"></asp:ListItem>
            <asp:ListItem Value="Property"></asp:ListItem>
            <asp:ListItem Value="Misc"></asp:ListItem>
        </asp:DropDownList>
            </div>
    <div class="card">
        <h5 class="card-header"><label for="TbTitle">Title</label><asp:TextBox CssClass="form-control" placeholder="Title" runat="server" ID="TbTitle" MaxLength="60"></asp:TextBox></h5>
        <div class="card-body">   
            <label for="TbContent">Content</label>
            <p class="card-title"><asp:TextBox CssClass="form-control" placeholder="Text..." runat="server" ID="TbContent" Rows="5"  TextMode="MultiLine"></asp:TextBox></p>
            <div id="post">
                <asp:Button ID="BtnCancel" CssClass="btn btn-primary btn-sm" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
                <asp:Button ID="BtnUpdate" CssClass="btn btn-primary btn-sm" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
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
            margin:auto;
        }
    </style>
    </form>
</asp:Content>
