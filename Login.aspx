<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinTrack.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <form id="form1" runat="server">
    <div style="text-align : center" id="box">
        <h3>Login to Fintrack</h3>
        <div class="form-group" style="margin:auto">
            <label id="EmailI" for="exampleInputEmail1">Email address</label>
            <input  style ="width: 90%" type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
            <small style ="margin-right:45%" id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
         </div>
        <div class="form-group" style="margin:auto">
            <label id="PasswordI" for="exampleInputPassword1">Password</label>
            <input style ="width: 90%" type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
        </div>
        <button type="submit" class="btn btn-primary">Login</button>
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
</asp:Content>
