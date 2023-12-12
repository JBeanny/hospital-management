namespace HospitalManagement
{
    partial class HomePage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add = new FontAwesome.Sharp.IconButton();
            this.PatientButton = new FontAwesome.Sharp.IconButton();
            this.DoctorButton = new FontAwesome.Sharp.IconButton();
            this.RoomButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ReservedHeadingPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.DeleteButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.RightLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.ReservedHeadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.panel1.Size = new System.Drawing.Size(250, 661);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.PatientButton);
            this.panel2.Controls.Add(this.DoctorButton);
            this.panel2.Controls.Add(this.RoomButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panel2.Size = new System.Drawing.Size(250, 578);
            this.panel2.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.Add.IconColor = System.Drawing.Color.White;
            this.Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Add.Location = new System.Drawing.Point(0, 524);
            this.Add.Margin = new System.Windows.Forms.Padding(0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(250, 54);
            this.Add.TabIndex = 0;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // PatientButton
            // 
            this.PatientButton.BackColor = System.Drawing.Color.Transparent;
            this.PatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PatientButton.FlatAppearance.BorderSize = 0;
            this.PatientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.PatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.PatientButton.IconChar = FontAwesome.Sharp.IconChar.HeartCircleBolt;
            this.PatientButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.PatientButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PatientButton.IconSize = 32;
            this.PatientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatientButton.Location = new System.Drawing.Point(0, 108);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.PatientButton.Size = new System.Drawing.Size(250, 50);
            this.PatientButton.TabIndex = 3;
            this.PatientButton.Text = "             Patients";
            this.PatientButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatientButton.UseVisualStyleBackColor = false;
            this.PatientButton.Click += new System.EventHandler(this.PatientMenuButton);
            // 
            // DoctorButton
            // 
            this.DoctorButton.BackColor = System.Drawing.Color.Transparent;
            this.DoctorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoctorButton.FlatAppearance.BorderSize = 0;
            this.DoctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.DoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.DoctorButton.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            this.DoctorButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.DoctorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DoctorButton.IconSize = 32;
            this.DoctorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DoctorButton.Location = new System.Drawing.Point(0, 58);
            this.DoctorButton.Name = "DoctorButton";
            this.DoctorButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.DoctorButton.Size = new System.Drawing.Size(250, 50);
            this.DoctorButton.TabIndex = 2;
            this.DoctorButton.Text = "             Doctors";
            this.DoctorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DoctorButton.UseVisualStyleBackColor = false;
            this.DoctorButton.Click += new System.EventHandler(this.DoctorMenuButton);
            // 
            // RoomButton
            // 
            this.RoomButton.BackColor = System.Drawing.Color.Transparent;
            this.RoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoomButton.FlatAppearance.BorderSize = 0;
            this.RoomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.RoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.RoomButton.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.RoomButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.RoomButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RoomButton.IconSize = 32;
            this.RoomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoomButton.Location = new System.Drawing.Point(0, 8);
            this.RoomButton.Name = "RoomButton";
            this.RoomButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.RoomButton.Size = new System.Drawing.Size(250, 50);
            this.RoomButton.TabIndex = 1;
            this.RoomButton.Text = "             Rooms";
            this.RoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoomButton.UseVisualStyleBackColor = false;
            this.RoomButton.Click += new System.EventHandler(this.RoomMenuButton);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::HospitalManagement.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.initialLoadData);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(250, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListPanel);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(984, 661);
            this.splitContainer1.SplitterDistance = 728;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // ListPanel
            // 
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 62);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(728, 599);
            this.ListPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.iconPictureBox2);
            this.panel4.Controls.Add(this.SearchBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(16);
            this.panel4.Size = new System.Drawing.Size(728, 62);
            this.panel4.TabIndex = 1;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 22;
            this.iconPictureBox2.Location = new System.Drawing.Point(574, 20);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(22, 26);
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(15, 19);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(545, 22);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RightPanel);
            this.panel3.Controls.Add(this.ReservedHeadingPanel);
            this.panel3.Controls.Add(this.DeleteButton);
            this.panel3.Controls.Add(this.EditButton);
            this.panel3.Controls.Add(this.RightLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 16, 8, 8);
            this.panel3.Size = new System.Drawing.Size(255, 661);
            this.panel3.TabIndex = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.AutoScroll = true;
            this.RightPanel.AutoSize = true;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(8, 159);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.RightPanel.Size = new System.Drawing.Size(239, 494);
            this.RightPanel.TabIndex = 5;
            // 
            // ReservedHeadingPanel
            // 
            this.ReservedHeadingPanel.Controls.Add(this.label2);
            this.ReservedHeadingPanel.Controls.Add(this.iconPictureBox1);
            this.ReservedHeadingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReservedHeadingPanel.Location = new System.Drawing.Point(8, 122);
            this.ReservedHeadingPanel.Name = "ReservedHeadingPanel";
            this.ReservedHeadingPanel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.ReservedHeadingPanel.Size = new System.Drawing.Size(239, 37);
            this.ReservedHeadingPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reserved";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(31, 29);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DeleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DeleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteButton.IconSize = 24;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(8, 92);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(8);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(239, 30);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(254)))));
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(163)))));
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.EditButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(163)))));
            this.EditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditButton.IconSize = 24;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location = new System.Drawing.Point(8, 62);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(239, 30);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // RightLabel
            // 
            this.RightLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightLabel.Location = new System.Drawing.Point(8, 16);
            this.RightLabel.Name = "RightLabel";
            this.RightLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.RightLabel.Size = new System.Drawing.Size(239, 46);
            this.RightLabel.TabIndex = 0;
            this.RightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(915, 600);
            this.Name = "HomePage";
            this.Text = "Hospital Management";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ReservedHeadingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton RoomButton;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton PatientButton;
        private FontAwesome.Sharp.IconButton DoctorButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel ListPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label RightLabel;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel ReservedHeadingPanel;
        private System.Windows.Forms.FlowLayoutPanel RightPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox SearchBox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton Add;
        private FontAwesome.Sharp.IconButton EditButton;
        private FontAwesome.Sharp.IconButton DeleteButton;
    }
}

