using System.Collections.Generic;
using System.Linq;
using Transit_Dev_API_1.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Transit_Dev_API_1.Services
{
    public class ProgrammedStopService
    {
        private readonly IMongoCollection<ProgrammedStop> _stops;

        public ProgrammedStopService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("TransitDb"));
            var database = client.GetDatabase("transit_test");
            _stops = database.GetCollection<ProgrammedStop>("programmed_stops");
        }

        public List<ProgrammedStop> Get()
        {
            return _stops.Find(p => true).ToList();
        }

        public ProgrammedStop Get(string id)
        {
            return _stops.Find<ProgrammedStop>(p => p.Id == id).FirstOrDefault();
        }

        // TODO: Implement appropriate service method(s).

    }
}
