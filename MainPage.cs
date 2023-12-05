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
        List<Room> Rooms;
        List<Doctor> Doctors;
        List<Patient> Patients;
        List<Consultant> Consultants;
        string currentPage = "Rooms";
        ItemCard currentSelectItem = null;
        private DoctorService DoctorService = new DoctorService();

        // selected
        private Doctor selectedDoctor = null;

        //List<>

        public HomePage()
        {
            InitializeComponent();
            EditButton.Click += handleEdit;
        }

        private void handleDelete(object sender, EventArgs e)
        {
            if (selectedDoctor == null)
            {
                MessageBox.Show("No doctor is selected", "Edit Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Doctor existedDoctor = DoctorService.getDoctor(selectedDoctor.Id);

            if (existedDoctor == null)
            {
                MessageBox.Show("Doctor is not found", "Failed to find doctor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DoctorService.deleteDoctor(existedDoctor.Id);
        }

        private void handleEdit(object sender, EventArgs e)
        {
            if (AddDoctorForm == null || AddDoctorForm.IsDisposed)
            {
                AddDoctorForm = new AddDoctorForm(selectedDoctor);
                AddDoctorForm.Show();
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
                selectedDoctor = Object;
                RightPanel.Controls.Add(new ReservedRoomList() { Date = "2023-12-05 12:30:00" });
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

            // Add Room Data
            //AddItem("Room", "Room: #101", "room.jpg", "#101");
            //AddItem("Room", "Room: #102", "room.jpg", "#102");
        }

        private void initialLoadData(object sender, EventArgs e)
        {
            timer1.Stop();
            //AddItem("Room", "#101", "room.jpg", "#101");
            //AddItem("Room", "#101", "room.jpg", "#101");
        }

        private void DoctorMenuButton(object sender, EventArgs e)
        {
            ListPanel.Controls.Clear();
            RightLabel.Text = "Doctors";
            ReservedHeadingPanel.Hide();
            RightPanel.Controls.Clear();
            currentPage = "Doctors";

            // Add Doctor Data
            Doctors = DoctorService.getDoctors();
            Doctors.ForEach(doctor =>
            {
                AddItem(doctor.name, doctor.gender, "doctor.png", doctor.specialty, doctor);
            });
        }

        private void PatientMenuButton(object sender, EventArgs e)
        {
            ListPanel.Controls.Clear();
            RightLabel.Text = "Patients";
            ReservedHeadingPanel.Hide();
            RightPanel.Controls.Clear();
            currentPage = "Patients";

            // Add Patient Data
            //AddItem("Bormey", "", "patient.png", "Bormey");
            //AddItem("Lisa", "", "patient.png", "Lisa");
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
                if (AddDoctorForm == null || AddDoctorForm.IsDisposed)
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
