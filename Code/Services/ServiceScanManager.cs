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
        public virtual TaskScanModel CreateTask(string Path)
        {
            // Задача сканирования.
            TaskScanModel _TaskScan;
            // Создаем задачу.
            _TaskScan = new TaskScanModel(Path);
            // Результат.
            return _TaskScan;
        }
        /// <summary>
        /// Сканировать файлы.
        /// </summary>
        /// <param name="path"></param>
        public virtual void ScanFiles(FolderModel Folder)
        {
            Folder.Files.AddRange(Folder.Info.GetFiles());
        }
        /// <summary>
        /// Сканировать папки.
        /// </summary>
        public virtual void ScanFolders(FolderModel Folder)
        {
            // Для каждого дочернего каталога.
            foreach (DirectoryInfo _Dir in Folder.Info.GetDirectories())
            {
                // Дочерний каталог.
                FolderModel _Child = new FolderModel(_Dir.FullName);
                Folder.ChildFolders.Add(_Child);
                // Отдельный поток на скан подкаталогов.
                ScanFolders(_Child);
                // Отдельный поток на скан файлов.
                ScanFiles(_Child);
            }
        }

    }
}
