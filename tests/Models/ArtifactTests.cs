using Xunit;
using openrmf_msg_checklist.Models;
using System;

namespace tests.Models
{
    public class ArtifactTests
    {
        [Fact]
        public void Test_NewArtifactIsValid()
        {
            Artifact art = new Artifact();
            Assert.True(art != null);
        }
    
        [Fact]
        public void Test_ArtifactWithDataIsValid()
        {
            Artifact art = new Artifact();
            art.created = DateTime.Now;
            art.systemGroupId = "bab8675a867b578d658fd5b876";
            art.hostName = "myHost";
            art.stigType = "Google Chrome";
            art.stigRelease = "Version 1";
            art.version = "1";
            art.updatedOn = DateTime.Now;

            // test things out
            Assert.True(art != null);
            Assert.True (!string.IsNullOrEmpty(art.created.ToShortDateString()));
            Assert.True (!string.IsNullOrEmpty(art.systemGroupId));
            Assert.True (!string.IsNullOrEmpty(art.hostName));
            Assert.True (!string.IsNullOrEmpty(art.stigType));
            Assert.True (!string.IsNullOrEmpty(art.stigRelease));
            Assert.True (!string.IsNullOrEmpty(art.version));
            Assert.True (!string.IsNullOrEmpty(art.title));  // readonly from other fields
            Assert.True (art.updatedOn.HasValue);
            Assert.True (!string.IsNullOrEmpty(art.updatedOn.Value.ToShortDateString()));
            Assert.True (art.CHECKLIST != null);
        }
    }
}
