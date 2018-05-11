using Core.Common.Core;

namespace CarRental.Client.Entities
{
    public class Account : ObjectBase
    {
        private int accountId;
        private string loginEmail;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string creditCard;
        private string expDate;

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

        public string LoginEmail
        {
            get { return loginEmail; }
            set
            {
                if (loginEmail != value)
                {
                    loginEmail = value;
                    OnPropertyChanged(() => LoginEmail);
                }
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged(() => FirstName);
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged(() => LastName);
                }
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged(() => Address);
                }
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                if (city != value)
                {
                    city = value;
                    OnPropertyChanged(() => City);
                }
            }
        }

        public string State
        {
            get { return state; }
            set
            {
                if (state != value)
                {
                    state = value;
                    OnPropertyChanged(() => State);
                }
            }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set
            {
                if (zipCode != value)
                {
                    zipCode = value;
                    OnPropertyChanged(() => ZipCode);
                }
            }
        }

        public string CreditCard
        {
            get { return creditCard; }
            set
            {
                if (creditCard != value)
                {
                    creditCard = value;
                    OnPropertyChanged(() => CreditCard);
                }
            }
        }

        public string ExpDate
        {
            get { return expDate; }
            set
            {
                if (expDate != value)
                {
                    expDate = value;
                    OnPropertyChanged(() => ExpDate);
                }
            }
        }
    }
}
