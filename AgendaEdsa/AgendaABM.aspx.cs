using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agenda.BLL;

namespace Agenda
{
    public partial class AgendaABM : System.Web.UI.Page
    {
        public List<Entity.Models.Agenda> lstAgendas;
        public string table;
        protected void Page_Load(object sender, EventArgs e)
        {
            AgendaBusiness Business = new AgendaBusiness();
            this.lstAgendas = Business.ListAgendas();
            this.Write_Table();
        
        }

        protected void Write_Table()
        {
            foreach(Agenda.Entity.Models.Agenda agenda in lstAgendas)
            {
                table += "<tr>" +
                    $"<td> {agenda.ApellidoYNombre} </td>" +
                    $"<td> {agenda.Genero} </td>" +
                    $"<td> {agenda.Pais} </td>" +
                    $"<td> {agenda.Localidad} </td>" +
                    $"<td> {agenda.ContactoInterno} </td>" +
                    $"<td> {agenda.Organizacion} </td>" +
                    $"<td> {agenda.Area} </td>" +
                    $"<td> {agenda.FechaIngreso} </td>" +
                    $"<td> {agenda.Activo} </td>" +
                    $"<td> {agenda.Direccion} </td>" +
                    $"<td> {agenda.TelFijoInterno} </td>" +
                    $"<td> {agenda.TelCelular} </td>" +
                    $"<td> {agenda.Email} </td>" +
                    $"<td> {agenda.CuentaSkype} </td>" +
                    $"<td> " +                      
                        $"<span class='icon-zoom action-button'></span>" +
                        $"<span class='icon-edit action-button'></span>" +
                        $"<span class='icon-delete action-button'></span>" +
                        $"<span class='icon-anular action-button'></span>" +
                    $"</td>" +                  
                    $"</tr>";
            }

        }
    }
}