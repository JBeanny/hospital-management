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

        public Consultant(ObjectId Id, string date, Doctor doctor, Patient patient, Room room)
        {
            this.Id = Id;
            this.Date = date;
            this.Doctor = doctor;
            this.Patient = patient;
            this.Room = room;
        }
    }
}
