<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgendaABM.aspx.cs" Inherits="Agenda.AgendaABM" %>

<!DOCTYPE html>

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="StyleABM.css" rel="stylesheet" type="text/css"> 
    <title>Consulta de Agenda</title>
    <h1 class="tittle">Consulta de agenda</h1>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4" crossorigin="anonymous"></script>

</head>
<body>


    <div class="card card-filter">  
        <div class="body">
            <form>
              <div class="row">
                <div class="col">
                    <div class="row mb-3">
                        <label for="apellidoYNombreInput" class="col-md-5">Apellido y Nombre</label>
                        <div class="col-md-7">
                          <input type="text" class="form-control" id="apellidoYNombreInput">
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="row mb-3">
                        <label for="paisSelect" class="col-md-4">Pais</label>
                        <div class="col-md-7">
                          <select id="paisSelect" class="form-select">
                              <option selected>Open this select menu</option>
                              <option value="1">Argentina</option>
                              <option value="2">Brasil</option>
                              <option value="3">Chile</option>
                            </select>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="row mb-3">
                        <label for="localidadInput" class="col-md-4">Localidad</label>
                        <div class="col-md-7">
                          <input type="text" class="form-control" id="LocalidadImput">
                        </div>
                    </div>
                </div>
              </div>
              <div class="row">
                <div class="col">
                    <div class="row mb-3">
                        <label for="fechaIngresoDatePicker" class="col-md-5">Fecha Ingreso</label>
                        <div class="col-md-7">
                          <input type="text" class="form-control" id="fechaIngresoDatePicker">
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="row mb-3">
                        <label for="fechaEgresoDatePicker" class="col-md-4">Fecha Egreso</label>
                        <div class="col-md-7">
                          <input type="text" class="form-control" id="fechaEgresoDatePicker">
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="row mb-3">
                        <label for="contactoInternoSelect" class="col-md-4">Contacto Interno</label>
                        <div class="col-md-7">
                           <select id="contactoInternoSelect" class="form-select">
                              <option selected>Open this select menu</option>
                              <option value="1">Argentina</option>
                              <option value="2">Brasil</option>
                              <option value="3">Chile</option>
                            </select>
                        </div>
                        </div>
                    </div>
              </div>
              <div class="row">
                <div class="col">
                    <div class="row mb-3">
                        <label for="organizacionInput" class="col-md-5">Organizacion</label>
                        <div class="col-md-7">
                          <input type="text" class="form-control" id="organizacionInput">
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="row">
                        <label for="areaSelect" class="col-md-4">Area</label>
                        <div class="col-md-7">
                           <select id="activoSelect" class="form-select">
                              <option selected>Open this select menu</option>
                              <option value="1">Activo</option>
                              <option value="2">Inactivo</option>
                            </select>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="row">
                       <label for="activoSelect" class="col-md-4">Activo</label>
                       <div class="col-md-7">
                           <select id="activoSelect" class="form-select">
                              <option selected>Open this select menu</option>
                              <option value="1">Activo</option>
                              <option value="2">Inactivo</option>
                            </select>
                        </div>
                    </div>
                </div>
              </div>
            </form>
                <div class="div">
                    <button type="button" class="btn btn-succes button-buscar">Buscar</button>
                    <button type="button" class="btn btn-primary button-nuevo-contacto">Nuevo Contacto</button>
                </div>
        </div>
    </div>

    
   
<table class="table table-hover data-table">
  <tr>
    <th>Apellido y Nombre</th>
    <th>Genero</th>
    <th>Pais</th>
    <th>Localidad</th>
    <th>Contacto Interno</th>
    <th>Organizacion</th>
    <th>Area</th>
    <th>Fecha Ingreso</th>
    <th>Activo</th>
    <th>Direccion</th>
    <th>Tel. Interno</th>
    <th>Tel. Celular</th>
    <th>E-Mail</th>
    <th>Cuenta Skype</th>
    <th>Acciones</th>
  </tr>
  <%= table %>
</table>
<div class="div">
<button type="button" class="btn btn-primary button-salir">Salir</button>
</div>

</body>
</html>
