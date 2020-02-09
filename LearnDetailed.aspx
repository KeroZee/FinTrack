<%@ Page Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="LearnDetailed.aspx.cs" Inherits="FinTrack.LearnDetailed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form id="form1" runat="server">
        <div class="container">
            <div class="card mt-3">
                <div class="card-body">
                    <div class="row mt-3">
                        <hr />
                        <div class="col-4 text-center">
                            <asp:Image ID="Image" class="rounded" runat="server" ImageUrl="" style="width: 200px; height: 200px;" />
                        </div>
                        <div class="col-8">
                            <div class="row">
                                <asp:Label ID="LblTitle" class="font-weight-bold text-primary" style="font-size: 1.5rem" runat="server"></asp:Label>
                            </div>
                            <div class="row">
                                <asp:Label ID="LblDescription" runat="server"></asp:Label>
                            </div>
                            <hr />
                            <div class="row">
                                <div class="col-6 text-muted"><i class="fas fa-user mr-1"></i>
                                    Created by:
                                    <asp:Label ID="LblAuthor" class="" runat="server"></asp:Label>
                                </div>
                                <div class="col-6 text-muted text-right"><i class="fas fa-clock mr-1"></i>
                                    Created on:
                                    <asp:Label ID="LblDatePosted" class="" runat="server"></asp:Label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-6 text-muted">
                                    <i class ="far fa-eye"></i>
                                    <asp:Label ID="LblViews" runat="server"></asp:Label>
                                </div>
                                <div class="col-6 text-muted text-right"><i class="fas fa-clock mr-1"></i>
                                    Last Updated on:
                                    <asp:Label ID="LblLastUpdated" class="" runat="server"></asp:Label>
                                </div>
                            </div>
                            <div class="mt-2">
                                <asp:LinkButton ID="BtnLink" CssClass="btn btn-block btn-primary" runat="server" Text="Read More" OnClick="BtnLink_Click"></asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>



        </div>
    </form>


</asp:Content>


