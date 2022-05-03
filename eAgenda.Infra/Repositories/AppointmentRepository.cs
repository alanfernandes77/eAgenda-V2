using eAgenda.Dominio.Entities;
using eAgenda.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {

        private readonly ISerializator<Appointment> _serializator;
        private readonly List<Appointment> _appointments;

        public AppointmentRepository(ISerializator<Appointment> serializator)
        {
            _serializator = serializator;
            _appointments = serializator.Load();
        }
        public void RegisterAppointment(Appointment appointment)
        {
            _appointments.Add(appointment);
            _serializator.Save(_appointments);
        }

        public void DeleteAppointment(Appointment appointment)
        {
            _appointments.Remove(appointment);
            _serializator.Save(_appointments);
        }

        public List<Appointment> GetAll()
        {
            return _appointments;
        }

        public List<Appointment> GetFutureAppointments()
        {
            return _appointments.Where(x => x.Date > DateTime.Now).ToList();
        }

        public List<Appointment> GetPastAppointments()
        {
            return _appointments.Where(x => x.Date < DateTime.Now).ToList();
        }

    }
}