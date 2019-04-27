using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NFilesManager.Code.Modules.ModulScan
{
    /// <summary>
    /// Задача сканирования.
    /// </summary>
    public class TaskScanModel
    {
        //--Конструкторы/инициализаторы-----------------
        // --
        //----------------------------------------------

        /// <summary>
        /// -
        /// </summary>
        public TaskScanModel(string Path)
        {
            this.Path = Path;
            Folder = new FolderModel(Path);
        }


        //--Свойства------------------------------------
        // --
        //----------------------------------------------

        /// <summary>
        /// Путь сканирования.
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// Директориии.
        /// </summary>
        public FolderModel Folder { get; set; }


        //--События-------------------------------------
        // --
        //----------------------------------------------

        /// <summary>
        /// -
        /// </summary>
        /// 


        //--Методы--------------------------------------
        // --
        //----------------------------------------------

        /// <summary>
        /// -
        /// </summary>
        /// 


    }
}
