<%@ Page Title="Student Dashboard" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="SynergyClone.StudentVUE.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="dashboard-container">
        <h2>Welcome, <asp:Literal ID="StudentName" runat="server" /></h2>
        
        <div class="dashboard-section">
            <h3>Current Classes</h3>
            <asp:GridView ID="CoursesGrid" runat="server" AutoGenerateColumns="False" CssClass="grid-view">
                <Columns>
                    <asp:BoundField DataField="Period" HeaderText="Period" />
                    <asp:BoundField DataField="CourseCode" HeaderText="Course Code" />
                    <asp:BoundField DataField="Name" HeaderText="Course Name" />
                    <asp:BoundField DataField="Teacher.LastName" HeaderText="Teacher" />
                    <asp:BoundField DataField="RoomNumber" HeaderText="Room" />
                    <asp:TemplateField HeaderText="Grade">
                        <ItemTemplate>
                            <asp:Label ID="GradeLabel" runat="server" Text='<%# GetCourseGrade(Container.DataItem) %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <div class="dashboard-section">
            <h3>Recent Assignments</h3>
            <asp:GridView ID="AssignmentsGrid" runat="server" AutoGenerateColumns="False" CssClass="grid-view">
                <Columns>
                    <asp:BoundField DataField="Course.Name" HeaderText="Course" />
                    <asp:BoundField DataField="Name" HeaderText="Assignment" />
                    <asp:BoundField DataField="DueDate" HeaderText="Due Date" DataFormatString="{0:MM/dd/yyyy}" />
                    <asp:TemplateField HeaderText="Score">
                        <ItemTemplate>
                            <asp:Label ID="ScoreLabel" runat="server" Text='<%# GetAssignmentScore(Container.DataItem) %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <div class="dashboard-section">
            <h3>Recent Attendance</h3>
            <asp:GridView ID="AttendanceGrid" runat="server" AutoGenerateColumns="False" CssClass="grid-view">
                <Columns>
                    <asp:BoundField DataField="Date" HeaderText="Date" DataFormatString="{0:MM/dd/yyyy}" />
                    <asp:BoundField DataField="Course.Name" HeaderText="Course" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                    <asp:BoundField DataField="Notes" HeaderText="Notes" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>