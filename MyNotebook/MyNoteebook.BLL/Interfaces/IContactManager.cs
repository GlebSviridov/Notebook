using System.Collections.Generic;
using MyNoteebook.BLL.DTO;

namespace MyNoteebook.BLL.Interfaces
{
    public interface IContactManager
    {
        IEnumerable<ContactDto> GetAllContacts();
    }
}