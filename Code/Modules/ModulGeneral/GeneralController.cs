using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFilesManager.Code.Modules.ModulGeneral
{
    /// <summary>
    /// Основной контроллер.
    /// </summary>
    public class GeneralController : IModulGeneral
    {
        #region Конструкторы/инициализаторы.
        /// <summary>
        /// Создать контроллер.
        /// </summary>
        public GeneralController()
        {
            _Form = new FGeneral();
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
        private FGeneral _Form;
        #endregion

        #region События.
        #endregion

        #region Методы.
        /// <summary>
        /// Сканировать.
        /// </summary>
        /// <param name="Obj"></param>
        /// <param name="Path"></param>
        private void Scan(object Obj, string Path) { }
        #endregion
    }
}
