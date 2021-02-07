namespace CarRentalSystem.Domain.Exceptions
{
    using Common.Exceptions;
    public class InvalidCarAdException : BaseDomainException
    {
        public InvalidCarAdException()
        {
        }

        public InvalidCarAdException(string message) => this.Message = message;
    }
}
