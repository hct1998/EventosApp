<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarAsistente.aspx.cs" Inherits="EventosWEB.AgregarAsistente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Asistente</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutTxt"> Rut: </label>
                        <asp:TextBox ID="Rut" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>


                    <div class="form-group">
                        <label for="nombreTxt">Nombre: </label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>

                    <div class="form-group">
                        <label for="apellidoTxt"> Apellido: </label>
                        <asp:TextBox ID="Apellido" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="edadTxt"> Edad: </label>
                        <asp:TextBox ID="Edad" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="empresaTxt"> Empresa: </label>
                        <asp:TextBox ID="Empresa" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="estadoTxt"> Estado: </label>
                        <asp:TextBox ID="Estado" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                  
                   







                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarAsistente" text="Agregar" CssClass="btn btn-primary" OnClick="AgregarAsis_Click" />

                    </div>


                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="Agregarbtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>