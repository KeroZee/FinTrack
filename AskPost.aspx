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
                <a href="#" class="ratingsicon"><i class="fas fa-thumbs-up"></i></a><asp:Label ID="LblLikes" runat="server"></asp:Label>
                <a href="#" class="ratingsicon"><i class="fas fa-thumbs-down"></i></a><asp:Label ID="LblDislikes" runat="server"></asp:Label>
                <a href="#" class="ratingsicon"><i class="fas fa-comment"></i></a><asp:Label ID="LblComments" runat="server"></asp:Label>
            </h5>

        </div>
        <div class="commentbox">
          <label for="comment">Reply:</label>
          <textarea class="form-control" rows="3" id="comment"></textarea>
          <div id="submit"><input class="btn btn-primary btn-sm" type="submit" value="Reply"></div>
            
              
            
        </div>
        <hr>
        <div class="card-body" id="usercomment">Just do it<br /><h5 class="card-text"><a href="#" class="usericon"><i class="fas fa-user"></i></a><a href="#" class="usertitle">Ron Low</a> - posted on the 2/1/2020</h5> 
            <h5 class="card-text"><a href="#" class="ratingsicon"><i class="fas fa-thumbs-up"></i></a>3 <a href="#" class="ratingsicon"><i class="fas fa-thumbs-down"></i></a>1 <a href="#" class="ratingsicon"><i class="fas fa-reply"></i></a>REPLY</h5>
        </div>
        <div class="card-body" id="usercomment">What kind of stuff???<br /><h5 class="card-text"><a href="#" class="usericon"><i class="fas fa-user"></i></a><a href="#" class="usertitle">Brian Row</a> - posted on the 5/1/2020</h5> 
            <h5 class="card-text"><a href="#" class="ratingsicon"><i class="fas fa-thumbs-up"></i></a>0 <a href="#" class="ratingsicon"><i class="fas fa-thumbs-down"></i></a>0 <a href="#" class="ratingsicon"><i class="fas fa-reply"></i></a>REPLY</h5>
        </div>

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
</asp:Content>
