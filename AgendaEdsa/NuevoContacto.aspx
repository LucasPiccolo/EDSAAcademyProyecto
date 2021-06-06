<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoContacto.aspx.cs" Inherits="AgendaEdsa.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Nuevo Contacto</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4" crossorigin="anonymous"></script>
</head>
    <div>
<body>
    <h1>Nuevo Contacto</h1>
 <div>        
        <form>
          <div class="row">
            <div class="col">
                <div class="row">
                    <label for="apellidoYNombreInput" class="col">Apellido y Nombre</label>
                    <div class="col">
                      <input type="text" class="form-control" id="apellidoYNombreInput">
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="row">
                    <label for="GeneroSelect" class="col">Genero</label>
                    <div class="col">
                      <select id="GeneroSelect" class="form-select">
                          <option selected>Open this select menu</option>
                          <option value="1">Masculino</option>
                          <option value="2">Femenino</option> 
                        </select>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="row">
                    <label for="PaisSelect" class="col">País</label>
                    <div class="col">
                      <select id="GeneroSelect" class="form-select">
                          <option selected>Open this select menu</option>
                          <option value="1">Argentina</option>
                          <option value="2">Chile</option> 
                        </select>
                    </div>
                </div>
            </div>
          </div>
          <div class="row">
            <div class="col">
                <div class="row">
                    <label for="LocalidadImput" class="col">Localidad</label>
                    <div class="col">
                      <input type="text" class="form-control-plaintext" id="LocalidadImput">
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="row">
                    <label for="ContactoInternoSelect" class="col">Contacto Interno</label>
                    <div class="col">
                    <select id="GeneroSelect" class="form-select">
                          <option selected>Open this select menu</option>
                          <option value="1">423</option>
                          <option value="2">5467</option> 
                        </select>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="row">
                    <label for="OrganizacionInput" class="col">Organización</label>
                      <input type="text" class="form-control-plaintext" id="OrganizacionImput">                    
                    </div>
                </div>
            </div>
          </div>
         <div class="row">
            <div class="col">
                <div class="row">
                    <label for="AreaImput" class="col">Area</label>
                    <div class="col">
                      <input type="text" class="form-control-plaintext" id="AreaImput">
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="row">
                    <label for="ActivoSelect" class="col">Activo</label>
                    <div class="col">
                      <select id="ActivoSelect" class="form-select">
                          <option selected>Open this select menu</option>
                          <option value="1">a</option>
                          <option value="2">b</option>
                          <option value="3">c</option>
                        </select>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="row">
                    <label for="e-MailImput" class="col">Dirección</label>
                    <input type="text" class="form-control-plaintext" id="DireccionImput">
                </div>
            </div>
          </div>


    <div class="row">
            <div class="col">
                <div class="row">
                    <label for="apellidoYNombreInput" class="col">Telefono fijo-interno</label>
                    <div class="col">
                      <input type="text" class="form-control" id="apellidoYNombreInput">
                    </div>
                </div>
            </div>

        <div class="col">
                <div class="row">
                    <label for="PaisSelect" class="col">e-Mail</label>
                    <div class="col">
                    <input type="text" class="form-control-plaintext" id="e-MailImput">
                    </div>
                </div>
            </div>

        <div class="row">
            <div class="col">
                <div class="row">
                    <label for="CuentaskypeInput" class="col">Cuenta Skype</label>
                    <div class="col">
                      <input type="text" class="form-control" id="apellidoYNombreInput">
                    </div>
                </div>
            </div>
        </form>
    </div>

    

</body>
</html>
