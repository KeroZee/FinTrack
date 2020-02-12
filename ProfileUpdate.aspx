<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="ProfileUpdate.aspx.cs" Inherits="FinTrack.ProfileUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
        <div id ="box">
        <div class ="container">
        <div class="mt-2">
        <asp:Label ID="lblFname" runat="server" Text="Label">First Name: </asp:Label>
            <br />
        <asp:TextBox ID="tbFname" runat="server" placeholder="First Name" style="width:70%;"></asp:TextBox>    
        </div>
        <div class ="mt-2">
        <asp:Label ID="lblLname" runat="server" Text="Label">Last Name: </asp:Label>
            <br />
        <asp:TextBox ID="tbLname" runat="server" placeholder="Last Name" style="width:70%;"></asp:TextBox>
        
        </div>
        <div class =" mt-2">
        <asp:Label ID="lblCountry" runat="server" Text="Label">Country: </asp:Label>
            <br />
        <asp:TextBox ID="tbCountry" runat="server" placeholder="Country" style="width:70%;"></asp:TextBox>
        
        </div>
        <div class =" mt-2">
        <asp:Label ID="lblPhone" runat="server" Text="Label">Phone: </asp:Label>
            <br />
        <asp:TextBox ID="tbPhone" runat="server" placeholder="Phone" TextMode="Phone" style="width:70%;"></asp:TextBox>
        
        </div>
        <div class =" mt-2">
        <asp:Label ID="lblLanguage" runat="server" Text="Label">Language: </asp:Label>
            <br />
        <asp:TextBox ID="tbLanguage" runat="server" placeholder =" Language" style="width:70%;"></asp:TextBox>
        
        </div>
        <div class="mt-2">
        <asp:Label ID="lblBio" runat="server" Text="Label">Bio: </asp:Label>
        <br />
        <asp:TextBox ID="tbBio" runat="server" placeholder ="Bio" TextMode="MultiLine" Rows="5" Width="252px" MaxLength="100" style="width:70%;"></asp:TextBox>
        
        </div>
        <div class="mt-2">
        <asp:Label ID="lblNickname" runat="server" Text="Label">Nickname: </asp:Label>
        <br />
        <asp:TextBox ID="tbNickname" runat="server" placeholder ="Nickname" style="width:70%;"></asp:TextBox>
        
        </div>
        <div class="mt-2">
        <asp:Label runat="server" Text="Label">Date of Birth: </asp:Label>
        <br />
        <asp:TextBox ID="tbDOB" runat="server" placeholder ="Date of Birth" style="width:70%;" TextMode="Date"></asp:TextBox>
        
        </div>
        <div class="m-2">
        <asp:Label runat="server" Text="Label">Image URL: </asp:Label>
        <br />
        <asp:TextBox ID="tbImage" runat="server" placeholder="URL" style="width:70%;"></asp:TextBox>
        
        </div>
             
            </div>
        <div style="text-align:center">
             <asp:Button ID="btnUpdate" class="btn btn-success" runat="server" Text="Submit" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnBack" class="btn btn-danger" runat="server" Text="Back" OnClick="btnBack_Click" />
        </div>
        </div>  

    </form>
    <style>
     #box{
            margin:auto;
            margin-top:50px;
            width:40%;
            border:1px solid black;
            position:relative;
            text-align:center;
        }
        </style>
</asp:Content>
