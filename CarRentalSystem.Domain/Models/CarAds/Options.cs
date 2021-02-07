﻿namespace CarRentalSystem.Domain.Models.CarAds
{
    using Common;
    using Exceptions;

    using static Constants.Options;

    public class Options
    {
        internal Options(bool hasClimateControl, int numberOfSeats, TransmissionType transmissionType)
        {
            this.Validate(numberOfSeats);

            this.HasClimateControl = hasClimateControl;
            this.NumberOfSeats = numberOfSeats;
            this.TransmissionType = transmissionType;
        }

        private Options(bool hasClimateControl, int numberOfSeats)
            : this(hasClimateControl, numberOfSeats, default!) { }

        public bool HasClimateControl { get; }

        public int NumberOfSeats { get; }

        public TransmissionType TransmissionType { get; }

        private void Validate(int numberOfSeats)
            => Guard.AgainstOutOfRange<InvalidOptionsException>(
                numberOfSeats,
                MinNumberOfSeats,
                MaxNumberOfSeats,
                nameof(this.NumberOfSeats));
    }
}