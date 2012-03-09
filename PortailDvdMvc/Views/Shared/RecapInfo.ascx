<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>
<table class="table table-striped table-bordered">
    <tbody>
        <tr>
            <th>Region</th>
            <td>Nom du DO</td>
        </tr>
        <tr>
            <th>Etablissement</th>
            <td>Nom Etablissement - Ville (departement)</td>
        </tr>
        <tr>
            <th>Initiateur</th>
            <td>Nom Personne qui a fait la demande d'engagement</td>
        </tr>
        <tr>
            <th>EBITDAR Budget K€</th>
            <td>(Source Budget)</td>
        </tr>
        <tr>
            <th>TO</th>
            <td>(calcul provenant des TO)</td>
        </tr>
        <tr>
            <th>Date</th>
            <td>Date du jour lors de la création : <%: DateTime.Today.ToString("dd/MM/yyyy") %></td>
        </tr>
    </tbody>
</table>

