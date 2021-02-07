[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("CarRentalSystem.Tests")]
namespace CarRentalSystem.Domain.Models.CarAds
{
    using Exceptions;
    using Common;
    using static Constants.Common;
    using static Constants.CarAd;
    public class CarAd : Entity<int>, IAggregateRoot
    {
        public CarAd(
           Manufacturer manufacturer,
           string model,
           Category category,
           string imageUrl,
           decimal pricePerDay,
           Options options,
           bool isAvailable)
        {
            this.Validate(model, imageUrl, pricePerDay);

            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Category = category;
            this.ImageUrl = imageUrl;
            this.PricePerDay = pricePerDay;
            this.Options = options;
            this.IsAvailable = isAvailable;
        }

        /// <summary>
        /// Entity Freamework constructor only
        /// </summary>
        /// <param name="model"></param>
        /// <param name="imageUrl"></param>
        /// <param name="pricePerDay"></param>
        /// <param name="isAvailable"></param>
        private CarAd(string model, string imageUrl, decimal pricePerDay, bool isAvailable) 
            : this(default!, model, default!, imageUrl, pricePerDay, default!, isAvailable) { }

        public Manufacturer Manufacturer { get; }

        public string Model { get; }

        public Category Category { get; }

        public string ImageUrl { get; }

        public decimal PricePerDay { get; }

        public Options Options { get; }

        public bool IsAvailable { get; private set; }

        public void ChangeAvailability() => this.IsAvailable = !this.IsAvailable;

        private void Validate(string model, string imageUrl, decimal pricePerDay)
        {
            Guard.ForStringLength<InvalidCarAdException>(
               model,
               MinModelLength,
               MaxModelLength,
               nameof(this.Model));

            Guard.ForValidUrl<InvalidCarAdException>(
                imageUrl,
                nameof(this.ImageUrl));

            Guard.AgainstOutOfRange<InvalidCarAdException>(
                pricePerDay,
                Zero,
                decimal.MaxValue,
                nameof(this.PricePerDay));
        }
    }
}
