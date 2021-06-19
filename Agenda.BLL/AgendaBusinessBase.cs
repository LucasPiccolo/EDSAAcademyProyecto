namespace Agenda.BLL
{
    public class AgendaBusinessBase
    {

        public Contacto GetAgendaByID(int id)
        {
            return this.lstAgenda.Find(id);
        }
    }
}