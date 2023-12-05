using hospital_management_system.Service;
using HospitalManagement.Models;
using MongoDB.Bson;
using System.Collections.Generic;

namespace HospitalManagement.Services
{
    public class PatientService
    {
        private static string _document = "patients";
        private MongoDBService _mongoDBService = new MongoDBService();

        public List<Patient> getPatients()
        {
            List<Patient> patients = _mongoDBService.GetAllDocuments<Patient>(_document);
            return patients;
        }

        public void createPatient(Patient newPatient)
        {
            _mongoDBService.InsertDocument(_document, newPatient);
        }

        public void deletePatient(ObjectId patientId)
        {
            _mongoDBService.DeleteDocument<Patient>(_document, patientId);
        }

        public Patient getPatient(ObjectId patientId)
        {
            return _mongoDBService.GetDocumentById<Patient>(_document, patientId);
        }

        public void modifyPatient(ObjectId patientId, Patient patientToModify)
        {
            _mongoDBService.UpdateDocument<Patient>(_document, patientId, patientToModify);
        }
    }
}
