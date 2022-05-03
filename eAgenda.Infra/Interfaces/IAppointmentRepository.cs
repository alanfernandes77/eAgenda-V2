using eAgenda.Dominio.Entities;
using System.Collections.Generic;

namespace eAgenda.Infra.Interfaces
{
    public interface IAppointmentRepository
    {
        void RegisterAppointment(Appointment appointment);
        void DeleteAppointment(Appointment appointment);
        List<Appointment> GetAll();
        List<Appointment> GetPastAppointments();
        List<Appointment> GetFutureAppointments();
    }
}