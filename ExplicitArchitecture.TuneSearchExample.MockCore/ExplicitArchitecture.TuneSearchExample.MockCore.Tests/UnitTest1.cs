using System.Threading.Tasks;
using ExplicitArchitecture.TuneSearchExample.Core.Ports;
using NUnit.Framework;

namespace ExplicitArchitecture.TuneSearchExample.MockCore.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestMock()
        {
            var service = new MockSearchTracksService();
            await service.Execute(new SearchTermDTO() {Term = ""},
                (success) => Assert.AreEqual(5,success.Count), (error) => Assert.Fail(error.Message));
        }
    }

    public class SearchTermDTO : ISearchTerm
    {
        public string Term { get; set; }
    }
}