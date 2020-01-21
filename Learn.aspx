<%@ Page Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Learn.aspx.cs" Inherits="FinTrack.Learn1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form id="form1" runat="server">
        <div class="container">
            <div class="row mt-4">
                <div class="card w-100 p-4">
                    <div class="row">
                        <div class="col-4">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/beggar.png" style="width: 200px; height: 200px;" />
                        </div>
                        <div class="col-8">
                            <div class="card-body">
                                <h5 class="card-title font-weight-bold text-primary">Rags to Riches <span class="card-text font-weight-normal text-muted">by</span> fastmoney.com</h5>
                                <h6 class="card-text mb-2 text-muted"><span class="mr-2">326 Views</span><span class="mr-2">34 Likes</span><span class="mr-2">13 Comments</span></h6>
                                <p class="card-subtitle mb-2 text-black">Some quick example text to build on the card title and make up the  build on the card title and make up th  build on the card title and make up th  build on the card title and make up th bulk of the card's content.</p>
                                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Read More" OnClick="Button1_Click1" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>




    </form>


</asp:Content>


