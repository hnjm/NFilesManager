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
        [Test()]
        public void ServiceScanManagerTest()
        {
            // Prepare
            // Action
            ServiceScanManager _ServiceScanManager = new ServiceScanManager();
            // Assert
            Assert.NotNull(_ServiceScanManager);
        }
        [Test()]
        public void CreateTaskTest()
        {
            // Prepare
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            ServiceScanManager _ServiceScanManager = new ServiceScanManager();
            // Action
            var _Result = _ServiceScanManager.CreateTask(_Path);
            // Assert
            Assert.NotNull(_Result);
            Assert.True(_Result.Path == _Path);
        }
        // Prepare
        // Action
        // Assert
    }
}