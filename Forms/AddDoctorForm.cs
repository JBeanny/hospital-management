using HospitalManagement.Models;
using HospitalManagement.Services;
using HospitalManagement.Utils;
using MongoDB.Bson;
using System;
using System.Windows.Forms;

namespace HospitalManagement.Forms
{
    public partial class AddDoctorForm : Form
    {
        private DoctorService doctorService = new DoctorService();
        private Doctor DoctorToUpdate = null;

        public AddDoctorForm()
        {
            InitializeComponent();
            ConfirmBtn.Click += handleRegister;
        }

        public AddDoctorForm(Doctor doctor)
        {
            InitializeComponent();
            DoctorToUpdate = doctor;

            if (DoctorToUpdate == null)
            {
                MessageBox.Show("No doctor is selected", "Edit Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // set value to input fields
            NameInput.Text = doctor.name;
            EmailInput.Text = doctor.email;
            GenderInput.Text = doctor.gender;
            BirthDateInput.Text = doctor.birth_date;
            SpecialtyInput.Text = doctor.specialty;
            PhoneNumberInput.Text = doctor.phone_number;

            ConfirmBtn.Text = "Edit";
            ConfirmBtn.Click += handleEdit;
        }

        private void handleEdit(object sender, EventArgs e)
        {
            string name = NameInput.Text;
            string email = EmailInput.Text;
            string gender = GenderInput.Text;
            string birthdate = BirthDateInput.Text;
            string specialty = SpecialtyInput.Text;
            string contact = PhoneNumberInput.Text;

            if (Util.AreAnyNullOrEmpty(name, email, gender, birthdate, specialty, contact))
            {
                MessageBox.Show("Please fill in the required fields", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Doctor doctor = new Doctor(DoctorToUpdate.Id, name, contact, email, gender, birthdate, specialty);

            Doctor existedDoctor = doctorService.getDoctor(DoctorToUpdate.Id);

            if (existedDoctor == null)
            {
                MessageBox.Show("Doctor is not found", "Failed to find doctor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            doctorService.modifyDoctor(existedDoctor.Id, doctor);
            this.Close();
        }

        private void handleRegister(object sender, EventArgs e)
        {
            string name = NameInput.Text;
            string email = EmailInput.Text;
            string gender = GenderInput.Text;
            string birthdate = BirthDateInput.Text;
            string specialty = SpecialtyInput.Text;
            string contact = PhoneNumberInput.Text;

            if (Util.AreAnyNullOrEmpty(name, email, gender, birthdate, specialty, contact))
            {
                MessageBox.Show("Please fill in the required fields", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ObjectId doctorObjectId = new ObjectId();
            Doctor doctor = new Doctor(doctorObjectId, name, contact, email, gender, birthdate, specialty);
            doctorService.createDoctor(doctor);
            ClearForm();
        }

        private void ClearForm()
        {
            NameInput.Text = "";
            EmailInput.Text = "";
            GenderInput.Text = "";
            BirthDateInput.Text = "";
            SpecialtyInput.Text = "";
            PhoneNumberInput.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
