using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFilesManager.Code.Modules.ModulScan
{
    /// <summary>
    /// Форма сканирования.
    /// </summary>
    public partial class TaskScanForm : Form
    {
        #region Конструкторы/инициализаторы.
        /// <summary>
        /// Создать форму сканирования.
        /// </summary>
        public TaskScanForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Свойства.
        /// <summary>
        /// Путь сканирования.
        /// </summary>
        internal string ScanPath { get { return TextBoxSanPath.Text; } set { TextBoxSanPath.Text = value; } }
        #endregion

        #region События.
        /// <summary>
        /// Событие запустить сканирование.
        /// </summary>
        internal EventHandler<string> EventScan => EventScan;
        /// <summary>
        /// Событие выбрать клиента.
        /// </summary>
        internal EventHandler EventConnectToClient => EventConnectToClient;
        /// <summary>
        /// Событие отправить файлы.
        /// </summary>
        internal EventHandler EventSendFiles => EventSendFiles;
        /// <summary>
        /// Событие отобразить информацию о клиенте.
        /// </summary>
        internal EventHandler EventViewInfoClient => EventViewInfoClient;
        #endregion

        #region Методы.
        /// <summary>
        /// Начать сканирование.
        /// </summary>
        /// <param name="Obj"></param>
        /// <param name="Args"></param>
        private void StartScan(object Obj, EventArgs Args)
        {
            EventScan?.Invoke(this, ScanPath);
        }
        /// <summary>
        /// Выбрать клиента.
        /// </summary>
        /// <param name="Obj"></param>
        /// <param name="Args"></param>
        private void ConnectToClient(object Obj, EventArgs Args) { }
        #endregion
    }
}
