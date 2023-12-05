using MongoDB.Bson;

namespace HospitalManagement.Models
{
    public class Room
    {
        public ObjectId Id { get; set; }
        public Consultant Consultant { get; set; }
        public string Number { get; set; }
    }
}
