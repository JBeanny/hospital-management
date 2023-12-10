using HospitalManagement.Models;
using HospitalManagement.Services;
using HospitalManagement.Utils;
using MongoDB.Bson;
using System;
using System.Windows.Forms;

namespace HospitalManagement.Forms
{
    public partial class AddPatientForm : Form
    {
        private PatientService patientService = new PatientService();
        private Patient PatientToUpdate = null;

        public AddPatientForm()
        {
            InitializeComponent();
            ConfirmBtn.Click += handleRegister;
        }

        public AddPatientForm(Patient patient)
        {
            InitializeComponent();
            PatientToUpdate = patient;

            if (PatientToUpdate == null)
            {
                MessageBox.Show("No patient is selected", "Edit Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // set value to input fields
            NameInput.Text = patient.name;
            EmailInput.Text = patient.email;
            GenderInput.Text = patient.gender;
            BirthDateInput.Text = patient.birth_date;
            PhoneInput.Text = patient.phone_number;
            WeightInput.Text = patient.weight;
            HeightInput.Text = patient.height;
            BloodTypeInput.Text = patient.blood_type;
            SicknessesInput.Text = patient.sicknesses;
            AllergiesInput.Text = patient.allergies;

            ConfirmBtn.Text = "Edit";
            ConfirmBtn.Click += handleEdit;
        }

        private void handleEdit(object sender, EventArgs e)
        {
            string name = NameInput.Text;
            string email = EmailInput.Text;
            string gender = GenderInput.Text;
            string birthdate = BirthDateInput.Text;
            string phone_number = PhoneInput.Text;
            string weight = WeightInput.Text;
            string height = HeightInput.Text;
            string blood_type = BloodTypeInput.Text;
            string sickness = SicknessesInput.Text;
            string allergies = AllergiesInput.Text;

            if (Util.AreAnyNullOrEmpty(name, email, phone_number, gender, birthdate, weight, height, blood_type, sickness, allergies))
            {
                MessageBox.Show("Please fill in the required fields", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Patient patient = new Patient(PatientToUpdate.Id, name, phone_number, email, gender, birthdate, weight, height, blood_type, sickness, allergies);

            Patient existedPatient = patientService.getPatient(PatientToUpdate.Id);

            Patient localPatient = HomePage.Patients.Find(_p => _p.Id == existedPatient.Id);
            localPatient.name = name;
            localPatient.email = email;
            localPatient.gender = gender;
            localPatient.birth_date = BirthDateInput.Text;
            localPatient.phone_number = PhoneInput.Text;
            localPatient.weight = WeightInput.Text;
            localPatient.height = HeightInput.Text;
            localPatient.blood_type = BloodTypeInput.Text;
            localPatient.sicknesses = SicknessesInput.Text;
            localPatient.allergies = AllergiesInput.Text;
            MessageBox.Show(localPatient.email);

            if (existedPatient == null)
            {
                MessageBox.Show("Patient is not found", "Failed to find patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            patientService.modifyPatient(existedPatient.Id, patient);
            this.Close();
        }

        private void handleRegister(object sender, EventArgs e)
        {
            string name = NameInput.Text;
            string email = EmailInput.Text;
            string gender = GenderInput.Text;
            string birthdate = BirthDateInput.Text;
            string phone_number = PhoneInput.Text;
            string weight = WeightInput.Text;
            string height = HeightInput.Text;
            string blood_type = BloodTypeInput.Text;
            string sickness = SicknessesInput.Text;
            string allergies = AllergiesInput.Text;

            if (Util.AreAnyNullOrEmpty(name, email, phone_number, gender, birthdate, weight, height, blood_type, sickness, allergies))
            {
                MessageBox.Show("Please fill in the required fields", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ObjectId patientObjectId = new ObjectId();
            Patient patient = new Patient(patientObjectId, name, email, phone_number, gender, birthdate, weight, height, blood_type, sickness, allergies);
            patientService.createPatient(patient);

            ClearForm();
        }

        private void ClearForm()
        {
            NameInput.Text = "";
            EmailInput.Text = "";
            GenderInput.Text = "";
            BirthDateInput.Text = "";
            PhoneInput.Text = "";
            WeightInput.Text = "";
            HeightInput.Text = "";
            BloodTypeInput.Text = "";
            SicknessesInput.Text = "";
            AllergiesInput.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
