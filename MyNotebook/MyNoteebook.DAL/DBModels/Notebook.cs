using System;

namespace MyNoteebook.DAL.DBModels
{
    public class Notebook
    {
        public int Id { get; set; }
        public string ShortDescription { get; set; }
        public string MainInformation { get; set; }
        public DateTime? Date { get; set; }
    }
}
