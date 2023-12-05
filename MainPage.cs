using HospitalManagement.Components;
using HospitalManagement.Forms;
using HospitalManagement.Models;
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

        //List<>

        public HomePage()
        {
            InitializeComponent();
        }

        private void AddItem(string title, string description, string picture, string searchText)
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
            AddItem("Room", "Room: #101", "room.jpg", "#101");
            AddItem("Room", "Room: #102", "room.jpg", "#102");
        }

        private void initialLoadData(object sender, EventArgs e)
        {
            timer1.Stop();
            AddItem("Room", "#101", "room.jpg", "#101");
            AddItem("Room", "#101", "room.jpg", "#101");
        }

        private void DoctorMenuButton(object sender, EventArgs e)
        {
            ListPanel.Controls.Clear();
            RightLabel.Text = "Doctors";
            ReservedHeadingPanel.Hide();
            RightPanel.Controls.Clear();
            currentPage = "Doctors";

            // Add Doctor Data
            AddItem("Sotharoth", "Room: #101", "doctor.png", "Sotharoth");
            AddItem("Reachsey", "Room: #102", "doctor.png", "Reachsey");
        }

        private void PatientMenuButton(object sender, EventArgs e)
        {
            ListPanel.Controls.Clear();
            RightLabel.Text = "Patients";
            ReservedHeadingPanel.Hide();
            RightPanel.Controls.Clear();
            currentPage = "Patients";

            // Add Patient Data
            AddItem("Bormey", "", "patient.png", "Bormey");
            AddItem("Lisa", "", "patient.png", "Lisa");
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
