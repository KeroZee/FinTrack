﻿<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinTrack.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <form id="form1" runat="server">
    <div style="text-align : center;" id="box">
        
        <h3>Login to Fintrack</h3>
        <% if ((errorList.Any()))
                { %>
            <div class="alert alert-danger mt-2" role="alert"><%=errorList[0] %> </div>
            <% } %>
        <div class="form-group" id="inputform" style="margin:auto; text-align:center;">
            <div class="container">
                <div class="mt-2 pl-4">
            <label id="EmailI" for="exampleInputEmail1">Email address</label>
                    <br />
            <asp:TextBox style="width:90%" class="form-control" id="exampleInputEmail1" placeholder="Email" runat="server" TextMode="Email"></asp:TextBox>  
            </div>
            <div class="mt-2 pl-4">
            <label id="PasswordI" for="exampleInputPassword1" >Password</label>
                <br />
            <asp:TextBox style="width:90%" class="form-control" id="exampleInputPassword1" placeholder="Password" Textmode ="Password" runat="server"></asp:TextBox>
            </div>
        <div class="mt-4">
        <asp:Button runat="server" Text="Login" id="btnLogin" class="btn btn-primary" type="Submit" OnClick="btnLogin_Click1"/>
        </div>
                </div>
          </div>
    </div>
         
    </form>
    <style>
        /*#exampleInputEmail1{
            margin-left: 30px;
        }*/
        /*exampleInputPassword1{
            margin-left: 40px;
        }*/
        #EmailI{
            margin-right: 80%;
        }
        #PasswordI{
            margin-right:85%;
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
