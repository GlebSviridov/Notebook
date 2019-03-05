using System.Collections.Generic;
using MyNoteebook.DAL.DBModels;

namespace MyNoteebook.DAL.Interfaces
{
    public interface IContactRepository
    {
        bool AddContact(Contact contact);

        bool DeleteContactById(int contactId);

        List<Contact> GetAllContacts(bool includeDeleted);
    }
}