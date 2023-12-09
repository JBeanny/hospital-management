using System;
using System.Windows.Forms;

namespace HospitalManagement.Forms
{
    public partial class DeleteForm : Form
    {
        public event EventHandler OnDelete = null;
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OnDelete.Invoke(this, e);
            this.Close();
        }
    }
}
