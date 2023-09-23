<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<TransportationMvc2Project.Models.LoginModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	UYGULAMA GİRİŞİ
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Kullanıcı adı ve şifre ile uygulamaya giriş yapabilirsiniz</h2>

    <% using (Html.BeginForm("UserLogOn", "User" , FormMethod.Post)) {%>
        <%: Html.ValidationSummary(true) %>
        <%: ViewData["UserLogOnMessage"] %> 

        <fieldset>
            <legend>Uygulama Girişi</legend>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.UserName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.UserName) %>
                <%: Html.ValidationMessageFor(model => model.UserName) %>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.PassWord) %>
            </div>
            <div class="editor-field">
                <%: Html.PasswordFor(model => model.PassWord) %>
                <%: Html.ValidationMessageFor(model => model.PassWord) %>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.Role.RoleName) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("Roles", ViewData["RoleList"] as List<SelectListItem>, 
                    new { style = "width:206px;" }) %>
                <%: Html.ValidationMessageFor(model => model.Role.RoleName) %>
            </div>
            <br />
            <p>
                <input type="submit" value="GİRİŞ / LOG ON" />
            </p>
        </fieldset>
    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>
