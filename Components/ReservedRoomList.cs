using System;
using System.Windows.Forms;

namespace HospitalManagement.Components
{
    public partial class ReservedRoomList : UserControl
    {
        public string Date { get => "2023"; set => DateLabel.Text = value; }
        public event EventHandler OnSelect = null;
        public ReservedRoomList()
        {
            InitializeComponent();
        }

        private void DateLabel_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
