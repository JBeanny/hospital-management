using System.Windows.Forms;

namespace HospitalManagement.Components
{
    public partial class ReservedRoomList : UserControl
    {
        public string Date { get => "2023"; set => DateLabel.Text = value; }
        public ReservedRoomList()
        {
            InitializeComponent();
        }
    }
}
