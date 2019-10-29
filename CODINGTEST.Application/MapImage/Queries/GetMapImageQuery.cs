using CodingTest.Application.MapImage.Models;
using MediatR;

namespace CodingTest.Application.MapImage.Queries
{
	public class GetMapImageQuery : IRequest<MapImageViewModel>
	{
		public double XMin { get; set; }
		public double YMin { get; set; }
		public double XMax { get; set; }
		public double YMax { get; set; }
	}
}
