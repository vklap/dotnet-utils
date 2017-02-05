using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Utils.Abstract;
using Utils.Concrete;

namespace Utils.Tests
{
    [TestClass]
    public class DateTimeProviderTests
    {
        private IDateTimeProvider CreateProvider()
        {
            return new DateTimeProvider();
        }

        [TestMethod]
        public void CurrentDateTime()
        {
            // Arrange 
            var provider = CreateProvider();

            // Act
            var result = provider.CurrentDateTime;

            // Assert
            result.ShouldBeGreaterThanOrEqualTo(DateTime.UtcNow.AddSeconds(-1));
            result.ShouldBeLessThan(DateTime.UtcNow.AddSeconds(1));
        }
    }
}
