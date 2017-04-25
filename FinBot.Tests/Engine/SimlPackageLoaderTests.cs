using FinBot.Engine;
using FluentAssertions;
using NUnit.Framework;

namespace FinBot.Tests.Engine
{
    [TestFixture]
    public class SimlPackageLoaderTests
    {
        [Test]
        public void LoadSimlPackage_NotNull()
        {
            var simlPackageLoader = new SimlPackageLoader();
            var simlPackage = simlPackageLoader.LoadSimlPackage();

            simlPackage.Should().NotBeNull();
        }
    }
}