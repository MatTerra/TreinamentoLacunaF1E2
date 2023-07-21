using Projeto;

namespace UI
{
    class MainPage : Page
    {
        private const ConsoleKey CreateEmployeeOption = ConsoleKey.D1;
        private const ConsoleKey ShowPaycheckCostOption = ConsoleKey.D2;
        private const ConsoleKey ShowEmployeeCostOption = ConsoleKey.D3;
        public static string PageName = "main";
        public override bool Run(GlobalData data, out string nextPage)
        {
            nextPage = PageName;
            Console.WriteLine("\nSeja bem-vindo ao cadastro de empregados.\nSelecione a opção:\n\n\t1 - Cadastrar novo empregado\n\n\t2 - Verificar custo total\n\n\t3 - Verificar custo de empregado\n");
            var answer = Console.ReadKey();
            switch (answer.Key)
            {
                case CreateEmployeeOption:
                    nextPage = CreateEmployeePage.PageName;
                    return true;
                case ShowPaycheckCostOption:
                    nextPage = ShowEmployeeCostPage.PageName;
                    return true;
                case ShowEmployeeCostOption:
                    nextPage = ShowEmployeeCostPage.PageName;
                    return true;
                default:
                    return false;
            }
        }
    }
}
