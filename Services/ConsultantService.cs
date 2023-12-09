using hospital_management_system.Service;
using HospitalManagement.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace HospitalManagement.Services
{
    public class ConsultantService
    {
        private static string _document = "appointments";
        private MongoDBService _mongoDBService = new MongoDBService();

        public List<Consultant> getConsultations()
        {
            List<Consultant> consultations = _mongoDBService.GetAllDocuments<Consultant>(_document);
            return consultations;
        }

        public void createConsultation(Consultant newConsultation)
        {
            _mongoDBService.InsertDocument(_document, newConsultation);
        }

        public void deleteConsultation(ObjectId consultationId)
        {
            _mongoDBService.DeleteDocument<Consultant>(_document, consultationId);
        }

        public Consultant getConsultation(ObjectId consultationId)
        {
            return _mongoDBService.GetDocumentById<Consultant>(_document, consultationId);
        }

        public void modifyConsultation(ObjectId consultationId, Consultant consultationToModify)
        {
            _mongoDBService.UpdateDocument<Consultant>(_document, consultationId, consultationToModify);
        }

        public Consultant getConsultationByConsultationId(string consultation_id)
        {
            return _mongoDBService.GetDocumentByModelId<Consultant>(_document, "consultation_id", consultation_id);
        }

        public Boolean duplicateDateTime(string consultation_id, string date)
        {
            Boolean result = false;
            Consultant consultation = _mongoDBService.GetDocumentByModelId<Consultant>(_document, "doctor_id", consultation_id);

            if (consultation != null && date == consultation.Date)
            {
                result = true;
            }

            return result;
        }
    }
}
