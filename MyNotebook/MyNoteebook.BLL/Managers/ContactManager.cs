using System.Collections.Generic;
using MyNoteebook.BLL.DTO;
using MyNoteebook.BLL.Interfaces;
using MyNoteebook.DAL.DBModels;
using MyNoteebook.DAL.Interfaces;

namespace MyNoteebook.BLL.Managers
{
    public class ContactManager : IContactManager
    {
        private readonly IContactRepository contactRepository;

        public ContactManager(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public IEnumerable<ContactDto> GetAllContacts()
        {
            var contactsDb = contactRepository.GetAllContacts(true);
            var resultContacts = TransformFromDataBase(contactsDb);
            return resultContacts;
        }

        private List<ContactDto> TransformFromDataBase(List<Contact> contactsDb)
        {
            List<ContactDto> result = new List<ContactDto>();
            foreach (var contact in contactsDb)
            {
                result.Add(new ContactDto()
                {
                    Id = contact.Id,
                    Email = contact.Email,
                    FirstName = contact.FirstName,
                    IsDeleted = contact.IsDeleted,
                    LastName = contact.LastName,
                    PhoneNumber = contact.PhoneNumber,
                    ShortDescription = contact.ShortDescription
                });
            }

            return result;
        }
    }
}