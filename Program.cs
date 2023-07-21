using Projeto;
using Repositorios;
using UI;

var globalData = new GlobalData(new EmployeeMemoryRepositorio());
var _UIManager = new UIManager();
_UIManager.Run(globalData);