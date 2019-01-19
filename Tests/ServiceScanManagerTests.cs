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
        // Prepare
        // Action
        // Assert
    }
}