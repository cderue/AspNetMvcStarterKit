using System;
using System.Linq;
using Domain.Seedwork;

namespace Domain.MainContext.Aggregates
{
    public class Account : Entity
    {
        public string Name { get; set; }
        public string PhoneOffice { get; set; }
        public string PhoneFax { get; set; }
        public Address Address { get; set; }
    }
}