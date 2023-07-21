using Projeto;

namespace UI
{
    abstract class Page
    {
        public abstract bool Run(GlobalData data, out string nextPage);
    }
}