using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NFilesManager.Code.Services.Tests
{
    [TestFixture()]
    public class ServiceScanManagerTests
    {
        private string m_Path = $@"{AppDomain.CurrentDomain.BaseDirectory}\TestFolder";

        [Test(Description = "Инициализация.")]
        public void ServiceScanManagerTest()
        {
            // Prepare
            // Action
            ServiceScanManager _ServiceScanManager = new ServiceScanManager();
            // Assert
            Assert.NotNull(_ServiceScanManager);
        }
        [Test(Description = "Создать задачу сканирования.")]
        public void CreateTaskTest()
        {
            // Prepare
            ServiceScanManager _ServiceScanManager = new ServiceScanManager();
            // Action
            var _Result = _ServiceScanManager.CreateTask(m_Path);
            // Assert
            Assert.NotNull(_Result);
            Assert.True(_Result.Path == m_Path);
        }
        [Test(Description = "Сканировать файлы.")]
        public void ScanFilesTest() {
            // Prepare
            ServiceScanManager _ServiceScanManager = new ServiceScanManager();
            var _Task = _ServiceScanManager.CreateTask(m_Path);
            _ServiceScanManager.ScanFolders(_Task.Folder);
            // Action
            _ServiceScanManager.ScanFiles(_Task.Folder);
            // Assert
            Assert.NotNull(_Task.Folder);
            Assert.NotNull(_Task.Folder.Files);
            Assert.True(_Task.Folder.Files.Count == 1);
            Assert.True(_Task.Folder.CountFilesAll == 4);
        }
        [Test(Description = "Сканировать папки.")]
        public void ScanDirsTest() {
            // Prepare
            ServiceScanManager _ServiceScanManager = new ServiceScanManager();
            var _Task = _ServiceScanManager.CreateTask(m_Path);
            // Action
            _ServiceScanManager.ScanFolders(_Task.Folder);
            // Assert
            Assert.NotNull(_Task.Folder);
            Assert.NotNull(_Task.Folder.ChildFolders);
            Assert.True(_Task.Folder.ChildFolders.Count == 2);
            Assert.True(_Task.Folder.CountChildFoldersAll == 2);
        }

        // Prepare
        // Action
        // Assert
    }
}