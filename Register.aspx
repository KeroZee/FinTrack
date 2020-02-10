<%@ Page Title="" Language="C#" MasterPageFile="~/FinTrackMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FinTrack.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
    <div style="text-align : center" id="box">
        <h3>Register to Fintrack</h3>
         <% if ((errorList.Any()))
                { %>
            <div class="alert alert-danger mt-2" role="alert"><%=errorList[0] %> </div>
            <% } %>
        <div class="form-group" style =" margin:auto">
            <div class="my-1 pl-4">
            <label id="fname" for="TextBoxFname">First Name</label>
                <br />
            <asp:TextBox style="width:90%" ID="TextBoxFname" placeholder = "First Name" class="form-control" runat="server"></asp:TextBox>    
            </div>
            <div class="my-1 pl-4">
            <label id="lname" for="TextBoxLname">Last Name</label>
                <br />
            <asp:TextBox style="width:90%" ID="TextBoxLname" placeholder = "Last Name" class="form-control" runat="server"></asp:TextBox>    
            </div>
            <div class="my-1 pl-4">
            <label id="exampleLabelEmail" for="TextBoxEmail">Email address</label>
                <br />
            <asp:TextBox style ="width:90%" ID="TextBoxEmail" runat="server" placeholder="Email" class="form-control" TextMode="Email"></asp:TextBox>
            </div>
            <div class="my-1 pl-4">
            <label id="exampleLabelPassword" for="TextBoxPassword">Password</label>
                <br />
            <asp:TextBox style="width:90%" ID="TextBoxPassword" placeholder="Password" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
            </div>
            <div class="my-1 pl-4">
            <label id="exampleLabelCPassword" for="TextBoxCPassword">Confirm Password</label>
                <br />
            <asp:TextBox style="width:90%" ID="TextBoxCPassword" placeholder = "Confirm Password" runat="server" class="form-control" TextMode="Password"></asp:TextBox>   
            </div>
        </div>
        <div class="my-4">
        <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
        </div>
    </div>
    
    </form>
    <style>
        #fname{
            margin-right:86%;
        }
        #lname{
            margin-right:86%;
        }
        
        /*#TextBoxEmail{
            margin-left: 30px;
        }
        #TextBoxPassword{
            margin-left: 30px;
        }
        #TextBoxCPassword{
            margin-left: 30px;
        }*/
        #exampleLabelEmail{
            margin-right: 82%;
        }
        #exampleLabelPassword{
            margin-right:90%;
        }
        #exampleLabelCPassword{
            margin-right:77%;
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
