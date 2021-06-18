using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agenda.BLL;
using Agenda.Entity;

namespace AgendaEdsa
{
    public partial class NuevoContacto : System.Web.UI.Page
    {
        private AgendaBusiness Business = new AgendaBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Guardar_Click(object sender, EventArgs e)
        {
            Contacto newAgenda = new Contacto
            {
                Pais = PaisSelect.Text,
                Localidad = LocalidadText.Text,
                ApellidoYNombre = ApellidoYNombreText.Text,
                Area = AreaSelect.Text,
                Activo = ActivoSelect.Text,
                Genero = GeneroSelect.Text,
                Organizacion = OrganizacionText.Text,
                Direccion = DireccionText.Text,
                TelFijoInterno = TelefonoFijoInternoText.Text,
                TelCelular = TelefonoCelularText.Text,
                ContactoInterno = ContactoInternoSelect.Text,
                Email = EmailText.Text,
                CuentaSkype = CuentaSkypeText.Text
            };

            Business.Insert(newAgenda);
        }
    }
}