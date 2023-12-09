using HospitalManagement.Components;
using HospitalManagement.Forms;
using HospitalManagement.Models;
using HospitalManagement.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class HomePage : Form
    {
        AddDoctorForm AddDoctorForm = null;
        AddPatientForm AddPatientForm = null;
        AddConsultantForm AddConsultantForm = null;
        DeleteForm DeleteForm = null;
        public static List<Room> Rooms;
        public static List<Doctor> Doctors;
        public static List<Patient> Patients;
        public static List<Consultant> Consultants;
        string currentPage = "Rooms";
        ItemCard currentSelectItem = null;
        private DoctorService DoctorService = new DoctorService();
        private PatientService PatientService = new PatientService();
        private RoomService RoomService = new RoomService();
        private ConsultantService ConsultantService = new ConsultantService();

        // selected
        private dynamic selectedModel = null;

        public HomePage()
        {
            InitializeComponent();
            EditButton.Click += handleEdit;
        }

        private void handleEdit(object sender, EventArgs e)
        {
            if (currentPage == "Rooms")
            {
                if (AddConsultantForm == null || AddConsultantForm.IsDisposed)
                {
                    AddConsultantForm = new AddConsultantForm(selectedModel, Doctors, Patients, Rooms);
                    AddConsultantForm.Show();
                }
            }

            if (currentPage == "Doctors")
            {
                if (AddDoctorForm == null || AddDoctorForm.IsDisposed)
                {
                    AddDoctorForm = new AddDoctorForm(selectedModel);
                    AddDoctorForm.Show();
                }
            }

            if (currentPage == "Patients")
            {
                if (AddPatientForm == null || AddPatientForm.IsDisposed)
                {
                    AddPatientForm = new AddPatientForm(selectedModel);
                    AddPatientForm.Show();
                }
            }
        }

        private void AddItem(string title, string description, string picture, string searchText, dynamic Object)
        {
            ItemCard item = new ItemCard()
            {
                Title = title,
                Description = description,
                Picture = Image.FromFile("Resources/" + picture),
                SearchText = searchText
            };
            item.OnSelect += (ss, ee) =>
            {
                if (currentSelectItem != null)
                {
                    this.currentSelectItem.BackColor = Color.White;
                    RightPanel.Controls.Clear();
                }

                item.BackColor = ColorTranslator.FromHtml("#a7f3d0");
                this.currentSelectItem = item;
                selectedModel = Object;
                if (currentPage == "Rooms")
                {

                }
                if (currentPage == "Doctors")
                {
                    Doctor doctor = (Doctor)selectedModel;
                    Information information = new Information();

                    information.InformationText = "Id: " + doctor.Id.ToString() + "\n";
                    information.InformationText += "Name: " + doctor.name + "\n";
                    information.InformationText += "Email: " + doctor.email + "\n";
                    information.InformationText += "Gender: " + doctor.gender + "\n";
                    information.InformationText += "Birth Date: " + doctor.birth_date + "\n";
                    information.InformationText += "Phone Number: " + doctor.phone_number + "\n";
                    information.InformationText += "Specialty: " + doctor.specialty + "\n";
                    RightPanel.Controls.Add(information);
                }
                if (currentPage == "Patients")
                {
                    Patient patient = (Patient)selectedModel;
                    Information information = new Information();

                    information.InformationText = "Id: " + patient.Id.ToString() + "\n";
                    information.InformationText += "Name: " + patient.name + "\n";
                    information.InformationText += "Email: " + patient.email + "\n";
                    information.InformationText += "Gender: " + patient.gender + "\n";
                    information.InformationText += "Birth Date: " + patient.birth_date + "\n";
                    information.InformationText += "Phone Number: " + patient.phone_number + "\n";
                    information.InformationText += "Weight: " + patient.weight + "\n";
                    information.InformationText += "Height: " + patient.height + "\n";
                    information.InformationText += "Blood Type: " + patient.blood_type + "\n";
                    information.InformationText += "Sicknesses: " + patient.sicknesses + "\n";
                    information.InformationText += "Allergies: " + patient.allergies + "\n";
                    RightPanel.Controls.Add(information);
                }
            };
            ListPanel.Controls.Add(item);
        }

        private void ActiveMenu()
        {
            if (currentPage == "Rooms")
            {
                ListPanel.Controls.Clear();
                RightPanel.Controls.Clear();
                RightLabel.Text = "Room";
                ReservedHeadingPanel.Show();

                RoomButton.BackColor = ColorTranslator.FromHtml("#4f46e5");
                DoctorButton.BackColor = ColorTranslator.FromHtml("#6366f1");
                PatientButton.BackColor = ColorTranslator.FromHtml("#6366f1");
            }

            if (currentPage == "Doctors")
            {
                ListPanel.Controls.Clear();
                RightLabel.Text = "Doctors";
                ReservedHeadingPanel.Hide();
                RightPanel.Controls.Clear();

                RoomButton.BackColor = ColorTranslator.FromHtml("#6366f1");
                DoctorButton.BackColor = ColorTranslator.FromHtml("#4f46e5");
                PatientButton.BackColor = ColorTranslator.FromHtml("#6366f1");
            }

            if (currentPage == "Patients")
            {
                ListPanel.Controls.Clear();
                RightLabel.Text = "Patients";
                ReservedHeadingPanel.Hide();
                RightPanel.Controls.Clear();

                RoomButton.BackColor = ColorTranslator.FromHtml("#6366f1");
                DoctorButton.BackColor = ColorTranslator.FromHtml("#6366f1");
                PatientButton.BackColor = ColorTranslator.FromHtml("#4f46e5");
            }
        }

        private void initialLoadData(object sender, EventArgs e)
        {
            timer1.Stop();
            Doctors = DoctorService.getDoctors();
            Patients = PatientService.getPatients();
            Rooms = RoomService.getRooms();
            Consultants = ConsultantService.getConsultations();
        }
        private void RoomMenuButton(object sender, EventArgs e)
        {
            currentPage = "Rooms";
            ActiveMenu();
            Consultants = ConsultantService.getConsultations();

            // Add Room Data
            Consultants.ForEach(consultant =>
            {
                AddItem("Room", "Room: " + consultant.Room.number, "room.jpg", consultant.Room.number, consultant);
            });

        }

        private void DoctorMenuButton(object sender, EventArgs e)
        {
            currentPage = "Doctors";
            ActiveMenu();
            Doctors = DoctorService.getDoctors();

            // Add Doctor Data
            Doctors.ForEach(doctor =>
            {
                AddItem(doctor.name, doctor.gender, "doctor.png", doctor.name, doctor);
            });

        }

        private void PatientMenuButton(object sender, EventArgs e)
        {
            currentPage = "Patients";
            ActiveMenu();
            Patients = PatientService.getPatients();

            // Add Patient Data
            Patients.ForEach(patient =>
            {
                AddItem(patient.name, patient.gender, "patient.png", patient.name, patient);
            });

        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (var _item in ListPanel.Controls)
            {
                var item = (ItemCard)_item;
                item.Visible = item.SearchText.ToLower().Contains(SearchBox.Text.ToLower());
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (currentPage == "Rooms")
            {
                if (AddConsultantForm == null || AddConsultantForm.IsDisposed)
                {
                    AddConsultantForm = new AddConsultantForm(Doctors, Patients, Rooms);
                    AddConsultantForm.Show();
                }
            }

            if (currentPage == "Doctors")
            {
                if (AddDoctorForm == null || AddDoctorForm.IsDisposed)
                {
                    AddDoctorForm = new AddDoctorForm();
                    AddDoctorForm.Show();
                }
            }

            if (currentPage == "Patients")
            {
                if (AddPatientForm == null || AddPatientForm.IsDisposed)
                {
                    AddPatientForm = new AddPatientForm();
                    AddPatientForm.Show();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (currentPage == "Rooms")
            {
                if (DeleteForm == null || DeleteForm.IsDisposed)
                {
                    DeleteForm = new DeleteForm();
                    DeleteForm.OnDelete += (ss, ee) =>
                    {
                        if (selectedModel == null)
                        {
                            MessageBox.Show("No consultant is selected", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        Consultant existedConsultant = ConsultantService.getConsultation(selectedModel.Id);

                        if (existedConsultant == null)
                        {
                            MessageBox.Show("Consultant is not found", "Failed to find consultant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        ConsultantService.deleteConsultation(existedConsultant.Id);
                    };
                    DeleteForm.Show();
                }
            }

            if (currentPage == "Doctors")
            {
                if (DeleteForm == null || DeleteForm.IsDisposed)
                {
                    DeleteForm = new DeleteForm();
                    DeleteForm.OnDelete += (ss, ee) =>
                    {
                        if (selectedModel == null)
                        {
                            MessageBox.Show("No doctor is selected", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        Doctor existedDoctor = DoctorService.getDoctor(selectedModel.Id);

                        if (existedDoctor == null)
                        {
                            MessageBox.Show("Doctor is not found", "Failed to find doctor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        DoctorService.deleteDoctor(existedDoctor.Id);
                    };
                    DeleteForm.Show();
                }
            }

            if (currentPage == "Patients")
            {
                if (DeleteForm == null || DeleteForm.IsDisposed)
                {
                    DeleteForm = new DeleteForm();
                    DeleteForm.OnDelete += (ss, ee) =>
                    {
                        if (selectedModel == null)
                        {
                            MessageBox.Show("No patient is selected", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        Patient existedPatient = PatientService.getPatient(selectedModel.Id);

                        if (existedPatient == null)
                        {
                            MessageBox.Show("Patient is not found", "Failed to find doctor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        PatientService.deletePatient(existedPatient.Id);
                    };
                    DeleteForm.Show();
                }
            }
        }
    }
}
