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
            new Contacto() 
            {
                Id = 1,
                ApellidoYNombre = "Bill sdsa",
                Genero = "Masculino",
                Pais = "Argentina",
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
                Area = "Marketing",
                Localidad = "Tandil"                                               
            },
            new Contacto() {
                Id = 2,
                ApellidoYNombre = "Bill sdsa",
                Genero = "Femenino",
                Pais = "Argentina",
                FechaIngresoDesde = DateTime.Now,
                FechaIngresoHasta = DateTime.Now,
                ContactoInterno = "Si",
                Organizacion = "Lucas Organization",
                Activo = "Sin",
                Direccion = "Chacabuco 123",
                Area = "Finanzas",
                TelFijoInterno = "2877435",
                TelCelular = "15459875",
                Email = "jksdf@gmail.com",
                CuentaSkype = "dskfsdksf",
                Localidad = "Chaco"
            }
        };

        public void Dispose()
        {
        }

        public Contacto GetAgendaByID(int id)
        {
            return AgendaEdsaEntities.ContactoSet.Find(id);
        }

        public Contacto Insert(Contacto contacto)
        {
            return AgendaEdsaEntities.ContactoSet.Add(contacto);
        }

        public void Update(Contacto contacto)
        {
            using (var context = new AgendaEdsaEntities())
            {
                var contactoToUpdate = GetAgendaByID(contacto.Id);
                if (contactoToUpdate == null)
                {
                    return;
                }

                context.Entry(contactoToUpdate).CurrentValues.SetValues(contacto);
                context.SaveChanges();
            };
        }

        public void Delete(int id)
        {
            Contacto agendaToDelete = GetAgendaByID(id);
            if (agendaToDelete != null)
            {
                AgendaEdsaEntities.ContactoSet.Remove(agendaToDelete);
            }
        }

        public List<Contacto> ListAgendas([Optional] Hashtable filter)
         {
            using (var context = new AgendaEdsaEntities())
            {
                IQueryable<Contacto> query = context.Set<Contacto>();

                if (filter != null)
                {
                    foreach (DictionaryEntry s in filter)
                    {
                        query = query.Where(t => t.GetType().GetProperty(s.Key.ToString()) == s.Value);
                    }

                }
                return query.ToList();
            }
               
        }

        public IQueryable<Contacto> GetQuery([Optional] Hashtable filter)
        {
            using (var context = new AgendaEdsaEntities())
            {
                IQueryable<Contacto> query = context.Set<Contacto>();

                if (filter != null)
                {
                    foreach (DictionaryEntry s in filter)
                    {
                        query = query.Where(t => t.GetType().GetProperty(s.Key.ToString()) == s.Value);
                    }

                }

                return query;
            }

        }
    }
}
