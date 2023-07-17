
using FluentValidation;

namespace WebApi.Types
{
    public class EmployeeValidator : AbstractValidator<EmployeeAggregate>
    {
        public EmployeeValidator()
        {
            RuleFor(employee => employee.name).NotEmpty();
            RuleFor(employee => employee.description).NotEmpty();
            RuleFor(employee => employee.birthday).GreaterThan(new DateTime(1900, 1, 1));
            RuleFor(employee => employee.sex).NotNull();
        }
    }
}
