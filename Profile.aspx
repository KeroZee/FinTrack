<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="FinTrack.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <form id="form1" runat="server">
        <div class="row">

        <div class="col-md-4">
        <div id="card">
            <div>
            <img src="Mailbox.png"  style="width:60%; height:277px;" />
            <h3 style="margin-left:80px">@parafname</h3>
            <asp:Button runat="server" Text="EDIT" style ="color:aqua;" class ="btn btn-link" OnClick="Unnamed1_Click"/>
            <div id="info">
                <ul style="list-style-type:none;">
                <li><asp:Label runat="server" Text="Label" id="email"></asp:Label></li>
                <li><asp:Label runat="server" Text="Label" id="country"></asp:Label></li>
                <li><asp:Label runat="server" Text="Label" id="phone"></asp:Label></li>
                <li><p>DOB: <placeholder><strong>01/01/01</strong></placeholder></p></li>
                <li><p>Date Joined: <placeholder><strong>01/01/01</strong></placeholder></p></li>
                <li><asp:Label runat="server" Text="Label" id="language"></asp:Label></li>
                </ul>
                </div>
                </div>
            </div>
            </div>
            <div class="col-md-6">
            <div class="card">
            <asp:TextBox runat="server" id="bio" MaxLength="100" ReadOnly="True" Rows="5" TextMode="MultiLine"></asp:TextBox>
            <asp:Label runat="server" Text="Label" id="nickname"></asp:Label>
            <p>UserType: <placeholder"><strong>User</strong></placeholder></p>
            <p>Questions Asked: <a href="#">12</a></p>
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
