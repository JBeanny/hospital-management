using hospital_management_system.Service;
using HospitalManagement.Models;
using MongoDB.Bson;
using System.Collections.Generic;

namespace HospitalManagement.Services
{
    public class RoomService
    {
        private MongoDBService _mongoDBService = new MongoDBService();
        private static string _document = "rooms";

        public List<Room> getRooms()
        {
            return _mongoDBService.GetAllDocuments<Room>(_document);
        }

        public Room getRoom(ObjectId roomId)
        {
            return _mongoDBService.GetDocumentById<Room>(_document, roomId);
        }
    }
}
