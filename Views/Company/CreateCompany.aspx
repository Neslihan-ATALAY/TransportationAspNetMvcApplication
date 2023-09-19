<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<TransportationMvc2Project.Models.CompanyModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	YENİ ŞİRKET EKLEME
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Taşıma / Nakliyat / Lojistik Şirketi Ekleme</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Şirket Alanlarını Doldurunuz</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Name) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Name) %>
                <%: Html.ValidationMessageFor(model => model.Name) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Owner) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Owner) %>
                <%: Html.ValidationMessageFor(model => model.Owner) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Telephone) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Telephone)%>
                <%: Html.ValidationMessageFor(model => model.Telephone)%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Fax) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Fax) %>
                <%: Html.ValidationMessageFor(model => model.Fax) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Email) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Email) %>
                <%: Html.ValidationMessageFor(model => model.Email) %>
            </div>

            <fieldset><legend>Adres Alanlarını Doldurunuz</legend>
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Address.City.Name) %>
                </div>
                <div class="editor-field">
                    <%: Html.DropDownList("Cities", ViewData["CityList"] as List<SelectListItem>, 
                        new { style = "width:220px;" }) %>
                    <%: Html.ValidationMessageFor(model => model.Address.City.Name)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Address.Town)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Address.Town)%>
                    <%: Html.ValidationMessageFor(model => model.Address.Town)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Address.Neighbourhood)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Address.Neighbourhood)%>
                    <%: Html.ValidationMessageFor(model => model.Address.Neighbourhood)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Address.Street)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Address.Street)%>
                    <%: Html.ValidationMessageFor(model => model.Address.Street)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Address.HomeStreet)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Address.HomeStreet)%>
                    <%: Html.ValidationMessageFor(model => model.Address.HomeStreet)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Address.BuildingNo)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Address.BuildingNo)%>
                    <%: Html.ValidationMessageFor(model => model.Address.BuildingNo)%>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Address.InnerDoorNo)%>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Address.InnerDoorNo)%>
                    <%: Html.ValidationMessageFor(model => model.Address.InnerDoorNo)%>
                </div>
            </fieldset>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.EstablishmentDate) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.EstablishmentDate) %>
                <%: Html.ValidationMessageFor(model => model.EstablishmentDate) %>
            </div>
            
            <p>
                <input type="submit" value="KAYDET" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>
