using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run();
		}
	}
	#endregion
}
