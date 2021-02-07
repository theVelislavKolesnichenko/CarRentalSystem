namespace CarRentalSystem.Domain.Exceptions
{
    using Common.Exceptions;
    public class InvalidDealerException : BaseDomainException
    {
        public InvalidDealerException()
        {
        }

        public InvalidDealerException(string message) => this.Message = message;
    }
}
