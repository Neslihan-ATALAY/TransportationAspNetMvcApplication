<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<TransportationMvc2Project.Models.ApplicationModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	YENİ TALEP EKLEME
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="pagemenucontainer" style="background-color:#5c87b2">
        <ul id="menu">
            <% if (Page.User.Identity.IsAuthenticated && Page.User.IsInRole("KULLANICI")) { %>
                <li style="text-align:left;"><%: Html.ActionLink("Taşıma Talep", "CreateTransport", "Transport") %> </li>
            <% } %>
        </ul>
    </div>

    <h2>Taşıma / Nakliyat Talebi Ekleme</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Alanları Doldurunuz</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.User.Name) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("Users", ViewData["UserList"] as List<SelectListItem>, 
                    new { style = "width:400px;" }) %>
                <%: Html.ValidationMessageFor(model => model.User.Name) %>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.TransportType.Type) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("TransportTypes", ViewData["TransportTypeList"] as List<SelectListItem>, 
                    new { style = "width:400px;" }) %>
                <%: Html.ValidationMessageFor(model => model.TransportType.Type) %>
            </div>

            <div class="editor-label">
                <%: Html.Label("Araç / Araçlar Seçiniz") %>
            </div>
            <div class="editor-field">
                <%: Html.ListBox("Vehicles", ViewData["VehicleList"] as List<SelectListItem>,
                    new { style = "width:400px; height:250px" }) %>
                <%: Html.ValidationMessage("Araç Seçilemedi") %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.TransportDate) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.TransportDate) %>
                <%: Html.ValidationMessageFor(model => model.TransportDate) %>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.Weight) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Weight) %>
                <%: Html.ValidationMessageFor(model => model.Weight) %>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.Distance) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Distance) %>
                <%: Html.ValidationMessageFor(model => model.Distance) %>
            </div>

            <fieldset>
                <legend>BAŞLANGIÇ ADRESİ ALANLARINI DOLDURUNUZ</legend>

                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Departure.City.Name) %>
                </div>
                <div class="editor-field">
                    <%: Html.DropDownList("DepartureCities", ViewData["CityList"] as List<SelectListItem>, 
                        new { style = "width:206px;" }) %>
                    <%: Html.ValidationMessageFor(model => model.Departure.City.Name)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Departure.Town)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Departure.Town)%>
                    <%: Html.ValidationMessageFor(model => model.Departure.Town)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Departure.Neighbourhood)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Departure.Neighbourhood)%>
                    <%: Html.ValidationMessageFor(model => model.Departure.Neighbourhood)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Departure.Street)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Departure.Street)%>
                    <%: Html.ValidationMessageFor(model => model.Departure.Street)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Departure.HomeStreet)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Departure.HomeStreet)%>
                    <%: Html.ValidationMessageFor(model => model.Departure.HomeStreet)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Departure.BuildingNo)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Departure.BuildingNo)%>
                    <%: Html.ValidationMessageFor(model => model.Departure.BuildingNo)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Departure.InnerDoorNo)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Departure.InnerDoorNo)%>
                    <%: Html.ValidationMessageFor(model => model.Departure.InnerDoorNo)%>
                </div>
            </fieldset>

            <fieldset>
                <legend>VARIŞ ADRESİ ALANLARINI DOLDURUNUZ</legend>

                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Destination.City.Name) %>
                </div>
                <div class="editor-field">
                    <%: Html.DropDownList("DestinationCities", ViewData["CityList"] as List<SelectListItem>, 
                        new { style = "width:206px;" }) %>
                    <%: Html.ValidationMessageFor(model => model.Destination.City.Name)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Destination.Town)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Destination.Town)%>
                    <%: Html.ValidationMessageFor(model => model.Destination.Town)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Destination.Neighbourhood)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Destination.Neighbourhood)%>
                    <%: Html.ValidationMessageFor(model => model.Destination.Neighbourhood)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Destination.Street)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Destination.Street)%>
                    <%: Html.ValidationMessageFor(model => model.Destination.Street)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Destination.HomeStreet)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Destination.HomeStreet)%>
                    <%: Html.ValidationMessageFor(model => model.Destination.HomeStreet)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Destination.BuildingNo)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Destination.BuildingNo)%>
                    <%: Html.ValidationMessageFor(model => model.Destination.BuildingNo)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Destination.InnerDoorNo)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Destination.InnerDoorNo)%>
                    <%: Html.ValidationMessageFor(model => model.Destination.InnerDoorNo)%>
                </div>
            </fieldset>
            <br />
            <p>
                <input type="submit" value="TAŞIMA TALEBİ KAYDET" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>
