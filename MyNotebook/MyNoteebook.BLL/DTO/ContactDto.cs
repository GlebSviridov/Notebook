﻿namespace MyNoteebook.BLL.DTO
{
    public class ContactDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ShortDescription { get; set; }
        public bool IsDeleted { get; set; }
    }
}