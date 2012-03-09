using System;
using System.Linq;
using Domain.Seedwork.Specifications;
using Domain.MainContext.Aggregates;

namespace Domain.MainContext.Specifications
{
    public static class ContactSpecifications
    {
        public static Specification<Contact> GetContactsByLastName(string lastName) {
            return new DirectSpecification<Contact>(c => c.LastName == lastName);
        }
    }
}