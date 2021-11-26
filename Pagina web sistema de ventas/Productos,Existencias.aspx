<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos,Existencias.aspx.cs" Inherits="Pagina_web_sistema_de_ventas.Productos_Existencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p>
</p>
<p>
</p>
<p class="text-center">
    &nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p class="text-center">
    LISTADO DE PRODUCTOS</p>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Codigo_Producto" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Codigo_Producto" HeaderText="Codigo_Producto" ReadOnly="True" SortExpression="Codigo_Producto" />
            <asp:BoundField DataField="Nombre_del_Producto" HeaderText="Nombre_del_Producto" SortExpression="Nombre_del_Producto" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
            <asp:BoundField DataField="Valor_Unitario" HeaderText="Valor_Unitario" SortExpression="Valor_Unitario" />
            <asp:BoundField DataField="Valor_Total" HeaderText="Valor_Total" SortExpression="Valor_Total" />
            <asp:BoundField DataField="Codigo_de_Barra" HeaderText="Codigo_de_Barra" SortExpression="Codigo_de_Barra" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Sistema de ventasConnectionString %>" SelectCommand="SELECT * FROM [Productos]"></asp:SqlDataSource>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p class="text-center">
    LISTADO DE EXISTENCIAS</p>
    <p class="text-center">
        &nbsp;&nbsp;&nbsp; &nbsp;</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <div class="text-left">
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Cantidad" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="Id_Producto" HeaderText="Id_Producto" SortExpression="Id_Producto" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" ReadOnly="True" SortExpression="Cantidad" />
            <asp:BoundField DataField="Codigo_de_Barra" HeaderText="Codigo_de_Barra" SortExpression="Codigo_de_Barra" />
            <asp:BoundField DataField="Nombre_del_Producto" HeaderText="Nombre_del_Producto" SortExpression="Nombre_del_Producto" />
        </Columns>
    </asp:GridView>
    </div>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Sistema de ventasConnectionString %>" SelectCommand="SELECT * FROM [Existencias1]"></asp:SqlDataSource>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
