using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NFilesManager.Code.Modules.ModulScan
{
    /// <summary>
    /// Модель отсканированной директории.
    /// </summary>
    public class ModelFolder
    {
        /// <summary>
        /// Модель отсканированной директории.
        /// </summary>
        public ModelFolder(string Path)
        {
            Files = new List<FileInfo>();
            ChildFolders = new List<ModelFolder>();
            this.Path = Path;
            Info = new DirectoryInfo(Path);
        }

        /// <summary>
        /// Путь.
        /// </summary>
        public string Path { get; private set; }
        /// <summary>
        /// Системная информация.
        /// </summary>
        public DirectoryInfo Info { get; private set; }
        /// <summary>
        /// Подчиненные каталоги.
        /// </summary>
        public List<ModelFolder> ChildFolders { get; }
        /// <summary>
        /// Файлы.
        /// </summary>
        public List<FileInfo> Files { get; }
        /// <summary>
        /// Количество всех подчиненных каталогов.
        /// </summary>
        public int CountChildFoldersAll {
            get {
                int _CountCurrend = ChildFolders.Count();
                int _CountInChilds = ChildFolders.Sum(x => x.CountChildFoldersAll);
                return _CountCurrend + _CountInChilds;
            }
        }
        /// <summary>
        /// Количество всех файлов включая подкаталоги.
        /// </summary>
        public int CountFilesAll {
            get {
                int _CountCurrend = Files.Count();
                int _CountInChilds = ChildFolders.Sum(x => x.CountFilesAll);
                return _CountCurrend + _CountInChilds;
            }
        }
    }
}
