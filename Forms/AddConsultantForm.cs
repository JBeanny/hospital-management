using HospitalManagement.Models;
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
            foreach (Doctor doctor in doctors)
            {
                this.DoctorForm.Items.Add(doctor.name);
            }
            foreach (Patient patient in patients)
            {
                this.DoctorForm.Items.Add(patient.name);
            }
            foreach (Room room in rooms)
            {
                this.DoctorForm.Items.Add(room.Number);
            }

            ConfirmBtn.Text = "Edit";
            //ConfirmBtn.Click += handleEdit;
        }

        public AddConsultantForm(List<Doctor> doctors, List<Patient> patients, List<Room> rooms)
        {
            InitializeComponent();
            this.doctors = doctors;
            this.patients = patients;
            this.rooms = rooms;

            foreach (Doctor doctor in doctors)
            {
                this.DoctorForm.Items.Add(doctor.name);
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
