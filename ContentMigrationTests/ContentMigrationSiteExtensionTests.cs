using ImportExportService;
using Microsoft.Web.Hosting;
using Microsoft.Web.Hosting.Administration;
using Microsoft.Web.Hosting.Administration.Data;
using Microsoft.Web.Hosting.Administration.Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;

namespace ContentMigrationTests
{
    [TestClass]
    public class ContentMigrationSiteExtensionTests
    {
        private ContentMigration _contentMigration;

        private readonly Mock<WebSite> _webSiteMock = new Mock<WebSite>();
        private readonly Mock<IRepositoryContext> _dbMock = new Mock<IRepositoryContext>();
        private readonly Mock<ContentMigrationCaller> _callerMock = new Mock<ContentMigrationCaller>();
        public ContentMigrationSiteExtensionTests()
        {
            //Assign dummy values when needed
            Guid id = new Guid();
            _webSiteMock.Object.Id = 3;
            string destinationPath = "volume-1-default";
            int notRevertMigration = 0;
            //why is content migration status not loading??

            _contentMigration = new ContentMigration(id, _webSiteMock.Object.Id, destinationPath, 0, _dbMock.Object, _webSiteMock.Object, revertFlag: notRevertMigration);
        }

        [TestMethod]
        public void TestInitialCallToExtension()
        {

        }

        [TestMethod]
        public void TestPollingStatusFromExtension()
        {

        }
    }
}
