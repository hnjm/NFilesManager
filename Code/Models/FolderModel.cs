using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        //--Свойства------------------------------------
        // --
        //----------------------------------------------

        /// <summary>
        /// Путь.
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// -
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
