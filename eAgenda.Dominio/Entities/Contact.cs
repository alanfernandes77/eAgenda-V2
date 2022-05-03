using System;

namespace eAgenda.Dominio.Entities
{
    public class Contact
    {
        public bool IsBasicContact;
        public bool IsAvailable;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Job { get; set; }

        public Contact() { }

        public Contact(string name, string email, string phone)
        {
            Id = new Random().Next(1000, 10000);
            Name = name;
            Email = email;
            Phone = phone;
            IsBasicContact = true;
            IsAvailable = true;
        }

        public Contact(string name, string email, string phone, string company, string job) : this(name, email, phone)
        {
            Company = company;
            Job = job;
            IsBasicContact = false;
            IsAvailable = true;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}