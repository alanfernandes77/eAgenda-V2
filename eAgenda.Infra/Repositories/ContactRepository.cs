using eAgenda.Dominio.Entities;
using eAgenda.Infra.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ISerializator<Contact> _serializator;
        private readonly List<Contact> _contacts;

        public ContactRepository(ISerializator<Contact> serializator)
        {
            _serializator = serializator;
            _contacts = serializator.Load();
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
            _serializator.Save(_contacts);
        }

        public void DeleteContact(Contact contact)
        {
            _contacts.Remove(contact);
            _serializator.Save(_contacts);
        }

        public List<Contact> GetAll()
        {
            return _contacts;
        }

        public List<Contact> GetContactsGroupedByJobPosition()
        {
            return _contacts.GroupBy(x => x.Job).Cast<Contact>().ToList();
        }

        public List<Contact> GetAvailableContacts()
        {
            return _contacts.Where(x => x.IsAvailable).ToList();
        }
    }
}