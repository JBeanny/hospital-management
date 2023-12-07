using MongoDB.Bson;

namespace HospitalManagement.Models
{
    public class Room
    {
        public ObjectId Id { get; set; }
        public string number { get; set; }
    }
}
