namespace CarRentalSystem.Domain.Models
{
    public static class Constants
    {
        public static class Common
        {
            public const int MinNameLength = 2;
            public const int MaxNameLength = 20;
            public const int MaxUrlLength = 2048;
            public const int Zero = 0;
        }

        public static class Category
        {
            public const int MinDescriptionLength = 20;
            public const int MaxDescriptionLength = 1000;
        }

        public static class Options
        {
            public const int MinNumberOfSeats = 2;
            public const int MaxNumberOfSeats = 50;
        }

        public static class PhoneNumber
        {
            public const int MinPhoneNumberLength = 5;
            public const int MaxPhoneNumberLength = 20;
            public const string PhoneNumberFirstSymbol = "+";
        }

        public static class CarAd
        {
            public const int MinModelLength = 2;
            public const int MaxModelLength = 20;
        }
    }
}
