using Agenda.BLL;
using Agenda.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgendaEdsa
{
    public partial class EditarContacto : System.Web.UI.Page
    {
        private AgendaBusiness Business = new AgendaBusiness();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString.Get("id"));
            this.Load_Data(id);
        }

        private void Load_Data(int id)
        {
            Contacto contacto = Business.GetAgendaByID(id);

            PaisSelect.SelectedValue = PaisSelect.Items.FindByText(contacto.Pais).Value;
            ActivoSelect.SelectedValue = ActivoSelect.Items.FindByText(contacto.Activo).Value;
            AreaSelect.SelectedValue = AreaSelect.Items.FindByText(contacto.Area).Value;
            ApellidoYNombreText.Text = contacto.ApellidoYNombre;
            LocalidadText.Text = contacto.Localidad;
            ContactoInternoSelect.SelectedValue = ContactoInternoSelect.Items.FindByText(contacto.ContactoInterno).Value;
            OrganizacionText.Text = contacto.Organizacion;
            EmailText.Text = contacto.Email;
            DireccionText.Text = contacto.Direccion;
            TelefonoFijoInternoText.Text = contacto.TelFijoInterno;
            TelefonoCelularText.Text = contacto.TelCelular;
            CuentaSkypeText.Text = contacto.CuentaSkype;
            GeneroSelect.SelectedValue = GeneroSelect.Items.FindByText(contacto.Genero).Value;
        }

        public void Guardar_Click(object sender, EventArgs e)
        {
            Contacto updatedAgenda = new Contacto
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

            Business.Update(updatedAgenda);
        }
    }
}