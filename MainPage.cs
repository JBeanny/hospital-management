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

        private void handleDelete(object sender, EventArgs e)
        {
            if (currentPage == "Rooms")
            {
                if (selectedModel == null)
                {
                    MessageBox.Show("No consultant is selected", "Edit Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Consultant existedConsultant = ConsultantService.getConsultation(selectedModel.Id);

                if (existedConsultant == null)
                {
                    MessageBox.Show("Consultant is not found", "Failed to find consultant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DoctorService.deleteDoctor(existedConsultant.Id);
            }

            if (currentPage == "Doctors")
            {
                if (selectedModel == null)
                {
                    MessageBox.Show("No doctor is selected", "Edit Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Doctor existedDoctor = DoctorService.getDoctor(selectedModel.Id);

                if (existedDoctor == null)
                {
                    MessageBox.Show("Doctor is not found", "Failed to find doctor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DoctorService.deleteDoctor(existedDoctor.Id);
            }

            // implement
            if (currentPage == "Patients")
            {
                if (AddPatientForm == null || AddPatientForm.IsDisposed)
                {
                    AddPatientForm = new AddPatientForm(selectedModel);
                    AddPatientForm.Show();
                }
            }
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
                //RightPanel.Controls.Add(new ReservedRoomList() { Date = "2023-12-05 12:30:00" });
            };
            ListPanel.Controls.Add(item);
        }

        private void RoomMenuButton(object sender, EventArgs e)
        {
            ListPanel.Controls.Clear();
            RightPanel.Controls.Clear();
            RightLabel.Text = "Room";
            ReservedHeadingPanel.Show();
            currentPage = "Rooms";
            Consultants = ConsultantService.getConsultations();

            // Add Room Data
            Consultants.ForEach(consultant =>
            {
                AddItem(consultant.Room.number, consultant.Date, "room.jpg", consultant.Room.number, consultant);
            });
        }

        private void initialLoadData(object sender, EventArgs e)
        {
            timer1.Stop();
            //Doctors = DoctorService.getDoctors();
            //Patients = PatientService.getPatients();
            Rooms = RoomService.getRooms();
            //Consultants = ConsultantService.getConsultations();
        }

        private void DoctorMenuButton(object sender, EventArgs e)
        {
            ListPanel.Controls.Clear();
            RightLabel.Text = "Doctors";
            ReservedHeadingPanel.Hide();
            RightPanel.Controls.Clear();
            currentPage = "Doctors";
            Doctors = DoctorService.getDoctors();

            // Add Doctor Data
            Doctors.ForEach(doctor =>
            {
                AddItem(doctor.name, doctor.gender, "doctor.png", doctor.name, doctor);
            });
        }

        private void PatientMenuButton(object sender, EventArgs e)
        {
            ListPanel.Controls.Clear();
            RightLabel.Text = "Patients";
            ReservedHeadingPanel.Hide();
            RightPanel.Controls.Clear();
            currentPage = "Patients";
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
    }
}
