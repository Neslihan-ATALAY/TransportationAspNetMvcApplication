<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<TransportationMvc2Project.Models.VehicleEmployeeModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ARAÇ - PERSONEL EKLEME
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="pagemenucontainer" style="background-color:#5c87b2">
        <ul id="menu">
            <% if (Page.User.Identity.IsAuthenticated && Page.User.IsInRole("ŞİRKET")) { %>
                <li style="text-align:left;"><%: Html.ActionLink("Araç", "CreateVehicle", "Vehicle") %> </li>
		        <li style="text-align:left;"><%: Html.ActionLink("Personel", "CreateEmployee", "Employee") %> </li>
		        <li style="text-align:left;"><%: Html.ActionLink("Araç-Personel", "VehicleEmployee", "Employee") %> </li>
            <% } %>
        </ul>
    </div>

    <h2>Araç Personel Ekleme</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Alanları Doldurunuz</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Vehicle.PlateNumber)%>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("Vehicles", ViewData["VehicleList"] as List<SelectListItem>, 
                    new { style = "width:50%;" }) %>
                <%: Html.ValidationMessageFor(model => model.Vehicle.PlateNumber) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Employee.IdentityNumber)%>
            </div>
            <div class="editor-field">
                <%: Html.ListBox("Employees", ViewData["EmployeeList"] as List<SelectListItem>, 
                    new { style = "width:50%; height:300px;" })%>
                <%: Html.ValidationMessageFor(model => model.Employee.IdentityNumber) %>
            </div>
            <br />
            <p>
                <input type="submit" value="ARAÇ-PERSONEL KAYDET" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>
