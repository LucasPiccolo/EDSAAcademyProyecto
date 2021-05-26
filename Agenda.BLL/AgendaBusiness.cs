using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Entity;

namespace Agenda.BLL
{
    public class AgendaBusiness
    {
        private List<Entity.Models.Agenda> lstAgenda;

        public void Dispose()
        {
        }

        public AgendaBusiness(List<Entity.Models.Agenda> lstAgenda)
        {
            this.lstAgenda = lstAgenda;
        }

        public Entity.Models.Agenda GetAgendaByID(Entity.Models.Agenda agenda)
        {
            return this.lstAgenda.Single(p => p.Id == agenda.Id);
        }

        public Entity.Models.Agenda Insert(Entity.Models.Agenda agenda)
        {
            int max = this.lstAgenda.OrderByDescending(x => x.Id).First().Id;
            agenda.Id = (max + 1);
            this.lstAgenda.Add(agenda);

            return agenda;
        }

        public void Update(Entity.Models.Agenda agenda)
        {
            Entity.Models.Agenda agendaFound = this.GetAgendaByID(agenda);
            this.lstAgenda.Remove(agendaFound);
            this.lstAgenda.Add(agenda);
        }

        public void Delete(Entity.Models.Agenda agenda)
        {
            Entity.Models.Agenda agendaToDelete = this.GetAgendaByID(agenda);
            if (agenda != null)
            {
                this.lstAgenda.Remove(agendaToDelete);
            }
        }

    }
}
