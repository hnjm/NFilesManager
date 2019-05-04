using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFilesManager.Code.Modules.ModulGeneral;

namespace NFilesManager.Code.Modules
{
    /// <summary>
    /// Конструктор модулей.
    /// </summary>
    public static class Constructor
    {
        #region Конструкторы/инициализаторы.
        #endregion

        #region Свойства/Поля.
        #endregion

        #region События.
        #endregion

        #region Методы.
        /// <summary>
        /// Создать главный модуль приложения.
        /// </summary>
        /// <returns></returns>
        public static IModulGeneral CreateModulGeneral()
        {
            IModulGeneral _Modul = new GeneralController();
            return _Modul;
        }
        #endregion
    }
}
