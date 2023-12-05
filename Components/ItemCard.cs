using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagement.Components
{
    public partial class ItemCard : UserControl
    {
        public string Description { get => description.Text; set => description.Text = value; }
        public string Title { get => title.Text; set => title.Text = value; }
        public Image Picture { get => pictureBox.Image; set => pictureBox.Image = value; }
        public string SearchText { get; set; }
        public event EventHandler OnSelect = null;

        public ItemCard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
