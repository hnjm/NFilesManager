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
    public class ModelTaskScan
    {
        //--Конструкторы/инициализаторы-----------------
        // --
        //----------------------------------------------

        /// <summary>
        /// -
        /// </summary>
        public ModelTaskScan(string Path)
        {
            this.Path = Path;
            Folder = new ModelFolder(Path);
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
        public ModelFolder Folder { get; set; }


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
