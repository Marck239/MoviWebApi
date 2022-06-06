using Microsoft.Extensions.Options;
using MoviWebApi.Models;
using MoviWebApi.Services;
namespace TestProjectMovi
{
    [TestFixture]
    public class Tests
    {
        private CarsService _carsService;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}