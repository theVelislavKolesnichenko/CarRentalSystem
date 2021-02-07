namespace CarRentalSystem.Infrastructure.Identity
{
    using CarRentalSystem.Domain.Exceptions;
    using CarRentalSystem.Domain.Models.Dealers;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        internal User(string emial) : base(emial) { this.Email = emial; }

        // public Dealer? Dealer { get; private set; }
        public Dealer Dealer { get; private set; } = default!;
        public void BecomeDealer(Dealer dealer)
        {
            //if (this.Dealer != null)
            if (this.Dealer != default!)
            {
                throw new InvalidDealerException($"User '{this.UserName}' is already a dealer.");
            }

            this.Dealer = dealer;
        }
    }
}
