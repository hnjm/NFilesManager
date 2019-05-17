using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFilesManager.Code.Modules.ModulGeneral
{
    /// <summary>
    /// Главная форма.
    /// </summary>
    public partial class GeneralCoreForm : Form
    {
        #region Конструкторы/инициализаторы.
        /// <summary>
        /// Создать форму.
        /// </summary>
        public GeneralCoreForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Свойства.
        #endregion

        #region События.
        /// <summary>
        /// Событие запустить сканирование.
        /// </summary>
        internal EventHandler<string> EventScan { get; set; }
        #endregion

        #region Методы.
        /// <summary>
        /// Запуск сканирования.
        /// </summary>
        private void StartScan(object Sender, EventArgs Args)
        {
            // Диалог выбора папки сканирования.
            FolderBrowserDialog _Dlg = new FolderBrowserDialog();
            _Dlg.RootFolder = Environment.SpecialFolder.MyComputer;
            // Запуск сканирования.
            if (_Dlg.ShowDialog() == DialogResult.OK) EventScan?.Invoke(this, _Dlg.SelectedPath);
        }
        #endregion
    }
}
