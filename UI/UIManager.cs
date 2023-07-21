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
            pages.Add(ShowPaycheckCostPage.PageName, new ShowPaycheckCostPage());
        }

        public void Run(GlobalData globalData)
        {
            string nextPageName = "main";
            Page? nextPage;
            do
            {
                if (pages.TryGetValue(nextPageName, value: out nextPage))
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
