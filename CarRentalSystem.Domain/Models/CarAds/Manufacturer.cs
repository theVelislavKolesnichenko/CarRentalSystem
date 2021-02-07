namespace CarRentalSystem.Domain.Models.CarAds
{
    using Common;
    using Exceptions;

    using static Constants.Common;

    public class Manufacturer : Entity<int>
    {
        
        internal Manufacturer(string name)
        {
            this.Validate(name);

            this.Name = name;
        }
        public string Name { get; }

        private void Validate(string name) 
            => Guard.ForStringLength<InvalidCarAdException>(
                name, 
                MinNameLength,
                MaxNameLength, 
                nameof(this.Name));


        
    }
}
