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
        /// <summary>
        /// -
        /// </summary>
        public ModelTaskScan(string Path)
        {
            this.Path = Path;
            Folder = new ModelFolder(Path);
        }

        /// <summary>
        /// Путь сканирования.
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// Директориии.
        /// </summary>
        public ModelFolder Folder { get; set; }
    }
}
