namespace CarRentalSystem.Domain.Exceptions
{
    using Common.Exceptions;
    public class InvalidOptionsException : BaseDomainException
    {
        public InvalidOptionsException()
        {
        }

        public InvalidOptionsException(string message) => this.Message = message;
    }
}
