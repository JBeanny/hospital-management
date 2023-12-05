using HospitalManagement.Models;
using HospitalManagement.Services;
using HospitalManagement.Utils;
using System;
using System.Windows.Forms;

namespace HospitalManagement.Forms
{
    public partial class AddDoctorForm : Form
    {
        private DoctorService doctorService = new DoctorService();
        private Util util = new Util();

        public AddDoctorForm()
        {
            InitializeComponent();
            ConfirmBtn.Click += handleRegister;
        }

        private void handleRegister(object sender, EventArgs e)
        {
            string name = NameInput.Text;
            string email = EmailInput.Text;
            string gender = GenderInput.Text;
            string birthdate = BirthDateInput.Text;
            string specialty = SpecialtyInput.Text;
            string contact = PhoneNumberInput.Text;

            if (util.IsInputNullOrEmpty(name, email, gender, birthdate, specialty, contact))
            {
                MessageBox.Show("Please fill in the required fields", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Doctor doctor = new Doctor(name, contact, email, gender, birthdate, specialty);
            doctorService.createDoctor(doctor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
