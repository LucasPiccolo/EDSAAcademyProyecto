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
    public partial class AgendaBusiness  
    {
    
        private List<Contacto> lstAgenda = new List<Contacto>() { 
            new Contacto() 
            {
                Id = 1,
                ApellidoYNombre = "Lucas Garcia",
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
                Email = "lucas@gmail.com",
                CuentaSkype = "LucasGarcia1",
                Area = "Marketing",
                Localidad = "Tandil"                                               
            },
            new Contacto() {
                Id = 2,
                ApellidoYNombre = "Alejandro Romero",
                Genero = "Masculino",
                Pais = "Argentina",
                FechaIngresoDesde = DateTime.Now,
                FechaIngresoHasta = DateTime.Now,
                ContactoInterno = "Si",
                Organizacion = "Lucas Organization",
                Activo = "Si",
                Direccion = "Chacabuco 123",
                Area = "Finanzas",
                TelFijoInterno = "2877435",
                TelCelular = "15412875",
                Email = "alejandroromero2@gmail.com",
                CuentaSkype = "Alejandroromero2",
                Localidad = "Tandil"
            },

            new Contacto() {
                Id = 3,
                ApellidoYNombre = "Maria Dominguez",
                Genero = "Femenino",
                Pais = "Argentina",
                FechaIngresoDesde = DateTime.Now,
                FechaIngresoHasta = DateTime.Now,
                ContactoInterno = "Si",
                Organizacion = "EDSA",
                Activo = "Si",
                Direccion = "Brandsen 123",
                Area = "RRHH",
                TelFijoInterno = "2877435",
                TelCelular = "15450975",
                Email = "mariaadominguez5@gmail.com",
                CuentaSkype = "MariaDominguez25",
                Localidad = "Tandil"
            },

            new Contacto() {
                Id = 4,
                ApellidoYNombre = "Margarita Diaz",
                Genero = "Femenino",
                Pais = "Brasil",
                FechaIngresoDesde = DateTime.Now,
                FechaIngresoHasta = DateTime.Now,
                ContactoInterno = "Si",
                Organizacion = "EDSA",
                Activo = "Si",
                Direccion = "Rivadavia 123",
                Area = "Finanzas",
                TelFijoInterno = "2877435",
                TelCelular = "15459875",
                Email = "margaritadiaz2@gmail.com",
                CuentaSkype = "MargaritaDiaz1990",
                Localidad = "Tandil"
            },

            new Contacto() {
                Id = 5,
                ApellidoYNombre = "Mauricio Guerra",
                Genero = "Masculino",
                Pais = "Argentina",
                FechaIngresoDesde = DateTime.Now,
                FechaIngresoHasta = DateTime.Now,
                ContactoInterno = "Si",
                Organizacion = "EDSA",
                Activo = "Si",
                Direccion = "Alvear 123",
                Area = "RRHH",
                TelFijoInterno = "2877435",
                TelCelular = "15459875",
                Email = "mauricioguerrraa@gmail.com",
                CuentaSkype = "MauricioGuerra2",
                Localidad = "Tandil"
            },

            new Contacto() {
                Id = 6,
                ApellidoYNombre = "Antonio Blanco",
                Genero = "Masculino",
                Pais = "Argentina",
                FechaIngresoDesde = DateTime.Now,
                FechaIngresoHasta = DateTime.Now,
                ContactoInterno = "Si",
                Organizacion = "EDSA",
                Activo = "Si",
                Direccion = "Lomas 123",
                Area = "RRHH",
                TelFijoInterno = "2877435",
                TelCelular = "15459875",
                Email = "antonioblanc@gmail.com",
                CuentaSkype = "Antonioblanco2",
                Localidad = "Tandil"
            },

            new Contacto() {
                Id = 7,
                ApellidoYNombre = "Marina Hernandez",
                Genero = "Femenino",
                Pais = "Argentina",
                FechaIngresoDesde = DateTime.Now,
                FechaIngresoHasta = DateTime.Now,
                ContactoInterno = "Si",
                Organizacion = "EDSA",
                Activo = "Si",
                Direccion = "Constitucion 123",
                Area = "Finanzas",
                TelFijoInterno = "2877435",
                TelCelular = "15459875",
                Email = "marinahernandez@gmail.com",
                CuentaSkype = "MarinaHernandezQ",
                Localidad = "Tandil"
            },

            new Contacto() {
                Id = 8,
                ApellidoYNombre = "Lautaro Gianini",
                Genero = "Masculino",
                Pais = "Argentina",
                FechaIngresoDesde = DateTime.Now,
                FechaIngresoHasta = DateTime.Now,
                ContactoInterno = "Si",
                Organizacion = "EDSA",
                Activo = "Si",
                Direccion = "Alvear 123",
                Area = "RRHH",
                TelFijoInterno = "2877435",
                TelCelular = "15459875",
                Email = "lautarogiani@gmail.com",
                CuentaSkype = "LautaroGianini21",
                Localidad = "Tandil"
            },

            new Contacto() {
                Id = 9,
                ApellidoYNombre = "Oscar Romero",
                Genero = "Masculino",
                Pais = "Paraguay",
                FechaIngresoDesde = DateTime.Now,
                FechaIngresoHasta = DateTime.Now,
                ContactoInterno = "Si",
                Organizacion = "EDSA",
                Activo = "Si",
                Direccion = "Jose.C 123",
                Area = "Finanzas",
                TelFijoInterno = "2877435",
                TelCelular = "15459875",
                Email = "OscarRomero78@gmail.com",
                CuentaSkype = "OscarRomero09",
                Localidad = "Olavarria"
            },

            new Contacto() {
                Id = 10,
                ApellidoYNombre = "Fernanda Diaz",
                Genero = "Femenino",
                Pais = "Argentina",
                FechaIngresoDesde = DateTime.Now,
                FechaIngresoHasta = DateTime.Now,
                ContactoInterno = "Si",
                Organizacion = "EDSA",
                Activo = "Si",
                Direccion = "Suipacha 123",
                Area = "Finanzas",
                TelFijoInterno = "2877435",
                TelCelular = "15459875",
                Email = "fernandadiazz2@gmail.com",
                CuentaSkype = "FernandaDiaz96",
                Localidad = "Tandil"
            }
        };

        public void Dispose()
        {
        }

        public Contacto Insert(Contacto contacto)
        {
            return this.lstAgenda.Add(Contacto);
        }

        public void Update(Contacto contacto)
        {
            using (var context = new AgendaBusiness())
            {
                var contactoToUpdate = Contacto(contacto.Id);
                if (contactoToUpdate == null)
                {
                    return;
                }

                context.Entry(contactoToUpdate).CurrentValues.SetValues(contacto);
                context.SaveChanges();
            };
        }

        private void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Contacto agendaToDelete = GetAgendaByID(id);
            if (agendaToDelete != null)
            {
                this.lstAgenda.Remove(agendaToDelete);
            }
        }

        public List<Contacto> ListAgendas([Optional] Hashtable filter)
         {
            using (var context = new AgendaBusiness())
            {
                IQueryable<Contacto> query = context.Set<Contacto>();

                if (filter != null)
                {
                    foreach (DictionaryEntry s in filter)
                    {
                        query = query.Where(t => t.GetType().GetProperty(s.Key.ToString()) == s.Value);
                    }

                }
                return this.lstAgenda;
            }
               
        }

        public IQueryable<Contacto> GetQuery([Optional] Hashtable filter)
        {
            using (var context = new Contacto())
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
