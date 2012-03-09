<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Demande d'engagement de dépense
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RecapInfoContent" runat="server">
    <%: Html.Partial("RecapInfo") %>
</asp:Content>
