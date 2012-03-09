using System;
using System.Linq;

namespace Domain.MainContext.Aggregates
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneOffice { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneFax { get; set; }
    }
}