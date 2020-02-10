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
            <label id="fname" for="TextBoxFname">First Name</label>
            <asp:TextBox style="width:90%" ID="TextBoxFname" placeholder = "First Name" runat="server"></asp:TextBox>    
        </div>
        <div class="form-group" style =" margin:auto">
            <label id="lname" for="TextBoxLname">Last Name</label>
            <asp:TextBox style="width:90%" ID="TextBoxLname" placeholder = "Last Name" runat="server"></asp:TextBox>    
        </div>
        <div class="form-group" style="margin:auto">
            <label id="exampleLabelEmail" for="TextBoxEmail">Email address</label>
            <asp:TextBox style ="width:90%" ID="TextBoxEmail" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>
         </div>
        <div class="form-group" style="margin:auto">
            <label id="exampleLabelPassword" for="TextBoxPassword">Password</label>
            <asp:TextBox style="width:90%" ID="TextBoxPassword" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group" style =" margin:auto">
            <label id="exampleLabelCPassword" for="TextBoxCPassword">Confirm Password</label>
            <asp:TextBox style="width:90%" ID="TextBoxCPassword" placeholder = "Confirm Password" runat="server" TextMode="Password"></asp:TextBox>    
        </div>
        

        <%--<button id ="Submit" type="submit" class="btn btn-primary">Submit</button>--%>
        
        <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
        
    </div>
    
    </form>
    <style>
        #fname{
            margin-right:78%;
        }
        #lname{
            margin-right:78%;
        }
        #TextBoxEmail{
            margin-left: 30px;
        }
        #TextBoxPassword{
            margin-left: 30px;
        }
        #TextBoxCPassword{
            margin-left: 30px;
        }
        #exampleLabelEmail{
            margin-right: 75%;
        }
        #exampleLabelPassword{
            margin-right:80%;
        }
        #exampleLabelCPassword{
            margin-right:70%;
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
