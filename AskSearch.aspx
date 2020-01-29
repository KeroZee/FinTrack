<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="AskSearch.aspx.cs" Inherits="FinTrack.AskSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
        <div class="container h-100">
            <div class="d-flex justify-content-center h-100">
                <div class="searchbar">

                   
                    <asp:TextBox ID="TbSearch" runat="server" CssClass="searchinput" placeholder="Search for a question..."></asp:TextBox>
                    <asp:LinkButton runat="server" ID="LbtnSearch" OnClick="LbtnSearch_Click" CssClass="searchicon"><i class="fas fa-search"></asp:LinkButton></i>

                </div>
            </div>
        </div>
         
        <button type="button" class="btn btn-primary btn-lg btn-block" id="postbutton" onclick="window.location.href = 'AskCreate.aspx';">
            Ask a Question</button>

        <asp:Repeater ID="PostRepeater" runat="server">
            <itemtemplate>
                <div class="card">
                    <h5 class="card-header">
                    <b>[<%# Eval("category")%>]</b> - <asp:LinkButton ID="LbTitle" Text='<%# Eval("title")%>' CommandName='<%# Eval("id")%>' runat="server" OnClick="LbTitle_Click"></asp:LinkButton></h5>
                    <div class="card-body">   
                    <p class="card-title"><%# Eval("content ") %></p>
                    <h5 class="card-text"><a href="#" class="usericon"><i class="fas fa-user"></i></a><a href="#" class="usertitle"> <%# Eval("username") %>     
                        </a> - posted on the <%# Eval("datePosted") %></h5>
                    <h5 class="card-text"><a href="#" class="ratingsicon"><i class="fas fa-thumbs-up"></i></a><%# Eval("likes") %> <a href="#" class="ratingsicon"><i class="fas fa-thumbs-down"></i></a><%# Eval("dislikes") %> <a href="#" class="ratingsicon"><i class="fas fa-comment"></i></a><%# Eval("comments") %> </h5>
                    </div>
                </div> 
            </itemtemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Post]"></asp:SqlDataSource>

        <style>
            a {
                text-decoration: none;
                color: black;
            }

            .card-title {
                margin-top: -10px;
            }

            .card {
                width: 50%;
                margin: auto;
                margin-bottom: 10px;
                text-align: left;
            }

            #postbutton {
                width: 50%;
                margin: auto;
                margin-bottom: 30px;
                border-radius: 8px;
            }

            .usertitle {
                display: inline-block;
            }

            .ratingsicon {
                display: inline-flex;
                height: 25px;
                width: 25px;
                justify-content: center;
                align-items: center;
            }

            .usericon {
                display: inline-flex;
                height: 28px;
                width: 28px;
                border-radius: 50%;
                text-decoration: none;
                justify-content: center;
                align-items: center;
                background-color: darkgray;
                cursor: pointer;
                color: black;
                margin-right: 10px;
            }

            .searchbar {
                margin-bottom: auto;
                margin: auto;
                margin-top: 80px;
                margin-bottom: 50px;
                height: 60px;
                background-color: cornflowerblue;
                border-radius: 8px;
                padding: 10px;
            }

            ::placeholder {
                color: white;
            }

            .searchinput {
                color: white;
                border: 0;
                outline: 0;
                width: 450px;
                background: none;
                padding: 0 10px;
                caret-color: red;
                line-height: 40px;
            }

            .searchbar:hover > .search_icon {
                background: white;
                color: grey;
            }

            .searchicon {
                height: 40px;
                width: 40px;
                float: right;
                display: flex;
                justify-content: center;
                align-items: center;
                border-radius: 50%;
                color: white;
                text-decoration: none;
                background-color: dimgray;
            }
        </style>
    </form>
</asp:Content>
