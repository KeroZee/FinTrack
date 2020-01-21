<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="AskSearch.aspx.cs" Inherits="FinTrack.AskSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <div class="container h-100">
      <div class="d-flex justify-content-center h-100">
        <div class="searchbar">
          <input class="searchinput" type="text" name="" placeholder="Search..." value="stuff">
          <a href="AskSearch.aspx" class="searchicon"><i class="fas fa-search"></i></a>
        </div>
      </div>
    </div>
    <div class="card">
        <h5 class="card-header"><a href="AskPost.aspx">How do i do <b>stuff</b>?</a></h5>
        <div class="card-body">
            <p class="card-title">As the title says how do i do <b>stuff</b>...</p>
            <h5 class="card-text"><a href="#" class="usericon"><i class="fas fa-user"></i></a><a href="#" class="usertitle">John Doe</a> - posted on the 1/1/2020</h5>
            <h5 class="card-text"><a href="#" class="ratingsicon"><i class="fas fa-thumbs-up"></i></a>220 <a href="#" class="ratingsicon"><i class="fas fa-thumbs-down"></i></a>32 <a href="#" class="ratingsicon"><i class="fas fa-comment"></i></a>2</h5>        
        </div>
    </div>
    <div class="card">
        
        <h5 class="card-header"><a href="#">How do i do more <b>stuff</b>?</a></h5>
        <div class="card-body">
            <p class="card-title">As the title says how do i do more <b>stuff</b>.</p>
            <h5 class="card-text"><a href="#" class="usericon"><i class="fas fa-user"></i></a><a href="#" class="usertitle">Ron Snow</a> - posted on the 1/1/2020</h5>
            <h5 class="card-text"><a href="#" class="ratingsicon"><i class="fas fa-thumbs-up"></i></a>133 <a href="#" class="ratingsicon"><i class="fas fa-thumbs-down"></i></a>12 <a href="#" class="ratingsicon"><i class="fas fa-comment"></i></a>0</h5>
        </div>
    </div>
    <div class="card">
        
        <h5 class="card-header"><a href="#">Cool <b>stuff</b></a></h5>
        <div class="card-body">
            <p class="card-title">Very cool.</p>
            <h5 class="card-text"><a href="#" class="usericon"><i class="fas fa-user"></i></a><a href="#" class="usertitle">Jon Low</a> - posted on the 1/1/2020</h5>
            <h5 class="card-text"><a href="#" class="ratingsicon"><i class="fas fa-thumbs-up"></i></a>33 <a href="#" class="ratingsicon"><i class="fas fa-thumbs-down"></i></a>1 <a href="#" class="ratingsicon"><i class="fas fa-comment"></i></a>0</h5>
        </div>
    </div>

    
    <style>
        a{
            text-decoration:none;
            color:black;
        }
        .card{
            width:50%;
            margin:auto;
            margin-bottom:10px;
            text-align:left;
            margin-top:20px;
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
        .ratingsicon{
            display: inline-flex;
            height: 25px;
            width: 25px;
            justify-content: center;
            align-items: center;
        }
        .searchbar{
            margin:auto;
            margin-top: 20px;
            margin-bottom: 20px;
            height: 60px;
            background-color: cornflowerblue;
            border-radius: 8px;
            padding: 10px;
    
        }
        ::placeholder{
            color:white;
        }
        .searchinput{
            color: white;
            border: 0;
            outline: 0;
            width: 450px;
            background: none;
            padding: 0 10px;
            caret-color:red;
            line-height: 40px;
        }

        .searchbar:hover > .search_icon{
            background: white;
            color:grey;
        }

        .searchicon{
            height: 40px;
            width: 40px;
            float: right;
            display: flex;
            justify-content: center;
            align-items: center;
            border-radius: 50%;
            color:white;
            text-decoration:none;
            background-color:dimgray;
        }
    </style>
</asp:Content>
