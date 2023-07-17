using System;

namespace DEmployee.Helpers.Domain
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}
