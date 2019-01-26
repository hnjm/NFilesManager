using NFilesManager.Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NFilesManager.Code.Services
{
    /// <summary>
    /// Менеджер сканирования.
    /// </summary>
    public class ServiceScanManager
    {
        //--Конструкторы/инициализаторы-----------------
        // --
        //----------------------------------------------

        /// <summary>
        /// --
        /// </summary>
        /// 

        //--Свойства------------------------------------
        // --
        //----------------------------------------------

        /// <summary>
        /// --
        /// </summary>
        /// 

        //--События-------------------------------------
        // --
        //----------------------------------------------

        /// <summary>
        /// --
        /// </summary>
        /// 

        //--Методы--------------------------------------
        // --
        //----------------------------------------------

        /// <summary>
        /// Создать задачу сканирования.
        /// </summary>
        public TaskScanModel CreateTask(string Path)
        {
            // Задача сканирования.
            TaskScanModel _TaskScan = new TaskScanModel();
            // Создаем задачу.
            _TaskScan = new TaskScanModel()
            {
                Path = Path
            };
            // Результат.
            return _TaskScan;
        }
        /// <summary>
        /// Сканировать папки.
        /// </summary>
        public void ScanFolders(TaskScanModel Task)
        {
            // Список папок.
            Task.Folder = new FolderModel(Task.Path);
        }

    }
}
