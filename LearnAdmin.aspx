<%@ Page Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="LearnAdmin.aspx.cs" Inherits="FinTrack.LearnAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form id="form1" runat="server">

        <div class="container">
            <asp:LinkButton ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" CssClass="btn btn-primary mb-n2"><i class="fas fa-plus"></i>&nbsp; Add New</asp:LinkButton>

            <asp:SqlDataSource
                ID="ArticleDatasource"
                runat="server"
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT * FROM [Article] WHERE DELETED='false'"></asp:SqlDataSource>

            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ArticleDatasource">
                <itemtemplate>
                    <!-- using HTML -->
                    <div class="row mt-3">
                        <div class="card w-100">
                            <div class="row">
                                <div class="col-2">
                                    <asp:Image class="mt-3 mx-auto" runat="server" ImageUrl="/img/DefaultImage.jpg" style="display:block; width: 75px; height: 75px;" />
                                </div>
                                <div class="col-6">
                                    <div class="card-body">
                                        <h5 class="card-title font-weight-bold text-primary"><%#Eval("title") %> <span class="card-text font-weight-normal text-muted">by</span> <span><%#Eval("author") %></span>
                                        </h5>
                                        <h6 class="card-text mb-2 text-muted">
                                            <span class="mr-2"><i class ="far fa-eye"></i> <%# Eval("Views") %></span>
                                            <span class="mr-2"><i class ="far fa-thumbs-up"></i> <%# Eval("Likes") %></span>
                                            <span class="mr-4"><i class="far fa-comment-alt"></i> <%# Eval("Comments") %></span>
                                            <span class="mr-2">Updated: <%# Eval("LastUpdated") %></span>
                                            <span class="mr-2">Created: <%# Eval("DatePosted") %></span>
                                        </h6>
                                    </div>
                                </div>
                                <div class="col-4">
                                    <div class="float-right mt-3">
                                         <asp:Button ID="BtnEdit" class="btn btn-success btn-sm" CommandName='<%# Eval("id")%>' runat="server" Text="Edit" OnClick="BtnEdit_Click" />
                                         <asp:Button ID="BtnDelete" class="btn btn-danger btn-sm" CommandName='<%# Eval("id")%>' runat="server" Text="Delete" data-toggle="modal" data-target="#DeleteModal" OnClientClick="return false;" />
                                    </div>
                           
                                </div>
                            </div>
                        </div>
                    </div>

                            <!-- Delete Modal -->
                    <div id="DeleteModal" class="modal fade" role="dialog">
                        <div class="modal-dialog">

                            <!-- Modal content-->
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h4 class="modal-title">Delete this Article</h4>
                                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                                </div>
                                <div class="modal-body">
                                    <p>Are you sure you want to delete this article?</p>
                                </div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-light btn-sm" data-dismiss="modal">Cancel</button>
                                    <asp:Button class="btn btn-danger btn-sm" runat="server" CommandName='<%# Eval("id")%>' Text="Delete" OnClick="BtnDelete_Click" />
                                </div>
                            </div>

                        </div>
                    </div>

                </itemtemplate>
            </asp:Repeater>

        </div>
        <!-- div for container -->




    </form>


</asp:Content>



