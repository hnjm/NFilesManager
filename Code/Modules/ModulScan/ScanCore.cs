using NFilesManager.Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NFilesManager.Code.Modules.ModulScan
{
    /// <summary>
    /// Менеджер сканирования.
    /// </summary>
    public class ScanCore
    {
        #region Конструкторы/инициализаторы
        #endregion

        #region Свойства
        #endregion

        #region События
        #endregion

        #region Методы
        /// <summary>
        /// Создать задачу сканирования.
        /// </summary>
        public virtual ModelTaskScan CreateTask(string Path)
        {
            // Задача сканирования.
            ModelTaskScan _TaskScan;
            // Создаем задачу.
            _TaskScan = new ModelTaskScan(Path);
            // Результат.
            return _TaskScan;
        }
        /// <summary>
        /// Сканировать файлы.
        /// </summary>
        /// <param name="path"></param>
        public virtual void ScanFiles(ModelFolder Folder)
        {
            Folder.Files.Clear();
            Folder.Files.AddRange(Folder.Info.GetFiles());
        }
        /// <summary>
        /// Сканировать папки.
        /// </summary>
        public virtual void ScanFolders(ModelFolder Folder)
        {
            Folder.ChildFolders.Clear();
            // Для каждого дочернего каталога.
            foreach (DirectoryInfo _Dir in Folder.Info.GetDirectories())
            {
                // Дочерний каталог.
                ModelFolder _Child = new ModelFolder(_Dir.FullName);
                Folder.ChildFolders.Add(_Child);
                // Отдельный поток на скан подкаталогов.
                ScanFolders(_Child);
                // Отдельный поток на скан файлов.
                ScanFiles(_Child);
            }
        }
        #endregion
    }
}
