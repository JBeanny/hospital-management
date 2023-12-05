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
        public AddConsultantForm(List<Doctor> doctors, List<Patient> patients, List<Room> rooms)
        {
            InitializeComponent();
            this.doctors = doctors;
            this.patients = patients;
            this.rooms = rooms;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
