<%@ Page Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="LearnAdmin.aspx.cs" Inherits="FinTrack.LearnAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form id="form1" runat="server">

        <div class="container">
            <asp:LinkButton ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" CssClass="btn btn-primary mb-n2"><i class="fas fa-plus"></i>&nbsp; Add New</asp:LinkButton>
 

            <% foreach (var item in artList)
                { %>
            <!-- using HTML -->
            <div class="row mt-3">
                <div class="card w-100">
                    <div class="row">
                        <div class="col-2">
                            <asp:Image class="mt-3 mx-auto" runat="server" ImageUrl="/img/DefaultImage.jpg" style="display:block; width: 75px; height: 75px;" />
                        </div>
                        <div class="col-6">
                            <div class="card-body">
                                <h5 class="card-title font-weight-bold text-primary"><%=item.Title %> <span class="card-text font-weight-normal text-muted">by</span> <span><%=item.Author %></span>
                                </h5>
                                <h6 class="card-text mb-2 text-muted"><span class="mr-2"><%=item.Views %> Views</span><span class="mr-2"><%=item.Likes %> Likes</span><span class="mr-2"><%=item.Comments %> Comments</span></h6>
                            </div>
                        </div>
                        <div class="col-4">
                            <div class="float-right mt-3">
                                 <asp:Button ID="BtnEdit" class="btn btn-success" runat="server" Text="Edit" />
                                 <asp:Button ID="BtnDelete" class="btn btn-danger" runat="server" Text="Delete" />
                            </div>
                           
                        </div>
                    </div>
                </div>
            </div>
            <% } %>


        </div>




    </form>


</asp:Content>



