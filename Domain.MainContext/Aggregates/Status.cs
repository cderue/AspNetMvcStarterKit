using System;
using System.Linq;

namespace Domain.MainContext.Aggregates
{
    public enum Status
    {
        New = 1,
        Qualified = 2,
        Archived = 3
    }
}