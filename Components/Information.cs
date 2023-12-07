using System.Windows.Forms;

namespace HospitalManagement.Components
{
    public partial class Information : UserControl
    {
        public string InformationText { get => InformationLabel.Text; set => InformationLabel.Text = value; }
        public Information()
        {
            InitializeComponent();
        }
    }
}
