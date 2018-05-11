using Core.Common.Core;
using System;

namespace CarRental.Client.Entities
{
    public class Rental : ObjectBase
    {
        private int rentalId;
        private int accountId;
        private int carId;
        private DateTime dateRented;
        private DateTime dateDue;
        private DateTime? dateReturned;

        public int RentalId
        {
            get { return rentalId; }
            set
            {
                if (rentalId != value)
                {
                    rentalId = value;
                    OnPropertyChanged(() => RentalId);
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

        public DateTime DateRented
        {
            get { return dateRented; }
            set
            {
                if (dateRented != value)
                {
                    dateRented = value;
                    OnPropertyChanged(() => DateRented);
                }
            }
        }

        public DateTime DateDue
        {
            get { return dateDue; }
            set
            {
                if (dateDue != value)
                {
                    dateDue = value;
                    OnPropertyChanged(() => DateDue);
                }
            }
        }

        public DateTime? DateReturned
        {
            get { return dateReturned; }
            set
            {
                if (dateReturned != value)
                {
                    dateReturned = value;
                    OnPropertyChanged(() => DateReturned);
                }
            }
        }
    }
}
