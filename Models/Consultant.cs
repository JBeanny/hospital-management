using MongoDB.Bson;

namespace HospitalManagement.Models
{
    public class Consultant
    {
        public ObjectId Id { get; set; }
        public string Date { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Room Room { get; set; }
    }
}
