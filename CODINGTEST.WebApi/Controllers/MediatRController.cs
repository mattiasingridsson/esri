using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CodingTest.WebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public abstract class MediatRController : ControllerBase
	{
		IMediator mediator;
		protected IMediator Mediator => mediator ?? (mediator = HttpContext.RequestServices.GetService<IMediator>());
	}
}
