<%@ Page Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="LearnAdminEdit.aspx.cs" Inherits="FinTrack.LearnAdminEdit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <div class="card mt-4 mx-auto" style="width: 46rem">

        <h3 class="mt-4 text-center">Edit Article</h3>

        <div class="card-body text-center">            
            <form class="text-center p-3"  runat="server">
                    <% if ((errorList.Any()))
                    { %>
                <div class="alert alert-danger mt-2" role="alert"><%=errorList[0] %> </div>
                <% } %>

                <div class="mt-2">
                    <asp:Label ID="Label3" class="float-left text-muted" runat="server" Text="Title: "></asp:Label>
                    <br />
                    <asp:TextBox ID="TextboxTitle" class="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="mt-2">
                    <asp:Label ID="Label1" class="float-left text-muted" runat="server" Text="Author: "></asp:Label>
                    <br />
                    <asp:TextBox ID="TextboxAuthor" class="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="mt-2">
                    <asp:Label ID="Label2" class="float-left text-muted" runat="server" Text="Description: "></asp:Label>
                    <br />
                    <asp:TextBox ID="TextboxDescription" class="form-control" textMode="Multiline" rows="7"  runat="server"></asp:TextBox>
                </div>

                <div class="mt-2">
                    <asp:Label ID="LabelLink" class="float-left text-muted" runat="server" Text="Link: "></asp:Label>
                    <br />
                    <asp:TextBox ID="TextboxLink" class="form-control" textmode="url" runat="server"></asp:TextBox>
                </div>

                <div class="mt-2 text-left">
                    <asp:Label ID="Label4" class="float-left text-muted" runat="server" Text="Image: "></asp:Label>
                    <br />
                    <asp:FileUpload id="UploadImage" class-="text-left" runat="server" />
                    <br />
                    <asp:Label ID="Label5" class="float-left text-info" runat="server" Text="Previous Image will be given if no file is chosen. "></asp:Label>
                </div>

                <br />
                <asp:Button class="btn btn-success mt-4" runat="server" Text="Save"  onclick="ButtonSubmit_Click" />

            </form>

        </div>

    </div>

</asp:Content>
