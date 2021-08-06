<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMedidor.aspx.cs" Inherits="MedidoresWeb.AgregarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card" >
                <div class="card-header bg-primary text-white" >
                    <h3>Ingresar medidor</h3>
                    <div class="card-body">
                        <!--  
                        <div class="form-group">
                            <label for="idUsuarioFkTxt">Id de usuario</label>
                            <asp:TextBox ID="idUsuarioFkTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        
                        <div class="form-group">
                            <label for="idUsuarioRb1" >Id usuario </label>
                            <asp:RadioButtonList ID="idUsuarioRb1" runat="server">
                                <asp:ListItem Text ="Primer item" Selected="True" Value="Primer item"></asp:ListItem>
                            </asp:RadioButtonList>
                        </div> -->
                        <div class="form-group">
                            <label for="usuarioDDL">Asignar a usuario</label>
                            <asp:DropDownList ID="usuarioDDL" runat="server"></asp:DropDownList>
                        </div>
                        <asp:Button OnClick="ingresarBtn_Click" runat="server" CssClass="btn btn-secondary" ID="ingresarBtn" Text="Ingresar" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
