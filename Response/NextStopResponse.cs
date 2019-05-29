using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Transit_Dev_API_1.Models
{
    public class NextStopResponse
    {

        /// <summary>
        /// The id of the bus for which this programmed time applies.
        /// </summary>
        [BsonElement("bus_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BusId { get; set; }

        /// <summary>
        /// Bus patent.
        /// </summary>
        [BsonElement("bus_license_plate")]
        public string BusLicensePlate { get; set; }

        /// <summary>
        /// Next stop.
        /// </summary>
        [BsonElement("next_stop")]
        [BsonRepresentation(BsonType.Array)]
        public Array NextStop { get; set; }

        /// <summary>
        /// Next stop by distance.
        /// </summary>
        [BsonElement("next_stop_by_distance")]
        public int NextStopByDistance { get; set; }

        /// <summary>
        /// Next stop by program.
        /// </summary>
        [BsonElement("next_stop_by_program")]
        public int NextStopByProgram { get; set; }


    }
}
