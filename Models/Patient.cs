using MongoDB.Bson;

namespace HospitalManagement.Models
{
    public class Patient : Person
    {
        public ObjectId Id { get; set; }
        public int age { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string blood_type { get; set; }
        public string sicknesses { get; set; }
        public string allergies { get; set; }

        public Patient(ObjectId id, string name, string phone_number, string email, string gender, string birth_date, string height, string weight, string blood_type, string sicknesses, string allergies) : base(name, phone_number, email, gender, birth_date)
        {
            this.Id = id;
            //this.age = (DateTime.Today - DateTime.Parse(birth_date)).Days;
            this.age = 1;
            this.sicknesses = sicknesses;
            this.allergies = allergies;
            this.height = height;
            this.weight = weight;
            this.blood_type = blood_type;
        }
        public Patient()
        {

        }
    }
}
