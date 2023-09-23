<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Request.IsAuthenticated)
    {
%>
        Welcome <b><%: Page.User.Identity.Name %></b>
        [ <%: Html.ActionLink("Çıkış", "UserLogOff", "User") %> ]
<%
    }
    else
    {
%> 
        [ <%: Html.ActionLink("Kullanıcı Girişi", "UserLogOn", "User") %> ]
<%
    }
%>
