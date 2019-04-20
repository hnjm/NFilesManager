using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFilesManager.Code.Interfaces
{
    /// <summary>
    /// Форма сканирования.
    /// </summary>
    public partial class FScan : Form
    {
        #region Конструкторы/инициализаторы.
        /// <summary>
        /// Создать форму сканирования.
        /// </summary>
        public FScan()
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
        #endregion

        #region Методы.
        #endregion
    }
}
