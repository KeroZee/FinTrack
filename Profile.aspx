<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="FinTrack.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <form id="form1" runat="server">
        <div class="row">

        <div class="col-md-4">
        <div id="card">
            <div>
            <img src="Mailbox.png"  style="width:60%; height:277px;" />
            <br />
            <asp:Label runat="server" id="Name" style="margin-left:80px" Text=""></asp:Label>
            <br />
            <asp:Button runat="server" Text="EDIT" style ="color:aqua;" class ="btn btn-link" OnClick="Unnamed1_Click"/>
            <div id="info">
                <ul style="list-style-type:none;">
                <li><asp:Label runat="server" Text="" id="email"></asp:Label></li>
                <li><asp:Label runat="server" Text="" id="country"></asp:Label></li>
                <li><asp:Label runat="server" Text="" id="phone"></asp:Label></li>
                <li><asp:Label runat="server" Text="date of birth" id="dob"></asp:Label></li>
                <li><asp:Label runat="server" Text="date joined" id="date_joined"></asp:Label></li>
                <li><asp:Label runat="server" Text="" id="language"></asp:Label></li>
                </ul>
                </div>
                </div>
            </div>
            </div>
            <div class="col-md-6">
            <div class="card">
            <asp:TextBox runat="server" id="bio" MaxLength="100" ReadOnly="True" Rows="5" TextMode="MultiLine"></asp:TextBox>
            <asp:Label runat="server" Text="" id="nickname"></asp:Label>
            <p>UserType: <placeholder"><strong>User</strong></placeholder></p>
            <p>Questions Asked: </p>
            <asp:LinkButton runat="server" id="Question"></asp:LinkButton>
            <button class="btn btn-link" style="color:aqua">Submit a suggestion</button>
            </div>  
               </div>
       </div>

            
    </form>
    <style>
  .card {
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
  margin: auto;
  position:sticky;
  margin-top:10px;
}
   #card {
       position:relative;
        display:inline-block;
        width:100%;
        height:100%;

}
   .title {
        color: grey;
        font-size: 18px;
}
    </style>
    
</asp:Content>
