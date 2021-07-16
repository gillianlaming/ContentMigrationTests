using System;
using System.Net;
using System.Net.Http;
using ImportExportService;
using Microsoft.Web.Hosting;
using Microsoft.Web.Hosting.Administration;
using Microsoft.Web.Hosting.Administration.Common;
using Microsoft.Web.Hosting.Administration.Data;
using Microsoft.Web.Hosting.Administration.Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ContentMigrationTests
{
    [TestClass]
    public class ContentMigrationSiteExtensionTests
    {
        private readonly ContentMigration _contentMigration;

        private readonly Mock<WebSite> _webSiteMock = new Mock<WebSite>();
        private readonly Mock<IRepositoryContext> _dbMock = new Mock<IRepositoryContext>();
        private readonly Mock<IContentMigrationCaller> _callerMock = new Mock<IContentMigrationCaller>();
        private readonly HttpStatusCode _expectedStatusResponse = HttpStatusCode.OK;

        public ContentMigrationSiteExtensionTests()
        {
            //Assign dummy values when needed
            Guid id = new Guid();
            _webSiteMock.Object.Id = 3;
            string destinationPath = "volume-1-default";
            int notRevertMigration = 0;
            //why is content migration status not loading??

            _contentMigration = new ContentMigration(); //new ContentMigration(id, _webSiteMock.Object.Id, destinationPath, 0, _dbMock.Object, _webSiteMock.Object,notRevertMigration);
        }

        [TestMethod]
        public void TestInitialCallToExtension()
        {
            Guid id = new Guid();
            MigrationRequest requestBody = new MigrationRequest()
            {
                MigrationId = id.ToString(),
                DestinationPath = "volume-0-default", 
                RuntimeSiteName = "glaming3site",
                Round = 1
            };
            HttpResponseMessage responseMessage = new HttpResponseMessage(); 
            _callerMock.Setup(x => x.MakePostRequestToScmSite(_contentMigration, requestBody)).Returns(responseMessage);

            var response = _callerMock.Object.MakePostRequestToScmSite(_contentMigration, requestBody);

            Assert.AreEqual(expected: _expectedStatusResponse, actual: response.StatusCode);
        }

        [TestMethod]
        public void TestPollingStatusFromExtension()
        {

        }
    }
}
