namespace HospitalManagement.Components
{
    partial class Information
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.InformationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InformationLabel
            // 
            resources.ApplyResources(this.InformationLabel, "InformationLabel");
            this.InformationLabel.Name = "InformationLabel";
            // 
            // Information
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InformationLabel);
            this.Name = "Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InformationLabel;
    }
}
