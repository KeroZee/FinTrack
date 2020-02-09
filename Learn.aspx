<%@ Page Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Learn.aspx.cs" Inherits="FinTrack.Learn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        .btndetailed:hover {
            text-decoration: underline;
        }

        .icons {
            color: dimgray
        }
           
    </style>

    <form id="form1" runat="server">
        <div class="container">

            <asp:LinkButton ID="SubmitBtn" runat="server" OnClick="BtnAdmin_Click" CssClass="btn btn-info btn-block mt-2">Go to Admin Page</asp:LinkButton>

            <asp:SqlDataSource
                ID="ArticleDatasource"
                runat="server"
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT * FROM [Article] WHERE DELETED='false'"></asp:SqlDataSource>

            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ArticleDatasource">
                <itemtemplate>
                        <div class="row mt-3">
                <div class="card w-100 p-4">
                    <div class="row">

                        <div class="col-4 text-center">
                           <div class="col-sm-8 mx-auto">
                               <div class="hovereffect">
                                <asp:ImageButton class="img-fluid rounded" runat="server" ImageUrl='<%#Eval("Image") %>' style="width: 200px; height: 200px;" runat="server"></asp:ImageButton>
                                <div class="overlay">
                                    <h2><%# Eval("Title") %></h2>
                                    <asp:Button class="btn btn-readmore mt-4" runat="server" CommandName='<%# Eval("id")%>' OnClick="BtnReadMore_Click" text="Read More"></asp:Button>
                                </div>
                               </div>
                           </div>
                        </div>
                         
                        <div class="col-8">
                            <div class="card-body">
                                <h5 class="card-title font-weight-bold text-primary">
                                    <asp:LinkButton class="btndetailed" ID="BtnDetailed"  CommandName='<%# Eval("id")%>' OnClick="BtnDetailed_Click" runat="server">
                                        <%# Eval("Title") %></asp:LinkButton> 
                                    <span class="card-text font-weight-normal text-muted">by</span> 
                                        <span><%# Eval("Author") %></span></h5>
                                <h6 class="card-text mb-2 text-muted">
                                    <span class="mr-3"><%# Eval("Views")%> Views</span>
                                    <span class="mr-2">Updated: <%# Eval("LastUpdated") %></span>
                                    <span class="mr-2">Created: <%# Eval("DatePosted") %></span>
                                </h6>
                                <p class="card-subtitle mb-2 text-black"><%# Eval("Description") %></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
                    </itemtemplate>
            </asp:Repeater>

        </div>




    </form>


</asp:Content>


