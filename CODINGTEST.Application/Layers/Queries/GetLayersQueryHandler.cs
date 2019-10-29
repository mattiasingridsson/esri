using CodingTest.Application.Layers.Models;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace CodingTest.Application.Layers.Queries
{
    public class GetLayersQueryHandler : IRequestHandler<GetLayersQuery, LayerViewModel>
	{
        private readonly IMapper _mapper;
        private readonly ILogger<GetLayersQueryHandler> _logger;

        public GetLayersQueryHandler(IMapper mapper, ILogger<GetLayersQueryHandler> logger)
		{
            //Initierar den tänkta mappern
            _mapper = mapper;
            //Lite loggning
            _logger = logger;
        }

		public async Task<LayerViewModel> Handle(GetLayersQuery request, CancellationToken cancellationToken)
        {
            //Hämta svar från ESRI sampleserver
            /*
             Här skulle jag använda ett RESTklient-lib från visual studio marketplace
             Det skulle inte vara några problem att göra det mer än tiden det tar.

            Däremot så är jag inte bekant med på hur man mappar ett REST-svar till ett C#-objekt i denna miljö.
            (Detta har jag dock gjort flera gånger i Java.)
            Om man inte vill använda sig av mappers och reflections så kan man ju såklart själv implementera 
            hur varje klass själv ska parsa ut sina värden från en json-sträng.
            Lämpligen i en konstruktor.

            Skriver därför bara lite pseudo-kod för att ge intryck av att hela kedjan är inräknad.
            */
            MapDto mapDto = new MapDto();
            /*
            svar = restClient.GET("esri-url" + parametrar etc);
            MapDto mapDto = SomeMapper.map(svar, MapDto);

            Min uppfattning är att jag enbart ska lämna listan av layers, inte all metadata!
            Därför hade en IMapper kunnat funka.
            (Som jag förstår kan mappa enkla eller kompositerade attribut-värden från en objekttyp till en annan)
            
             */
            LayerViewModel vm = new LayerViewModel();
            // vm.layers = mapDto.layers - "det mappade svaret från REST-anropet"
            _logger.LogInformation("Send an All-Layers request titled: " + mapDto.documentInfo.Title + ", without any errors");
            return vm;

            // Fånga eventuella exceptions här, logga felet eller kasta vidare!
		}
	}
}
