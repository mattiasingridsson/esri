using CodingTest.Application.Layers.Models;
using CodingTest.Application.Layers.Queries;
using CodingTest.Application.MapImage.Models;
using CodingTest.Application.MapImage.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingTest.WebApi.Controllers
{
	// TODO: solve as many of the unimplemented tasks below as you can
	// All tasks should be implemented using the same service specified below
	// service url: https://sampleserver1.arcgisonline.com/ArcGIS/rest/services/Demographics/ESRI_Census_USA/MapServer/
	// service api help page: http://sampleserver1.arcgisonline.com/ArcGIS/SDK/REST/index.html?mapserver.html
	public class MapServiceController : MediatRController
	{
		// TODO: implement a handler for this endpoint that returns a list of layers from a given service (use the service url provided above)
		// api help page: http://sampleserver1.arcgisonline.com/ArcGIS/SDK/REST/index.html?layer.html
		
        [HttpGet("layers")]
        //Ändrar implementationen från en lista av LayerViewModel till en enkel LayerViewModel
        //Eftersom det enbart är GET requests så finnns det inte någon anledning till att
        //Implementera validatorer då input från klient saknas.
		public async Task<ActionResult<LayerViewModel>> GetLayers() =>
			Ok(await Mediator.Send(new GetLayersQuery()));

		// TODO: implement a handler for this endpoint that returns a list of layers that supports the "Query" Operation (use the service url provided above)
		// api help page: http://sampleserver1.arcgisonline.com/ArcGIS/SDK/REST/index.html?layer.html
		[HttpGet("queriableLayers")]
		public async Task<ActionResult<List<LayerViewModel>>> GetQueriableLayers() =>
			Ok(await Mediator.Send(new GetQueriableLayersQuery()));

		// TODO: implement a handler for this endpoint that returns the image url of the map for a given bounding box
		// api help page: http://sampleserver1.arcgisonline.com/ArcGIS/SDK/REST/index.html?export.html
		// test values: -207.682974279982,-40.6075371681153,-37.1804225764967,129.89501453537
		[HttpGet("mapImage")]
		public async Task<ActionResult<MapImageViewModel>> GetMapImage() =>
			Ok(await Mediator.Send(new GetMapImageQuery { /* TODO: Implement me*/ }));
	}
}
