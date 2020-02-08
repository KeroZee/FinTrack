<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Ask.aspx.cs" Inherits="FinTrack.Ask" MaintainScrollPositionOnPostback="true" %>

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
            Ask a Question
        
        </button>
        <div class="form-group" style="">
            <asp:Label runat="server" CssClass="labelcate" ID="LblCategory">Results</asp:Label>
            <div style="display: inline-block; float: right; margin-top: -7px;">
                <asp:DropDownList ID="DdlCategory" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="DdlCategory_SelectedIndexChanged">
                    <asp:ListItem Value="">Sort By All Category</asp:ListItem>
                    <asp:ListItem Value="Finance">Sort By Finance</asp:ListItem>
                    <asp:ListItem Value="Career">Sort By Career</asp:ListItem>
                    <asp:ListItem Value="Insurance">Sort By Insurance</asp:ListItem>
                    <asp:ListItem Value="Property">Sort By Property</asp:ListItem>
                    <asp:ListItem Value="Misc">Sort By Misc</asp:ListItem>
                </asp:DropDownList>
                <div class="dropdown" style="display: inline-block">
                    
                    <asp:DropDownList ID="DdlSort" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="DdlSort_SelectedIndexChanged">
                    <asp:ListItem Value="">Most Popular</asp:ListItem>
                    <asp:ListItem Value="Recent">Most Recent</asp:ListItem>
                    <asp:ListItem Value="Oldest">Oldest</asp:ListItem>
                </asp:DropDownList>
                </div>
            </div>
        </div>
        <asp:ScriptManager ID="MainScriptManager" runat="server" />
        <asp:UpdatePanel ID="pnlHelloWorld" runat="server">
            <contenttemplate>
        <asp:Repeater ID="PostRepeater" runat="server">
            <itemtemplate>
                <div class="card">
                    <h5 class="card-header">
                    <b>[<%# Eval("category")%>]</b> - <asp:LinkButton ID="LbTitle" Text='<%# Eval("title")%>' CommandName='<%# Eval("id")%>' runat="server" OnClick="LbTitle_Click"></asp:LinkButton></h5>
                    <div class="card-body">   
                    <p class="card-title"><%# Eval("content ") %></p>
                    <h5 class="card-text"><a href="#" class="usericon"><i class="fas fa-user"></i></a><a href="#" class="usertitle"> <%# Eval("username") %>     
                        </a> - posted on the <%# Convert.ToDateTime(Eval("datePosted")).ToString("d/M/yyyy") %></h5>
                    <h5 class="card-text"><asp:LinkButton ID="LbtnLike" CssClass="ratingsicon" CommandName='<%# Eval("id")%>' runat="server" OnClick="LbtnLike_Click"><i class="fas fa-thumbs-up"></i></asp:LinkButton><%# Eval("likes") %> <asp:LinkButton ID="LbtnDislike" CssClass="ratingsicon" CommandName='<%# Eval("id")%>' runat="server" OnClick="LbtnDislike_Click" ><i class="fas fa-thumbs-down"></i></asp:LinkButton><%# Eval("dislikes") %> <asp:LinkButton ID="LbtnComm" CssClass="ratingsicon" CommandName='<%# Eval("id")%>' runat="server" OnClick="LbTitle_Click"><i class="fas fa-comment"></i></asp:LinkButton><%# Eval("comments") %> </h5>
                    </div>
                </div> 
            </itemtemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Post]"></asp:SqlDataSource>
       <div class="d-flex justify-content-center h-100">
                    <table style="width: 600px; margin-left:100px;">
                        <tr>
                            <td>
                                <asp:LinkButton ID="lbFirst" runat="server" OnClick="lbFirst_Click">First</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lbPrevious" runat="server" OnClick="lbPrevious_Click">Previous</asp:LinkButton>
                            </td>
                            <td>
                                <asp:DataList ID="rptPaging" runat="server" OnItemCommand="rptPaging_ItemCommand" OnItemDataBound="rptPaging_ItemDataBound" RepeatDirection="Horizontal">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbPaging" runat="server" CommandArgument='<%# Eval("PageIndex") %>' CommandName="newPage" Text='<%# Eval("PageText") %> ' Width="20px"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:DataList>
                            </td>
                            <td>
                                <asp:LinkButton ID="lbNext" runat="server" OnClick="lbNext_Click">Next</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lbLast" runat="server" OnClick="lbLast_Click">Last</asp:LinkButton>
                            </td>
                            <td>
                                <asp:Label ID="lblpage" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>

                </div>
            </contenttemplate>
        </asp:UpdatePanel>
        <style>
            .btn {
                padding: 0;
            }

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

            .labelcate {
                display: inline-block;
                padding-top: 4px;
            }

            .form-control {
                display: inline-block;
                border-radius: 8px;
                width: auto;
            }

            .form-group {
                margin: auto;
                margin-bottom: 30px;
                width: 50%;
            }

            .selectpicker {
                padding: 10px;
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
