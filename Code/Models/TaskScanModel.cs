using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NFilesManager.Code.Models
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
        public TaskScanModel()
        {
            // -
        }

        //--Свойства------------------------------------
        // --
        //----------------------------------------------

        /// <summary>
        /// Путь сканирования.
        /// </summary>
        public string Path { get; set; }
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
