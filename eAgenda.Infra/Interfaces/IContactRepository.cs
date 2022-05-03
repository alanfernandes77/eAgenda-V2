using eAgenda.Dominio.Entities;
using System.Collections.Generic;

namespace eAgenda.Infra.Interfaces
{
    public interface IContactRepository
    {
        void AddContact(Contact contact);
        void DeleteContact(Contact contact);
        List<Contact> GetAll();
        List<Contact> GetContactsGroupedByJobPosition();
    }
}