using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Transit_Dev_API_1.Models
{
    public class ProgrammedStop
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("code")]
        public string Code { get; set; }

        [BsonElement("distance_from_origin_km")]
        public decimal DistanceFromOriginKm { get; set; }

        [BsonElement("bus_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BusId { get; set; }

        [BsonElement("programmed_time")]
        public decimal ProgrammedTime { get; set; }
    }
}
