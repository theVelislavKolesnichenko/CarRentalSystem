namespace CarRentalSystem.Tests.Domain.Models.CarAds
{
    using CarRentalSystem.Domain.Models.CarAds;
    using FakeItEasy;
    using FluentAssertions;
    using Xunit;

    public class CarAdSpaces
    {
        [Fact]
        public void ChangeAvailabilityShouldMutateIsAvailable()
        {
            // Arrange
            var carAd = A.Dummy<CarAd>();

            // Act
            carAd.ChangeAvailability();

            // Assert
            carAd.IsAvailable.Should().BeFalse();
        }
    }
}
