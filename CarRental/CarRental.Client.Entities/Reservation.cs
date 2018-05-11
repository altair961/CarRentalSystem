using Core.Common.Core;
using System;

namespace CarRental.Client.Entities
{
    public class Reservation : ObjectBase
    {
        private int reservationId;
        private int accountId;
        private int carId;
        private DateTime returnDate;
        private DateTime rentalDate;

        public int ReservationId
        {
            get { return reservationId; }
            set
            {
                if (reservationId != value)
                {
                    reservationId = value;
                    OnPropertyChanged(() => ReservationId);
                }
            }
        }

        public int AccountId
        {
            get { return accountId; }
            set
            {
                if (accountId != value)
                {
                    accountId = value;
                    OnPropertyChanged(() => AccountId);
                }
            }
        }

        public int CarId
        {
            get { return carId; }
            set
            {
                if (carId != value)
                {
                    carId = value;
                    OnPropertyChanged(() => CarId);
                }
            }
        }

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set
            {
                if (returnDate != value)
                {
                    returnDate = value;
                    OnPropertyChanged(() => ReturnDate);
                }
            }
        }

        public DateTime RentalDate
        {
            get { return rentalDate; }
            set
            {
                if (rentalDate != value)
                {
                    rentalDate = value;
                    OnPropertyChanged(() => RentalDate);
                }
            }
        }
    }
}