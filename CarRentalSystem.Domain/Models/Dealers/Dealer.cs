﻿[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("CarRentalSystem.Tests")]
namespace CarRentalSystem.Domain.Models.Dealers
{
    using System.Collections.Generic;
    using System.Linq;

    using Exceptions;
    using Common;
    using CarAds;
   
    using static Constants.Common;

    public class Dealer : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<CarAd> carAds;
        public Dealer(string name, string phoneNumber)
        {
            this.Validate(name);

            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.carAds = new HashSet<CarAd>();
        }
        public Dealer(string name)
            : this(name, default!) { }

        public string Name { get; }
        public PhoneNumber PhoneNumber { get; }
        public IReadOnlyCollection<CarAd> CarAds => this.carAds.ToList().AsReadOnly();
        public void AddCarAd(CarAd carAd) => this.carAds.Add(carAd);
        private void Validate(string name)
            => Guard.ForStringLength<InvalidDealerException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
    }
}
