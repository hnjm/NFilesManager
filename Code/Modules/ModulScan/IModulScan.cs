using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFilesManager.Code.Modules.ModulScan
{
    /// <summary>
    /// Модуль сканирования.
    /// </summary>
    public interface IModulScan
    {
        /// <summary>
        /// Создать задачу сканирования.
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        ModelTaskScan CreateTask(string Path);
        /// <summary>
        /// Отобразить интерфейс.
        /// </summary>
        void Show();
    }
}
