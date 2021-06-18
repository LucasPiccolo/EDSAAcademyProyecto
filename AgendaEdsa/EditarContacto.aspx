<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarContacto.aspx.cs" Inherits="AgendaEdsa.EditarContacto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="StyleABM.css" rel="stylesheet" type="text/css">
    <title>Editar Contacto</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4" crossorigin="anonymous"></script>
    <h1>Editar contacto</h1>

</head>
<body>
    <div class="card card-filter">
        <div class="body">
            <form runat="server">
                <div class="row">
                    <div class="col">
                        <div class="row mb-3">
                            <label for="apellidoYNombreInput" class="col-md-5">Apellido y Nombre:</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="ApellidoYNombreText" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row mb-3">
                            <label for="GeneroSelect" class="col-md-4">Genero:</label>
                            <div class="col-md-7">
                                <asp:DropDownList runat="server" ID="GeneroSelect" class="form-select">
                                    <asp:ListItem Value="0" Text="Todos" Selected="True" />
                                    <asp:ListItem Value="1" Text="Masculino" />
                                    <asp:ListItem Value="2" Text="Femenino" />
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row mb-3">
                            <label for="PaisSelect" class="col-md-4">Pais:</label>
                            <div class="col-md-7">
                                <asp:DropDownList runat="server" ID="PaisSelect" class="form-select">
                                    <asp:ListItem Value="0" Text="Todos" Selected="True" />
                                    <asp:ListItem Value="1" Text="Argentina" />
                                    <asp:ListItem Value="2" Text="Brasil" />
                                    <asp:ListItem Value="2" Text="Chile" />
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <div class="row mb-3">
                            <label for="LocalidadInput" class="col-md-5">Localidad:</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="LocalidadText" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row mb-3">
                            <label for="ContactoInternoSelect" class="col-md-4">Contacto Interno:</label>
                            <div class="col-md-7">
                                <asp:DropDownList runat="server" ID="ContactoInternoSelect" class="form-select">
                                    <asp:ListItem Value="0" Text="Todos" Selected="True" />
                                    <asp:ListItem Value="1" Text="Si" />
                                    <asp:ListItem Value="2" Text="No" />
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row mb-3">
                            <label for="OrganizacionInput" class="col-md-4">Organizacion:</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="OrganizacionText" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <div class="row mb-3">
                            <label for="AreaSelect" class="col-md-5">Area:</label>
                            <div class="col-md-7">
                                <asp:DropDownList runat="server" ID="AreaSelect" class="form-select">
                                    <asp:ListItem Value="0" Text="Todos" Selected="True" />
                                    <asp:ListItem Value="1" Text="Marketing" />
                                    <asp:ListItem Value="2" Text="Finanzas" />
                                    <asp:ListItem Value="2" Text="RRHH" />
                                    <asp:ListItem Value="2" Text="Operaciones" />
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row">
                            <label for="ActivoSelect" class="col-md-4">Activo:</label>
                            <div class="col-md-7">

                                <asp:DropDownList runat="server" ID="ActivoSelect" class="form-select">
                                    <asp:ListItem Value="0" Text="Todos" Selected="True" />
                                    <asp:ListItem Value="1" Text="Si" />
                                    <asp:ListItem Value="2" Text="No" />

                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row">
                            <label for="DireccionInput" class="col-md-4">Direccion:</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="DireccionText" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <div class="row mb-3">
                            <label for="TelefonoFijoInternoInput" class="col-md-5">Telefono fijo-interno:</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="TelefonoFijoInternoText" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col">
                        <div class="row mb-3">
                            <label for="TelefonoCelularInput" class="col-md-4">Telefono celular:</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="TelefonoCelularText" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row mb-3">
                            <label for="EmailInput" class="col-md-4">E-mail:</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="EmailText" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="row mb-3">
                            <label for="CuentaSkypeInput" class="col-md-5">Cuenta Skype:</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="CuentaSkypeText" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="div">
                    <asp:Button runat="server" OnClick="Guardar_Click" class="btn btn-succes button-buscar" Text="Guardar" />
                    <asp:Button runat="server" PostBackUrl="~/Consulta.aspx" class="btn btn-primary button-nuevo-contacto" Text="Salir" />
                </div>
            </form>
        </div>
    </div>
</body>
</html>
