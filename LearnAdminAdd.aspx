<%@ Page Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="LearnAdminAdd.aspx.cs" Inherits="FinTrack.LearnAdminAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form id="form1" runat="server">

        <div class="container">
            <% if ((errorList.Any()))
                { %>
            <div class="alert alert-danger mt-2" role="alert"><%=errorList[0] %> </div>
            <% } %>

            <h3>Create a New Article</h3>


            <div class="mt-3">
            <asp:Label ID="Label1" runat="server" Text="Title: "></asp:Label>
            <asp:TextBox ID="TextboxTitle" runat="server"></asp:TextBox>
            </div>

            <div class="mt-2">
            <asp:Label ID="Label3" runat="server" Text="Author: "></asp:Label>
            <asp:TextBox ID="TextboxAuthor" runat="server"></asp:TextBox>
            </div>

            <div class="mt-2">
            <asp:Label ID="Label2" runat="server" Text="Description: "></asp:Label>
            <asp:TextBox ID="TextboxDescription" runat="server"></asp:TextBox>
            </div>

            <asp:Button ID="ButtonSubmit" class="btn btn-success" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />

                  
        </div>








    </form>


</asp:Content>
