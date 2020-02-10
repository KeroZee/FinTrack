<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="AddProfile.aspx.cs" Inherits="FinTrack.AddProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblFname" runat="server" Text="Label">First Name: </asp:Label>
        <asp:TextBox ID="tbFname" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblLname" runat="server" Text="Label">Last Name: </asp:Label>
        <asp:TextBox ID="tbLname" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCountry" runat="server" Text="Label">Country: </asp:Label>
        <asp:TextBox ID="tbCountry" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPhone" runat="server" Text="Label">Phone </asp:Label>
        <asp:TextBox ID="tbPhone" runat="server" OnTextChanged="TextBox2_TextChanged" hint="Phone"></asp:TextBox>
        <br />
        <asp:Label ID="lblLanguage" runat="server" Text="Label">Language: </asp:Label>
        <asp:TextBox ID="tbLanguage" runat="server" OnTextChanged="TextBox2_TextChanged" hint =" Language"></asp:TextBox>
        <br />
        <asp:Label ID="lblBio" runat="server" Text="Label">Bio: </asp:Label>
        <asp:TextBox ID="tbBio" runat="server" OnTextChanged="TextBox2_TextChanged" hint ="Bio"></asp:TextBox>
        <br />
        <asp:Label ID="lblNickname" runat="server" Text="Label">Nickname</asp:Label>
        <asp:TextBox ID="tbNickname" runat="server" OnTextChanged="TextBox2_TextChanged" hint ="Nickname"></asp:TextBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Submit" OnClick="btnAdd_Click" />
        <br />
        </div>
    </form>
</asp:Content>
