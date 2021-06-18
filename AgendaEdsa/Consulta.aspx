<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Agenda.Consulta" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="StyleABM.css" rel="stylesheet" type="text/css">
    <title>Consulta de Agenda</title>
    <h1 class="tittle">Consulta de agenda</h1>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4" crossorigin="anonymous"></script>

</head>
<body>
    <form runat="server">
        <div class="card card-filter">
            <div class="body">
                <div class="row">
                    <div class="col">
                        <div class="row mb-3">
                            <label for="apellidoYNombreInput" class="col-md-5">Apellido y Nombre</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="ApellidoYNombreText" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row mb-3">
                            <label for="paisSelect" class="col-md-4">Pais</label>
                            <div class="col-md-7">
                                <asp:DropDownList runat="server" ID="PaisSelect" class="form-select">
                                    <asp:ListItem Value="0" Text="Todos" Selected="True" />
                                    <asp:ListItem Value="1" Text="Argentina" />
                                    <asp:ListItem Value="2" Text="Brasil" />
                                    <asp:ListItem Value="3" Text="Chile" />
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row mb-3">
                            <label for="localidadInput" class="col-md-4">Localidad</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="LocalidadText" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <div class="row mb-3">
                            <label for="fechaIngresoDatePicker" class="col-md-5">Fecha Ingreso</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="FechaIngresoCalendar" class="form-control"></asp:TextBox>                              
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row mb-3">
                            <label for="fechaEgresoDatePicker" class="col-md-4">Fecha Egreso</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="FechaEgresoCalendar" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row mb-3">
                            <label for="contactoInternoSelect" class="col-md-4">Contacto Interno</label>
                            <div class="col-md-7">
                                <asp:DropDownList runat="server" ID="ContactoInternoSelect" class="form-select">
                                    <asp:ListItem Value="0" Text="Todos" Selected="True" />
                                    <asp:ListItem Value="1" Text="Si" />
                                    <asp:ListItem Value="2" Text="No" />
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <div class="row mb-3">
                            <label for="organizacionInput" class="col-md-5">Organizacion</label>
                            <div class="col-md-7">
                                <asp:TextBox runat="server" ID="OrganizacionText" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row">
                            <label for="areaSelect" class="col-md-4">Area</label>
                            <div class="col-md-7">
                                <asp:DropDownList runat="server" ID="AreaSelect" class="form-select">
                                    <asp:ListItem Value="0" Text="Todos" Selected="True" />
                                    <asp:ListItem Value="1" Text="Marketing" />
                                    <asp:ListItem Value="2" Text="Finanzas" />
                                    <asp:ListItem Value="3" Text="RRHH" />
                                    <asp:ListItem Value="4" Text="Operaciones" />
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="row">
                            <label for="activoSelect" class="col-md-4">Activo</label>
                            <div class="col-md-7">
                                <asp:DropDownList runat="server" ID="ActivoSelect" class="form-control">
                                    <asp:ListItem Value="0" Text="Todos" Selected="True" />
                                    <asp:ListItem Value="1" Text="Activo" />
                                    <asp:ListItem Value="1" Text="Inactivo" />
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="div">
                    <asp:Button runat="server" OnClick="Search_Click" class="btn btn-succes button-buscar" Text="Buscar" />
                    <asp:Button runat="server" PostBackUrl="~/NuevoContacto.aspx" class="btn btn-primary button-nuevo-contacto" Text="Nuevo Contacto" />
                    <asp:Button runat="server" OnClick="Clear_Filter_Click" class="icon-clear" />
                </div>
            </div>
        </div>
        <asp:Table ID="DataTable" runat="server">
        </asp:Table>
        <div class="div">
            <button type="button" class="btn btn-primary button-salir">Salir</button>
        </div>
    </form>
</body>
</html>
