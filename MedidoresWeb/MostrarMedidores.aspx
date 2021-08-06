<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarMedidores.aspx.cs" Inherits="MedidoresWeb.MostrarMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row mt-5">
        <div class="col-lg-6-mx-auto">
            <asp:DropDownList ID="usuarioDDL" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="row mt-5">
        <asp:GridView ID="grillaMedidores"
            OnRowCommand="grillaMedidores_RowCommand"
            CssClass="table table-hover table-bordered"
            AutoGenerateColumns="false"
            ShowHeaderWhenEmpty="true"
            EmptyDataText="No hay registros"
            runat="server">
        <Columns>
            <asp:BoundField HeaderText="Id de medidor" DataField="Id_medidor" />
            <asp:BoundField HeaderText="Id de usuario" DataField="Id_usuario_fk" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnEliminar" CommandName="eliminar" CommandArgument='<%# Eval("Id_medidor") %>' runat="server" CssClass="btn btn-danger" Text="Eliminar" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
            </asp:GridView>
    </div>

</asp:Content>
