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

        }
    }
}