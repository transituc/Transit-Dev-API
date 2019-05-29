using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Transit_Dev_API_1.Models
{
    public class NextStop
    {

        /// <summary>
        /// The id of the bus for which this programmed time applies.
        /// </summary>
        [BsonElement("bus_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BusId { get; set; }

        /// <summary>
        /// Linear distance, in km, measured from origin.
        /// </summary>
        [BsonElement("distance_from_origin_km")]
        public decimal DistanceFromOriginKm { get; set; }

        public NextStopResponse CalculateNextStop(NextStop nextStop)
        {
            ProgrammedStop programmedStop = new ProgrammedStop();

            //Filtro las paradas correspondientes al bus, con el bus ID (nextStop.BusId)
            //Luego, En la coleccion, reviso de acuerdo a la distancia de su origen, cual es la mas cercana de acuerdo a 
            //la distancia de origen actual del bus (nextStop.DistanceFromOriginKm)
            //Retorno la estructura solicitada. 
            //*** La estructura definidida en NextStopResponse no cumple con la solicitada, 
            //no supe definir la coleccion de next_stop.
            return null;

        }


    }
}
