<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nuggets.aspx.cs" Inherits="WebFormsTraining.Default" %>

<%
    Response.Write("Hello World<br>");
%>

<%: "<h1>Encoded HTML code nugget!  (<%:) </h1>" %>
<%= "<h1>Not Encoded Html code nugget!  (<%=) </h1>" %>

<%-- Read the message from AppSetting of web.config file --%>
<asp:literal Text="<%$ AppSettings: cityMessage %>" runat="server"></asp:literal>
<asp:Repeater ItemType = "System.String" SelectMethod = "GetCities" runat = "server">
    <ItemTemplate>
        <li><%#: Item %></li>
    </ItemTemplate>
</asp:Repeater>

<%= $"<br>Path of current running assembly:<br> {AssemblyDirectory}" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>

    <div>
        <span id ="mySpanx" runat ="server" >
            <p>See  mySpanx feild generated in the behind code *.aspx.designer.cs</p>
        </span>
    </div>
</body>
</html>
