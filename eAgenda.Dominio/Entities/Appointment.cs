using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Dominio.Entities
{
    public class Appointment
    {
        public bool withContacts;

        public int Id { get; set; }
        public string Subject { get; set; }
        public string Local { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Contact> Contacts { get; set; }

        public Appointment() { }
        public Appointment(string subject, string local, DateTime date, DateTime startTime, DateTime endTime)
        {
            Id = new Random().Next(1000, 10000);
            Subject = subject;
            Local = local;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            withContacts = false;
        }

        public Appointment(string subject, string local, DateTime date, DateTime startTime, DateTime endTime, List<Contact> contacts) : this(subject, local, date, startTime, endTime)
        {
            Contacts = contacts;

            foreach (Contact contact in contacts)
                contact.IsAvailable = false;

            withContacts = true;
        }
    }
}
