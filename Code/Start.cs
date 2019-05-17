using NFilesManager.Code.Modules;
using System;
using System.Windows.Forms;

namespace NFilesManager.Code
{
    class Start
	{
		#region Конструкторы/инициализаторы
		#endregion

		#region Свойства
		#endregion

		#region События
		#endregion

		#region Методы
		/// <summary>
		/// Точка входа приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
            // -
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            // -
            var ModulGeneral = ModulesConstructor.CreateModulGeneral();
			Application.Run(ModulGeneral.Form);
		}
        #endregion
    }
}
