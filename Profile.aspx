<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="FinTrack.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <form id="form1" runat="server">
        <div class="row">

        <div class="col-md-4">
        <div id="card">
            <div>
            <img src="Mailbox.png"  style="width:60%; height:277px;" />
            <h3 style="margin-left:80px">Peter Doe</h3>
            <p><button style ="color:aqua;" type="button" class ="btn btn-link">EDIT DETAILS</button></p>
            <div id="info">
                <ul style="list-style-type:none;">
                <li><p>Email: <placeholder><strong>Peter_P@abc.com</strong></placeholder></p></li>
                <li><p>Country: <placeholder><strong>Singapore</strong></placeholder></p></li>
                <li><p>Singapore: <placeholder><strong>90123456</strong></placeholder></p></li>
                <li><p>DOB: <placeholder><strong>01/01/01</strong></placeholder></p></li>
                <li><p>Date Joined: <placeholder><strong>01/01/01</strong></placeholder></p></li>
                <li><p>Language: <placeholder><strong>English</strong></placeholder></p></li>
                </ul>
                </div>
                </div>
            </div>
            </div>
            <div class="col-md-6">
            <div class="card">
            <p>Bio: <textarea rows="4" cols="50">Hi</textarea></p>
            <p>Nickname: <placeholder><strong>Pete</strong></placeholder></p>
            <p>Nickname: <placeholder><strong>User</strong></placeholder></p>
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
