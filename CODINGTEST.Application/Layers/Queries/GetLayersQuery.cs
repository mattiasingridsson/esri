using CodingTest.Application.Layers.Models;
using MediatR;
using System.Collections.Generic;

namespace CodingTest.Application.Layers.Queries
{
	public class GetLayersQuery : IRequest<LayerViewModel>
	{
	}
}
