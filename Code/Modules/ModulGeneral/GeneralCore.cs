using System.Windows.Forms;
using NFilesManager.Code.Modules.ModulScan;

namespace NFilesManager.Code.Modules.ModulGeneral
{
    /// <summary>
    /// Основной контроллер.
    /// </summary>
    public class GeneralCore : IModulGeneral
    {
        #region Конструкторы/инициализаторы.
        /// <summary>
        /// Инициализация объекта.
        /// </summary>
        /// <returns></returns>
        public static IModulGeneral Instance()
        {
            return new GeneralCore();
        }

        /// <summary>
        /// Создать контроллер.
        /// </summary>
        private GeneralCore()
        {
            _Form = new GeneralCoreForm();
            _Form.EventScan += Scan;
        }
        #endregion

        #region Свойства.
        /// <summary>
        /// Форма.
        /// </summary>
        public Form Form { get { return _Form; } }

        /// <summary>
        /// Форма.
        /// </summary>
        private GeneralCoreForm _Form;
        #endregion

        #region События.
        #endregion

        #region Методы.
        /// <summary>
        /// Сканировать.
        /// </summary>
        /// <param name="Obj"></param>
        /// <param name="Path"></param>
        private void Scan(object Obj, string Path)
        {
            
        }
        #endregion
    }
}
