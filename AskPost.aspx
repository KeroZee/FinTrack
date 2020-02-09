<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="AskPost.aspx.cs" Inherits="FinTrack.AskPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
<div class="card">
        <h5 class="card-header">
            
            <b>[<asp:Label runat="server" ID="LblCategory"></asp:Label>]</b> - <asp:Label runat="server" ID="LblTitle"></asp:Label>
            <div class="btn-group dropleft" style="float:right">
                    <a data-toggle="dropdown" aria-expanded="false">
                        <i class="fa fa-ellipsis-h"></i>
                    </a>
                    <div class="dropdown-menu">
                        <asp:Button ID="BtnEdit" runat="server" Text="Edit" CssClass="dropdown-item" OnClick="BtnEdit_Click" />
                        <asp:Button ID="BtnDelete" runat="server" Text="Delete" CssClass="dropdown-item" OnClick="BtnDelete_Click" />
                        <asp:LinkButton ID="BtnReportPost" runat="server" Text="Report" CssClass="dropdown-item"></asp:LinkButton>
                    </div>
                </div>
        </h5>
        <div class="card-body">
            <p class="card-title">
                <asp:Label ID="LblContent" runat="server"></asp:Label>
                
            </p>
            <h5 class="card-text"><a href="#" class="usericon">
                <i class="fas fa-user"></i></a><a href="#" class="usertitle"><asp:Label ID="LblUsername" runat="server"></asp:Label></a>&nbsp;- posted on the
                <asp:Label ID="LblDate" runat="server"></asp:Label>
            </h5>
            <h5 class="card-text">
                <asp:LinkButton ID="LbtnLike" CssClass="ratingsicon" CommandName='' runat="server" OnClick="LbtnLike_Click"><i class="fas fa-thumbs-up"></i></asp:LinkButton><asp:Label ID="LblLikes" runat="server"></asp:Label>
                <asp:LinkButton ID="LbtnDislike" CssClass="ratingsicon" CommandName='' runat="server" OnClick="LbtnDislike_Click" ><i class="fas fa-thumbs-down"></i></asp:LinkButton><asp:Label ID="LblDislikes" runat="server"></asp:Label>
                <p class="ratingsicon"><i class="fas fa-comment"></i></p><asp:Label ID="LblComments" runat="server"></asp:Label>
            </h5>

        </div>
        <div class="commentbox">
          <label for="comment">Reply:</label>
          <asp:TextBox CssClass="form-control" runat="server" ID="TbContent" Rows="3"  TextMode="MultiLine"></asp:TextBox>
          <div id="submit"><asp:Button ID="BtnReply" CssClass="btn btn-primary btn-sm" runat="server" Text="Reply" OnClick="BtnReply_Click"/></div>
            
              
            
        </div>
        <hr>
        <asp:Repeater ID="PostRepeater" runat="server">
             <itemtemplate>
                 <div class="card-body" id="usercomment"><%# Eval("content") %><br /><h5 class="card-text"><a href="#" class="usericon"><i class="fas fa-user"></i></a><a href="#" class="usertitle"><%# Eval("username") %></a> - posted on the <%# Eval("datePosted") %></h5> 
                    <h5 class="card-text"><a href="#" class="ratingsicon"><i class="fas fa-thumbs-up"></i></a><%# Eval("likes") %> <a href="#" class="ratingsicon"><i class="fas fa-thumbs-down"></i></a><%# Eval("dislikes") %> 
                    <div class="btn-group dropright" style="color:black; padding-left:8px;">
                    <asp:LinkButton ID="LbtnToggle" runat="server" OnClick="LbtnToggle_Click" CommandName='<%# Eval("id")%>' data-toggle="dropdown"  aria-expanded="false">
                        <i class="fa fa-ellipsis-h"></i>
                    </asp:LinkButton>
                    <div class="dropdown-menu">
                        <asp:LinkButton ID="BtnDeleteComm" runat="server" Text="Delete" Visible='<%#(Eval("accountId").ToString() == checkcomm) || (admin == "yes")%>' CommandName='<%# Eval("id")%>' CssClass="dropdown-item" OnClick="BtnDeleteComm_Click"></asp:LinkButton>
                        <asp:LinkButton ID="BtnReportComment" runat="server" Text="Report" CommandName='' CssClass="dropdown-item"></asp:LinkButton>
                    </div>
                </div>
                </div>
            </itemtemplate>
         </asp:Repeater>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Post]"></asp:SqlDataSource>
    </div>
<style>
        a{
            text-decoration:none;
            color:black;
        }
        .commentbox{
            margin:auto;
            width:95%;
            margin-bottom:20px;
        }
        #submit{
            float:right;
            margin-top:5px;
            margin-bottom:-25px;
        }
        #usercomment{
            margin-top:-20px;
            
        }
        #comment{
            resize: none;
        }
        .ratingsicon{
            display: inline-flex;
            height: 25px;
            width: 25px;
            justify-content: center;
            align-items: center;
            text-decoration:none;
            color:black;
        }
        .card{
            width:50%;
            margin:auto;
            margin-top:20px;
            margin-bottom:10px;
            text-align:left;
        }
        .usertitle{
            display:inline-block;
        }
        .usericon{
            display: inline-flex;
            height: 28px;
            width: 28px;
            border-radius: 50%;
            text-decoration:none;   
            justify-content: center;
            align-items: center;
            background-color:darkgray;
            cursor:pointer; 
            color:black;
            margin-right:10px;
        }
</style>
    </form>
    </form>
</asp:Content>
