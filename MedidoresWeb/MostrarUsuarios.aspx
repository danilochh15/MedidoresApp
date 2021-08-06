<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarUsuarios.aspx.cs" Inherits="MedidoresWeb.MostrarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row mt-5">
        <div class="col-lg-6-mx-auto">
            <asp:DropDownList ID="usuarioDDL" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="row mt-5">
        <asp:GridView ID="grillaUsuarios"
            OnRowCommand="grillaUsuarios_RowCommand"
            CssClass="table table-hover table-bordered"
            AutoGenerateColumns="false"
            ShowHeaderWhenEmpty="true"
            EmptyDataText="No hay registros"
            runat="server">
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id_usuario"/>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
            <asp:BoundField HeaderText="Rut" DataField="Rut" />
            <asp:BoundField HeaderText="Contrasena" DataField="Contrasena" />
            <asp:BoundField HeaderText="Email" DataField="Email" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnEliminar" CommandName="eliminar" CommandArgument='<%# Eval("Id_usuario") %>' runat="server" CssClass="btn btn-danger" Text="Eliminar" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
            </asp:GridView>
    </div>

</asp:Content>
