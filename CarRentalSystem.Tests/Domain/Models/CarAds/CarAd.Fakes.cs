namespace CarRentalSystem.Tests.Domain.Models.CarAds
{
    using CarRentalSystem.Domain.Models.CarAds;
    using FakeItEasy;
    using System;

    public class CarAdFakes
    {
        public class CarAdDummyFactory : IDummyFactory
        {
            public bool CanCreate(Type type) => true;

            public object Create(Type type)
            {
                return new CarAd(
                                   new Manufacturer("Valid manufacturer"),
                                   "Valid model",
                                   new Category("Valid category", "Valid description text"),
                                   "https://valid.test",
                                   10,
                                   new Options(true, 4, TransmissionType.Automatic),
                                   true);
            }

            public Priority Priority => Priority.Default;
        }
    }
}
