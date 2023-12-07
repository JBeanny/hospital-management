using HospitalManagement.Models;
using HospitalManagement.Services;
using HospitalManagement.Utils;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalManagement.Forms
{
    public partial class AddConsultantForm : Form
    {
        private List<Doctor> doctors;
        private List<Patient> patients;
        private List<Room> rooms;
        private Consultant Consultant = null;

        private ConsultantService consultantService = new ConsultantService();
        private DoctorService doctorService = new DoctorService();
        private PatientService patientService = new PatientService();
        private RoomService roomService = new RoomService();

        // Edit
        public AddConsultantForm(Consultant consultant, List<Doctor> doctors, List<Patient> patients, List<Room> rooms)
        {
            InitializeComponent();
            Consultant = consultant;

            if (Consultant == null)
            {
                MessageBox.Show("No doctor is selected", "Edit Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // set value to input fields
            this.DateForm.Text = consultant.Date;
            this.DoctorForm.Text = consultant.Doctor.Id + "-" + consultant.Doctor.name;
            this.PatientForm.Text = consultant.Patient.Id + "-" + consultant.Patient.name;
            this.RoomForm.Text = consultant.Room.Id + "-" + consultant.Room.number;

            this.Consultant = consultant;

            foreach (Doctor doctor in doctors)
            {
                this.DoctorForm.Items.Add(doctor.Id + "-" + doctor.name);
            }

            foreach (Patient patient in patients)
            {
                this.PatientForm.Items.Add(patient.Id + "-" + patient.name);
            }

            foreach (Room room in rooms)
            {
                this.RoomForm.Items.Add(room.Id + "-" + room.number);
            }

            ConfirmBtn.Text = "Edit";
            ConfirmBtn.Click += handleEdit;
        }

        public AddConsultantForm(List<Doctor> doctors, List<Patient> patients, List<Room> rooms)
        {
            InitializeComponent();
            this.doctors = doctors;
            this.patients = patients;
            this.rooms = rooms;

            foreach (Doctor doctor in doctors)
            {
                this.DoctorForm.Items.Add(doctor.Id + "-" + doctor.name);
            }

            foreach (Patient patient in patients)
            {
                this.PatientForm.Items.Add(patient.Id + "-" + patient.name);
            }

            foreach (Room room in rooms)
            {
                this.RoomForm.Items.Add(room.Id + "-" + room.number);
            }

            ConfirmBtn.Click += handleRegister;
        }

        private void handleEdit(object sender, EventArgs e)
        {
            string date = DateForm.Text;
            string doctor = DoctorForm.Text;
            string patient = PatientForm.Text;
            string room = RoomForm.Text;

            if (Util.AreAnyNullOrEmpty(date, doctor, patient, room))
            {
                MessageBox.Show("Please fill in the required fields", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ObjectId doctorId = ObjectId.Parse(doctor.Split('-')[0]);
            Doctor selectedDoctor = doctorService.getDoctor(doctorId);

            ObjectId patientId = ObjectId.Parse(patient.Split('-')[0]);
            Patient selectedPatient = patientService.getPatient(patientId);

            ObjectId roomId = ObjectId.Parse(room.Split('-')[0]);
            Room selectedRoom = roomService.getRoom(roomId);

            Consultant existedConsultant = consultantService.getConsultation(Consultant.Id);

            if (existedConsultant == null)
            {
                MessageBox.Show("Doctor is not found", "Failed to find doctor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Consultant updatedConsultant = new Consultant(existedConsultant.Id, date, selectedDoctor, selectedPatient, selectedRoom);

            consultantService.modifyConsultation(existedConsultant.Id, updatedConsultant);
            this.Close();
        }


        private void handleRegister(object sender, EventArgs e)
        {
            string date = DateForm.Text;
            string doctor = DoctorForm.Text;
            string patient = PatientForm.Text;
            string room = RoomForm.Text;

            if (Util.AreAnyNullOrEmpty(date, doctor, patient, room))
            {
                MessageBox.Show("Please fill in the required fields", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ObjectId doctorId = ObjectId.Parse(doctor.Split('-')[0]);
            Doctor selectedDoctor = doctorService.getDoctor(doctorId);

            ObjectId patientId = ObjectId.Parse(patient.Split('-')[0]);
            Patient selectedPatient = patientService.getPatient(patientId);

            ObjectId roomId = ObjectId.Parse(room.Split('-')[0]);
            Room selectedRoom = roomService.getRoom(roomId);

            ObjectId consultationObjectId = new ObjectId();
            Consultant consultant = new Consultant(consultationObjectId, date, selectedDoctor, selectedPatient, selectedRoom);

            consultantService.createConsultation(consultant);
            ClearForm();
        }

        private void ClearForm()
        {
            DoctorForm.Text = "";
            PatientForm.Text = "";
            RoomForm.Text = "";
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
