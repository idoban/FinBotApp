using FinBot.Engine;
using FinBot.Expenses;
using FluentAssertions;
using NUnit.Framework;

namespace FinBot.Tests.Engine
{
    [TestFixture]
    public class LoadersTests
    {
        [Test]
        public void LoadSimlPackage_NotNull()
        {
            var simlPackageLoader = new SimlPackageLoader();
            var simlPackage = simlPackageLoader.LoadSimlPackage();

            simlPackage.Should().NotBeNull();
        }
        [Test]
        public void LoadCategories_NotNull()
        {
            var defaultCategoriesLoader = new DefaultCategoriesLoader();
            var categories = defaultCategoriesLoader.Load();

            categories.Should().NotBeNullOrEmpty();
        }
    }
}