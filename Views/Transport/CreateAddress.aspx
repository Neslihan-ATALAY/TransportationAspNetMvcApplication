<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<TransportationMvc2Project.Models.AddressModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	YENİ ADRES EKLEME
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Adres Ekleme</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Adres Alanlarını Doldurunuz</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.City.Name) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("Cities", ViewData["CityList"] as List<SelectListItem>, 
                    new { style = "width:220px;" }) %>
                <%: Html.ValidationMessageFor(model => model.City.Name) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Town) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Town) %>
                <%: Html.ValidationMessageFor(model => model.Town) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Neighbourhood) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Neighbourhood) %>
                <%: Html.ValidationMessageFor(model => model.Neighbourhood) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Street) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Street) %>
                <%: Html.ValidationMessageFor(model => model.Street) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.HomeStreet) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.HomeStreet) %>
                <%: Html.ValidationMessageFor(model => model.HomeStreet) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.BuildingNo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.BuildingNo) %>
                <%: Html.ValidationMessageFor(model => model.BuildingNo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.InnerDoorNo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.InnerDoorNo) %>
                <%: Html.ValidationMessageFor(model => model.InnerDoorNo) %>
            </div>
            
            <p>
                <input type="submit" value="ADRESİ KAYDET" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>
