using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Agenda.BLL;
using Agenda.Entity;

namespace Agenda
{
   
    public partial class Consulta : System.Web.UI.Page

    {
        public List<Contacto> lstAgendas;
        public string table;
        private AgendaBusiness Business = new AgendaBusiness();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.lstAgendas = Business.ListAgendas();
                Session["lstAgendas"] = this.lstAgendas;
                this.Write_Table();
            }else
            {
                this.lstAgendas = (List<Contacto>) Session["lstAgendas"];
                this.Write_Table();
            }
        }
        public void Search_Click(object sender, EventArgs e)
        {
            Hashtable filter = new Hashtable();
            filter.Add("Pais", PaisSelect.Text);
            filter.Add("Activo", ActivoSelect.Text);
            filter.Add("Area", AreaSelect.Text);
            filter.Add("ApellidoYNombre", ApellidoYNombreText.Text);
            filter.Add("Localidad", LocalidadText.Text);
            filter.Add("FechaIngreso", FechaIngresoCalendar.Text);
            filter.Add("FechaEgreso", FechaEgresoCalendar.Text);
            filter.Add("ContactoInterno", ContactoInternoSelect.Text);
            filter.Add("Organizacion", OrganizacionText.Text);

            this.lstAgendas = Business.ListAgendas(filter);
            Session["lstAgendas"] = this.lstAgendas;
            this.Write_Table();
        }

        public void Delete_Click(object sender, EventArgs e)
        {
            LinkButton senderLink = (LinkButton) sender;
            int id = Int32.Parse(senderLink.CommandArgument);
            Business.Delete(id);
        }

        public void Clear_Filter_Click(object sender, EventArgs e)
        {
            PaisSelect.SelectedValue = "0";
            ActivoSelect.SelectedValue = "0";
            AreaSelect.SelectedValue = "0";
            ApellidoYNombreText.Text = String.Empty;
            LocalidadText.Text = String.Empty;
            FechaIngresoCalendar.Text = String.Empty;
            FechaEgresoCalendar.Text = String.Empty;
            ContactoInternoSelect.SelectedValue = "0";
            OrganizacionText.Text = String.Empty;
        }
        protected void Write_Table()
        {
            DataTable.Rows.Clear();
            DataTable.Attributes.Add("class", "table table-hover data-table");
            List<string> columnNames = new List<string> {
                "Apellido y Nombre",
                "Genero",
                "Pais",
                "Localidad",
                "Contacto Interno",
                "Organizacion",
                "Area",
                "Fecha Ingreso",
                "Activo",
                "Direccion",
                "Tel. Interno",
                "Tel. Celular",
                "E-mail",
                "Cuenta Skype",
                "Acciones"
            };

            List<string> columns = new List<string> {
                "ApellidoYNombre",
                "Genero",
                "Pais",
                "Localidad",
                "ContactoInterno",
                "Organizacion",
                "Area",
                "FechaIngresoDesde",
                "Activo",
                "Direccion",
                "TelFijoInterno",
                "TelCelular",
                "Email",
                "CuentaSkype"
            };

            


            var rowHeaders = new TableRow();
            foreach (string columnName in columnNames)
            {
                TableHeaderCell hCell = new TableHeaderCell();
                hCell.Text = $"{columnName}";
                rowHeaders.Cells.Add(hCell);
            };
            DataTable.Rows.Add(rowHeaders);

            foreach (Contacto contacto in lstAgendas)
            {
                TableRow row = new TableRow();
                foreach (string column in columns)
                {
                    TableCell cell = new TableCell();
                    cell.Text = $"{contacto.GetType().GetProperty(column).GetValue(contacto, null)}";
                    row.Cells.Add(cell);
                }

                this.Add_Actions_To_Table(contacto, row);
                DataTable.Rows.Add(row);
            }
        }

        
         
           


        protected void Add_Actions_To_Table(Contacto contacto, TableRow row)
        {
            TableCell actionsCell = new TableCell();

            LinkButton deleteLinkButton = new LinkButton();
            deleteLinkButton.Click += new EventHandler(Delete_Click);
            deleteLinkButton.CssClass = "icon-delete action-button";
            deleteLinkButton.ID = $"{contacto.Id}-delete-button";
            deleteLinkButton.OnClientClick = "confirm('¿Esta seguro que desea eliminar el contacto?');";
            deleteLinkButton.CommandName = "DeleteReq";
            deleteLinkButton.CommandArgument = contacto.Id.ToString();
            actionsCell.Controls.Add(deleteLinkButton);

            LinkButton editLinkButton = new LinkButton();
            editLinkButton.CssClass = "icon-edit action-button";
            editLinkButton.ID = $"{contacto.Id}-edit-button";
            editLinkButton.PostBackUrl = $"/EditarContacto.aspx?id={contacto.Id}";
            editLinkButton.CommandName = "EditReq";
            editLinkButton.CommandArgument = contacto.Id.ToString();
            actionsCell.Controls.Add(editLinkButton);

            LinkButton consulLinkButton = new LinkButton();
            consulLinkButton.CssClass = "icon-consult action-button";
            consulLinkButton.ID = $"{contacto.Id}-consult-button";
            consulLinkButton.PostBackUrl = $"/ConsultarContacto.aspx?id={contacto.Id}";
            consulLinkButton.CommandName = "ConsultReq";
            consulLinkButton.CommandArgument = contacto.Id.ToString();
            actionsCell.Controls.Add(consulLinkButton);

            LinkButton anularLinkButton = new LinkButton();
            anularLinkButton.CssClass = "icon-anular action-button";
            anularLinkButton.ID = $"{contacto.Id}-anular-button";
            anularLinkButton.OnClientClick = "confirm('¿Esta seguro que desea inactivar el contacto?');";
            anularLinkButton.CommandName = "AnularReq";
            anularLinkButton.CommandArgument = contacto.Id.ToString();
            actionsCell.Controls.Add(anularLinkButton);
            
            row.Cells.Add(actionsCell);
        }
    }
}