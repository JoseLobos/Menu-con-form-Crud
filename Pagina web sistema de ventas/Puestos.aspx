<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Puestos.aspx.cs" Inherits="Pagina_web_sistema_de_ventas.Puestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <br />
</p>
<p>
</p>
<p class="text-center">
    &nbsp;</p>
<p class="text-center">
    LISTADO DE PUESTOS</p>
<p class="text-center">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id_de_Puesto" HeaderText="Id_de_Puesto" SortExpression="Id_de_Puesto" />
            <asp:BoundField DataField="Id_de_Empleado" HeaderText="Id_de_Empleado" SortExpression="Id_de_Empleado" />
            <asp:BoundField DataField="Puesto" HeaderText="Puesto" SortExpression="Puesto" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Sistema de ventasConnectionString %>" SelectCommand="SELECT [Id_de_Puesto], [Id_de_Empleado], [Puesto] FROM [Puestos]"></asp:SqlDataSource>
</p>
<p class="text-center">
    &nbsp;</p>
</asp:Content>
