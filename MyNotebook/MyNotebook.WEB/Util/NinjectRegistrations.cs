using MyNoteebook.BLL.Interfaces;
using MyNoteebook.BLL.Managers;
using MyNoteebook.DAL.Interfaces;
using MyNoteebook.DAL.Repositories;
using Ninject.Modules;

namespace MyNoteebook.BLL.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IContactRepository>().To<ContactRepository>();
            Bind<INotebookRepository>().To<NotebookRepository>();
            Bind<IContactManager>().To<ContactManager>();
        }
    }
}