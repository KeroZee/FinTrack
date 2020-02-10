<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="ProfileUpdate.aspx.cs" Inherits="FinTrack.ProfileUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
        <div id="box">
        <asp:Label ID="lblFname" runat="server" Text="Label">First Name: </asp:Label>
        <asp:TextBox ID="tbFname" runat="server" hint="First Name"></asp:TextBox>
        <br />
        <asp:Label ID="lblLname" runat="server" Text="Label">Last Name: </asp:Label>
        <asp:TextBox ID="tbLname" runat="server" hint="Last Name"></asp:TextBox>
        <br />
        <asp:Label ID="lblCountry" runat="server" Text="Label">Country: </asp:Label>
        <asp:TextBox ID="tbCountry" runat="server" hint="Country"></asp:TextBox>
        <br />
        <asp:Label ID="lblPhone" runat="server" Text="Label">Phone: </asp:Label>
        <asp:TextBox ID="tbPhone" runat="server" hint="Phone"></asp:TextBox>
        <br />
        <asp:Label ID="lblLanguage" runat="server" Text="Label">Language: </asp:Label>
        <asp:TextBox ID="tbLanguage" runat="server" hint =" Language"></asp:TextBox>
        <br />
        <asp:Label ID="lblBio" runat="server" Text="Label">Bio: </asp:Label>
        <asp:TextBox ID="tbBio" runat="server" hint ="Bio" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Label ID="lblNickname" runat="server" Text="Label">Nickname: </asp:Label>
        <asp:TextBox ID="tbNickname" runat="server" hint ="Nickname"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Label">Date of Birth: </asp:Label>
        <asp:TextBox ID="tbDOB" runat="server" hint="Date of Birth"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Label">Image URL: </asp:Label>
        <asp:TextBox ID="tbImage" runat="server" hint="URL"></asp:TextBox>
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="Submit" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        <br />
        </div>
    </form>
    <style>
     #box{
            margin:auto;
            margin-top:50px;
            width:40%;
            border:1px solid black;
            position:relative;
        }
        </style>
</asp:Content>
