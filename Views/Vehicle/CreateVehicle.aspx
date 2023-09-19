<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<TransportationMvc2Project.Models.VehicleModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	YENİ ARAÇ EKLEME
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Araç Ekleme</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Alanları Doldurunuz</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.PlateNumber) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.PlateNumber) %>
                <%: Html.ValidationMessageFor(model => model.PlateNumber) %>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.TransportType.Type) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("TransportTypes", ViewData["TransportTypeList"] as List<SelectListItem>, 
                    new { style = "width:220px;" }) %>
                <%: Html.ValidationMessageFor(model => model.TransportType.Type)%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.VehicleType.Type) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("VehicleTypes", ViewData["VehicleTypeList"] as List<SelectListItem>, 
                    new { style = "width:220px;" }) %>
                <%: Html.ValidationMessageFor(model => model.VehicleType.Type)%>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.Company.Name) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("Companies", ViewData["CompanyList"] as List<SelectListItem>, 
                    new { style = "width:220px;" }) %>
                <%: Html.ValidationMessageFor(model => model.Company.Name)%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.WeightCapacity) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.WeightCapacity) %>
                <%: Html.ValidationMessageFor(model => model.WeightCapacity) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.UnitPrice) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.UnitPrice) %>
                <%: Html.ValidationMessageFor(model => model.UnitPrice) %>
            </div>
            
            <p>
                <input type="submit" value="ARAÇ KAYDET" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>
