using CodingTest.Application.Layers.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CodingTest.Application.Layers.Queries
{
	public class GetQueriableLayersQueryHandler : IRequestHandler<GetQueriableLayersQuery, List<LayerViewModel>>
	{
		public GetQueriableLayersQueryHandler()
		{

		}

		public async Task<List<LayerViewModel>> Handle(GetQueriableLayersQuery request, CancellationToken cancellationToken)
		{
			// TODO: Implement handler
			throw new NotImplementedException();
		}
	}
}
