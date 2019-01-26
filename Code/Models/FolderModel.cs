using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NFilesManager.Code.Models
{
    /// <summary>
    /// Модель отсканированной директории.
    /// </summary>
    public class FolderModel
    {
        //--Конструкторы/инициализаторы-----------------
        // --
        //----------------------------------------------

        /// <summary>
        /// Модель отсканированной директории.
        /// </summary>
        public FolderModel(string Path)
        {
            Childs = new List<FolderModel>();
            this.Path = Path;
            Info = new DirectoryInfo(Path);
        }

        //--Свойства------------------------------------
        // --
        //----------------------------------------------

        /// <summary>
        /// Путь.
        /// </summary>
        public string Path { get; private set; }
        /// <summary>
        /// Системная информация.
        /// </summary>
        public DirectoryInfo Info { get; private set; }
        /// <summary>
        /// Подчиненные.
        /// </summary>
        public List<FolderModel> Childs { get; set; }

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
