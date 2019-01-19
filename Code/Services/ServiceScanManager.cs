using NFilesManager.Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// 
        public TaskScan CreateTask(string Path) {
            // Задача сканирования.
            TaskScan _TaskScan = new TaskScan();
            // Создаем задачу.
            _TaskScan = new TaskScan();
            // Результат.
            return _TaskScan;
        }

    }
}
