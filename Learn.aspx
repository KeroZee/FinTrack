<%@ Page Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Learn.aspx.cs" Inherits="FinTrack.Learn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form id="form1" runat="server">
        <div class="container">

            <asp:LinkButton ID="SubmitBtn" runat="server" OnClick="BtnAdmin_Click" CssClass="btn btn-info btn-block mt-2">Go to Admin Page</asp:LinkButton>
 
            <% foreach (var item in artList)
                { %>
            <!-- using HTML -->
            <div class="row mt-3">
                <div class="card w-100 p-4">
                    <div class="row">
                        <div class="col-4">
                            <asp:Image ID="Image3" runat="server" ImageUrl="img/DefaultImage.jpg" style="width: 200px; height: 200px;" />
                        </div>
                        <div class="col-8">
                            <div class="card-body">
                                <h5 class="card-title font-weight-bold text-primary"><%=item.Title %> <span class="card-text font-weight-normal text-muted">by</span> <span><%=item.Author %></span></h5>
                                <h6 class="card-text mb-2 text-muted"><span class="mr-2"><%=item.Views %> Views</span><span class="mr-2"><%=item.Likes %> Likes</span><span class="mr-2"><%=item.Comments %> Comments</span></h6>
                                <p class="card-subtitle mb-2 text-black"><%=item.Description %></p>
                                <asp:Button ID="BtnDetailed" class="btn btn-primary" runat="server" Text="Read More" OnClick="BtnDetailed_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <% } %>


        </div>




    </form>


</asp:Content>


