<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinTrack.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <form id="form1" runat="server">
    <div style="text-align : center" id="box">
        <% if ((errormsg.Any()))
                { %>
            <div class="alert alert-danger mt-2" role="alert"><%=errormsg[0] %> </div>
            <% } %>
        <h3>Login to Fintrack</h3>
        <div class="form-group" style="margin:auto">
            <br />
            <label id="EmailI" for="exampleInputEmail1">Email</label>
                <asp:TextBox style="width:90%" class="form-control" ID="exampleInputEmail1" placeholder="Email" runat="server" TextMode="Email"></asp:TextBox>     
            <small style ="margin-right:45%" id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
         </div>
        <div class="form-group" style="margin:auto">
            <label id="PasswordI" for="exampleInputPassword1" >Password</label>
            <asp:TextBox style="width:90%" class="form-control" ID="exampleInputPassword1" placeholder="Password" Textmode ="Password" runat="server"></asp:TextBox>
        </div>
        <button type="submit" id="btnLogin" class="btn btn-primary">Login</button>
    </div>
         
    </form>
    <style>
        #exampleInputEmail1{
            margin-left: 30px;
        }
        #exampleInputPassword1{
            margin-left: 30px;
        }
        #EmailI{
            margin-right: 75%;
        }
        #PasswordI{
            margin-right:78%;
        }
        #box{
            margin:auto;
            margin-top:50px;
            width:40%;
            border:1px solid black;
            position:relative;
        }
    </style>
     </form>
</asp:Content>
