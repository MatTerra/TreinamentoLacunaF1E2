using Projeto;

namespace UI
{
    class UIManager
    {
        Dictionary<string, Page> pages = new();

        public UIManager()
        {
            pages.Add(MainPage.PageName, new MainPage());
            pages.Add(CreateEmployeePage.PageName, new CreateEmployeePage());
            pages.Add(ShowEmployeeCostPage.PageName, new ShowEmployeeCostPage());
        }

        public void Run(GlobalData globalData)
        {
            var nextPageName = "main";
            do
            {
                if (pages.TryGetValue(nextPageName, out var nextPage))
                {
                    var pageDone = false;
                    while (!pageDone)
                    {
                        pageDone = nextPage.Run(globalData, out nextPageName);
                    } 
                }
                else
                {
                    return;
                }
            } while (true);
        }
    }
}
