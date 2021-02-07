namespace CarRentalSystem.Tests.Domain.Models.Dealers
{
    using CarRentalSystem.Domain.Models.CarAds;
    using CarRentalSystem.Domain.Models.Dealers;
    using FakeItEasy;
    using FluentAssertions;
    using Xunit;

    public class CategorySpecs
    {
        [Fact]
        public void AddCarAdShouldSaveCarAd()
        {
            // Arrange
            var dealer = new Dealer("Valid dealer", "+12345678");
            var carAd = A.Dummy<CarAd>();

            // Act
            dealer.AddCarAd(carAd);

            // Assert
            dealer.CarAds.Should().Contain(carAd);
        }
    }
}
