using System;
using System.Linq;
using Domain.Seedwork;

namespace Domain.MainContext.Aggregates
{
    public class Address : ValueObject<Address>
    {
        private string _street;
        private string _city; 
        private string _state;
        private string _zipCode;

        public Address(string street, string city, string state, string zipCode)
        {
            this._street = street;
            this._city = city;
            this._state = state;
            this._zipCode = zipCode;
        }

        public string Street
        {
            get
            {
                return this._street;
            }
        }

        public string City
        {
            get
            {
                return this._city;
            }
        }

        public string State
        {
            get
            {
                return this._state;
            }
        }

        public string ZipCode
        {
            get
            {
                return this._zipCode;
            }
        }
    }
}