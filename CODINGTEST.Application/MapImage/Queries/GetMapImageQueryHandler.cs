using CodingTest.Application.MapImage.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CodingTest.Application.MapImage.Queries
{
	public class GetMapImageQueryHandler : IRequestHandler<GetMapImageQuery, MapImageViewModel>
	{
		public GetMapImageQueryHandler()
		{

		}

		public async Task<MapImageViewModel> Handle(GetMapImageQuery request, CancellationToken cancellationToken)
		{
			// TODO: Implement handler
			throw new NotImplementedException();
		}
	}
}
