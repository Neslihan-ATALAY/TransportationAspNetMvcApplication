<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    ANA SAYFA
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        <br /><br />
        HACKATHON - TRANSPORTATHON APPLICATION
        <br /><br /><br /><br />
        YARIŞMA - NAKLİYAT UYGULAMASI
    </p>
</asp:Content>
