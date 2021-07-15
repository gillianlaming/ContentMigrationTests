using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Web.Hosting;
using Microsoft.Web.Hosting.Administration;
using Microsoft.Web.Hosting.Administration.Data.Model;
using System;

namespace ContentMigrationTests
{
    [TestClass]
    public class ContentMigrationSiteExtensionTests
    {
        private ContentMigration _contentMigration;

        public ContentMigrationSiteExtensionTests()
        {
            Guid id = new Guid();
            //need to mock a website
            //mock irepositorycontext
            _contentMigration = new ContentMigration(id, )
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
