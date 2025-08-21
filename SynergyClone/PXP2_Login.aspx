<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="PXP2_Login.aspx.cs" Inherits="SynergyClone.PXP2_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="login-container">
        <h2>Welcome to SynergyClone</h2>
        <div class="user-selection">
            <h3>Please select your user type:</h3>
            <div class="login-options">
                <a href="PXP2_Login_Student.aspx" class="btn btn-primary">Student Login</a>
                <a href="PXP2_Login_Parent.aspx" class="btn btn-primary">Parent Login</a>
                <a href="PXP2_Login_Teacher.aspx" class="btn btn-primary">Teacher Login</a>
            </div>
        </div>
    </div>
</asp:Content>