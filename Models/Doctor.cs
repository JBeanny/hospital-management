using MongoDB.Bson;

namespace HospitalManagement.Models
{
    public class Doctor : Person
    {
        public ObjectId Id { get; set; }
        public string specialty { get; set; }

        public Doctor(string name, string phone_number, string email, string gender, string birth_date, string specialty) : base(name, phone_number, email, gender, birth_date)
        {
            this.specialty = specialty;
        }

        public Doctor(ObjectId Id, string name, string phone_number, string email, string gender, string birth_date, string specialty) : base(name, phone_number, email, gender, birth_date)
        {
            this.Id = Id;
            this.specialty = specialty;
        }

        public Doctor()
        {

        }
    }
}
