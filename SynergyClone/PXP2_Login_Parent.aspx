<%@ Page Title="Parent Login" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="PXP2_Login_Parent.aspx.cs" Inherits="SynergyClone.PXP2_Login_Parent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="login-container">
        <h2>Parent Login</h2>
        <div class="form-group">
            <label for="username">Username:</label>
            <input type="text" name="username" id="username" runat="server" />
        </div>
        <div class="form-group">
            <label for="password">Password:</label>
            <input type="password" name="password" id="password" runat="server" />
        </div>
        <div class="form-group">
            <asp:Button ID="LoginButton" runat="server" Text="Login" CssClass="btn btn-primary" />
        </div>
        <div class="form-links">
            <a href="PXP2_Login_Student.aspx">Student Login</a> |
            <a href="PXP2_Login_Teacher.aspx">Teacher Login</a>
        </div>
    </div>
</asp:Content>