using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFilesManager.Code.Modules.ModulGeneral;
using NFilesManager.Code.Modules.ModulNetwork;
using NFilesManager.Code.Modules.ModulScan;

namespace NFilesManager.Code.Modules
{
    /// <summary>
    /// Конструктор модулей.
    /// </summary>
    public static class ModulesConstructor
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
            var _Modul = GeneralCore.Instance();
            return _Modul;
        }
        /// <summary>
        /// Создать модуль сетевого подключения.
        /// </summary>
        /// <returns></returns>
        public static IModulNetwork CreateModulNetwork(SettingsNetworkModel Settings = null)
        {
            var _Modul = NetworkCore.Instance();
            return _Modul;
        }
        /// <summary>
        /// Создать модуль сканирования.
        /// </summary>
        /// <returns></returns>
        public static IModulScan CreateModulScan() { return null; }
        #endregion
    }
}
