<%@ Page Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="LearnAdminEdit.aspx.cs" Inherits="FinTrack.LearnAdminEdit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form id="form1" class="text-center border border-light p-5" runat="server">
        
        <div class="container">

            <% if ((errorList.Any()))
                { %>
            <div class="alert alert-danger mt-2" role="alert"><%=errorList[0] %> </div>
            <% } %>

            <h3>Edit Article</h3>


            <div class="mt-3">
            <asp:Label ID="Label1" class="float-left" runat="server" Text="Title: "></asp:Label>
            <br />
            <asp:TextBox ID="TextboxTitle" class="form-control" style="width:800px;" runat="server"></asp:TextBox>
            </div>

            <div class="mt-2">
            <asp:Label ID="Label3" class="float-left" runat="server" Text="Author: "></asp:Label>
            <br />
            <asp:TextBox ID="TextboxAuthor" class="form-control" style="width:800px;" runat="server"></asp:TextBox>
            </div>

            <div class="mt-2">
            <asp:Label ID="Label4" class="float-left" runat="server" Text="Link: "></asp:Label>
            <br />
            <asp:TextBox ID="TextboxLink" class="form-control" style="width:800px;" runat="server"></asp:TextBox>
            </div>

            <div class="mt-2">
            <asp:Label ID="Label2" class="float-left" runat="server" Text="Description: "></asp:Label>
            <br />
            <asp:TextBox ID="TextboxDescription" class="form-control" textMode="Multiline" rows="7" style="width:800px;" runat="server"></asp:TextBox>
            </div>

            <asp:Button ID="ButtonSubmit" class="btn btn-success" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />

                  
        </div>

    </form>
</asp:Content>
