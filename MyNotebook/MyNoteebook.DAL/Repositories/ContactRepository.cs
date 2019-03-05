using System.Collections.Generic;
using System.Linq;
using MyNoteebook.DAL.Context;
using MyNoteebook.DAL.DBModels;
using MyNoteebook.DAL.Interfaces;

namespace MyNoteebook.DAL.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public bool AddContact(Contact contact)
        {
            using (var context = new NotebookDBContext())
            {
                context.Contact.Add(contact);
                var result = context.SaveChanges();
                return result > 0;
            }
        }

        public bool DeleteContactById(int contactId)
        {
            using (var context = new NotebookDBContext())
            {
                var contactDelete = context.Contact.FirstOrDefault(x => x.Id == contactId);
                if (contactDelete == null)
                {
                    return false;
                }

                contactDelete.IsDeleted = true;
                return context.SaveChanges() > 0;
            }
        }

        public List<Contact> GetAllContacts(bool includeDeleted)
        {
            using (var context = new NotebookDBContext())
            {
                var query = context.Contact.AsQueryable();
                if (!includeDeleted)
                {
                    query = query.Where(x => x.IsDeleted == false);
                }

                return query.ToList();
            }
        }
    }
}