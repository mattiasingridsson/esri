using CodingTest.Application.MapImage.Queries;
using FluentValidation;

namespace CodingTest.Application.MapImage.Validators
{
	public class GetMapImageQueryValidator : AbstractValidator<GetMapImageQuery>
	{
		public GetMapImageQueryValidator()
		{
			RuleFor(x => x.XMax).NotNull().NotEmpty();
			RuleFor(x => x.YMax).NotNull().NotEmpty();
			RuleFor(x => x.XMin).NotNull().NotEmpty();
			RuleFor(x => x.YMin).NotNull().NotEmpty();
		}
	}
}
