<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="FinTrack.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <form id="form1" runat="server">
        
        <div class="row">

        <div class="col-md-4">
        <div id="card">
            <div class="container">
            <div class="mt-2" style="text-align:center;">
             <asp:Image ID="imageshow" runat="server" ImageUrl="img/DefaultImage.jpg" style="width:200px; height:200px; "></asp:Image>
                <br />
            
            <asp:Label runat="server" id="Name" style="font-size:40px;" Text=""></asp:Label>
            
            </div>
            
            <asp:Button runat="server" Text="EDIT" style ="color:aqua;" class ="btn btn-link" OnClick="Unnamed1_Click"/>
            <div id="info" class="mt-2">
                <div class=" mr-5">
                <ul style="list-style-type:none;">
                <li><asp:Label runat="server" Text="" id="email" style="font-size:20px;"></asp:Label></li>
                <li><asp:Label runat="server" Text="" id="country" style="font-size:20px;"></asp:Label></li>
                <li><asp:Label runat="server" Text="" id="phone" TextMode="Phone" style="font-size:20px;"></asp:Label></li>
                <li><asp:Label runat="server" Text="date of birth" id="dob" style="font-size:20px;"></asp:Label></li>
                <li><asp:Label runat="server" Text="date joined" id="date_joined" style="font-size:20px;"></asp:Label></li>
                <li><asp:Label runat="server" Text="" id="language" style="font-size:20px;"></asp:Label></li>


                </ul>
                </div>
                </div>
                </div>
            </div>
            </div>
            
          
            
            <div class="col-md-6">
            <div class="card">
            <div class ="container">
            <div class="mt-3">
            <asp:TextBox runat="server" id="bio" MaxLength="100" ReadOnly="True" Rows="5" TextMode="MultiLine" placeholder="Bio" style="width:80%;"></asp:TextBox>
            </div> 
            <div class="mt-3">
            <asp:Label runat="server" Text="" id="nickname" style="font-size:20px;"></asp:Label>
            </div>
            <div class="mt-3">
            <asp:Label runat="server" Text="Label" id="acc_type" style="font-size:20px;"></asp:Label>
            </div>
            <div class="mt-3">
                <asp:Label runat="server" id="Question" Text=""></asp:Label>
            </div>
            </div>  
               </div>
        </div>
        </div>
       
   

            
    </form>
    <style>
  .imageshow{
      width:200px;
      height:200px;
  }  
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
