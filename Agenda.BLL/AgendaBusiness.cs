using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Agenda.Entity;

namespace Agenda.BLL
{
    public class AgendaBusiness
    {
        private List<Contacto> lstAgenda = new List<Contacto>() {
            new Contacto() {
                Id = 1,
                ApellidoYNombre = "Bill Edsa",
                Genero = "Masculino",
                Pais = "Argentina",
                Area = "Marketing",
                FechaIngresoDesde = DateTime.Now,
                FechaIngresoHasta = DateTime.Now,
                ContactoInterno = "Si",
                Organizacion = "Lucas Organization",
                Activo = "Si",
                Direccion = "Chacabuco 123",
                TelFijoInterno = "2877435",
                TelCelular = "15459875",
                Email = "jksdf@gmail.com",
                CuentaSkype = "dskfsdksf",
                Localidad = "Tandil"
            }
        };

        public void Dispose()
        {
        }

        public Contacto GetAgendaByID(int id)
        {
            return this.lstAgenda.Single(p => p.Id == id);
        }

        public Contacto Insert(Contacto agenda)
        {
            int max = this.lstAgenda.OrderByDescending(x => x.Id).First().Id;
            agenda.Id = (max + 1);
            this.lstAgenda.Add(agenda);

            return agenda;
        }

        public void Update(Contacto agenda)
        {
            Contacto agendaFound = this.GetAgendaByID(agenda.Id);
            this.lstAgenda.Remove(agendaFound);
            this.lstAgenda.Add(agenda);
        }

        public void Delete(int id)
        {
            Contacto agendaToDelete = this.GetAgendaByID(id);
            if (agendaToDelete != null)
            {
                this.lstAgenda.Remove(agendaToDelete);
            }
        }

        public List<Contacto> ListAgendas([Optional] Hashtable filter)
        {
            return lstAgenda;
        }
    }
}