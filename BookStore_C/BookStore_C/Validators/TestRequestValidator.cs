using BookStore_C.Models.Requests;
using FluentValidation;

namespace BookStore_C.Validators
{
    public class TestRequestValidator 
        : AbstractValidator<TestRequest>
    {
        public TestRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .GreaterThanOrEqualTo(1).WithMessage("> 1");
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(50);
        }
    }
}
