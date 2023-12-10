using HospitalManagement.Models;
using System;

namespace HospitalManagement.Utils
{
    public class Util
    {
        public Boolean IsInputNullOrEmpty(string name, string email, string gender, string birthdate, string specialty, string contact)
        {
            return AreAnyNullOrEmpty(name, email, gender, birthdate, specialty, contact);
        }

        public Boolean IsInputNullOrEmpty(string name, string email, string phonenumber, string gender, string birthdate, string height, string weight, string blood_type, string sicknesses, string allergies)
        {
            return AreAnyNullOrEmpty(name, email, phonenumber, gender, birthdate, height, weight, blood_type, sicknesses, allergies);
        }

        public Boolean IsInputNullOrEmpty(string Date, Doctor Doctor, Patient Patient, string Room)
        {
            return AreAnyNullOrEmpty(Date, Doctor, Patient, Room);
        }

        public static bool AreAnyNullOrEmpty(params object[] values)
        {
            foreach (var value in values)
            {
                if (value == null || (value is string str && string.IsNullOrEmpty(str)))
                {
                    return true;
                }
            }
            return false;
        }
    }

}
