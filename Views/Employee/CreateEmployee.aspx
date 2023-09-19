<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<TransportationMvc2Project.Models.EmployeeModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	YENİ PERSONEL EKLEME
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Çalışan Personel Ekleme</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Alanları Doldurunuz</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Name) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Name) %>
                <%: Html.ValidationMessageFor(model => model.Name) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Surname) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Surname) %>
                <%: Html.ValidationMessageFor(model => model.Surname) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdentityNumber) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdentityNumber) %>
                <%: Html.ValidationMessageFor(model => model.IdentityNumber) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Telephone) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Telephone) %>
                <%: Html.ValidationMessageFor(model => model.Telephone) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Email) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Email) %>
                <%: Html.ValidationMessageFor(model => model.Email) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Gender) %>
            </div>
            <div class="editor-field">
                <%: Html.RadioButtonFor(model => model.Gender, "K", "K") %>
                <%: Html.RadioButtonFor(model => model.Gender, "E", "E") %>
                <%: Html.ValidationMessageFor(model => model.Gender) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.BirthDate) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.BirthDate) %>
                <%: Html.ValidationMessageFor(model => model.BirthDate) %>
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
                <%: Html.LabelFor(model => model.Company.Name) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("Companies", ViewData["CompanyList"] as List<SelectListItem>, 
                    new { style = "width:250px;" }) %>
                <%: Html.ValidationMessageFor(model => model.Company.Name)%>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.EmployeeType.Type) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("EmployeeTypes", ViewData["EmployeeTypeList"] as List<SelectListItem>, 
                    new { style = "width:250px;" }) %>
                <%: Html.ValidationMessageFor(model => model.EmployeeType.Type)%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.DriverLicenseGroup) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.DriverLicenseGroup) %>
                <%: Html.ValidationMessageFor(model => model.DriverLicenseGroup) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.DriverLicenseNumber) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.DriverLicenseNumber) %>
                <%: Html.ValidationMessageFor(model => model.DriverLicenseNumber) %>
            </div>
            
            <p>
                <input type="submit" value="PERSONEL EKLE" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>
