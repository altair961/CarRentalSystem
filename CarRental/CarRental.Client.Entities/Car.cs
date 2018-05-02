using Core.Common.Core;

namespace CarRental.Client.Entities
{
    public class Car : ObjectBase
    {
        private int carId;
        string description;
        string color;
        int year;
        decimal rentalPrice;
        bool currentlyRented;

        public int CarId
        {
            get { return carId; }
            set
            {
                if (carId != value)
                {
                    carId = value;
                    // OnPropertyChanged("CarId");
                    OnPropertyChanged(() => CarId); // this enables compile time safety while working with names of properties
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged(() => Description);
                }
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (color != value)
                {
                    color = value;
                    OnPropertyChanged(() => Color);
                }
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (year != value)
                {
                    year = value;
                    OnPropertyChanged(() => Year);
                }
            }
        }

        public decimal RentalPrice
        {
            get
            {
                return rentalPrice;
            }
            set
            {
                if (rentalPrice != value)
                {
                    rentalPrice = value;
                    OnPropertyChanged(() => RentalPrice);
                }
            }
        }

        public bool CurrentlyRented
        {
            get
            {
                return currentlyRented;
            }
            set
            {
                if (currentlyRented != value)
                {
                    currentlyRented = value;
                    OnPropertyChanged(() => CurrentlyRented);
                }
            }
        }
    }
}
