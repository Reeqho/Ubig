
namespace Hospital
{
    partial class Main_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iCD11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMeetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.meetingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iCD11ToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.patientToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // iCD11ToolStripMenuItem
            // 
            this.iCD11ToolStripMenuItem.Name = "iCD11ToolStripMenuItem";
            this.iCD11ToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.iCD11ToolStripMenuItem.Text = "ICD-11";
            this.iCD11ToolStripMenuItem.Click += new System.EventHandler(this.iCD11ToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.doctorToolStripMenuItem.Text = "Doctor";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // meetingToolStripMenuItem
            // 
            this.meetingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMeetingToolStripMenuItem,
            this.meetingNotesToolStripMenuItem});
            this.meetingToolStripMenuItem.Name = "meetingToolStripMenuItem";
            this.meetingToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.meetingToolStripMenuItem.Text = "Meeting";
            // 
            // newMeetingToolStripMenuItem
            // 
            this.newMeetingToolStripMenuItem.Name = "newMeetingToolStripMenuItem";
            this.newMeetingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newMeetingToolStripMenuItem.Text = "New Meeting";
            this.newMeetingToolStripMenuItem.Click += new System.EventHandler(this.newMeetingToolStripMenuItem_Click);
            // 
            // meetingNotesToolStripMenuItem
            // 
            this.meetingNotesToolStripMenuItem.Name = "meetingNotesToolStripMenuItem";
            this.meetingNotesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.meetingNotesToolStripMenuItem.Text = "Meeting Notes";
            this.meetingNotesToolStripMenuItem.Click += new System.EventHandler(this.meetingNotesToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iCD11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meetingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMeetingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meetingNotesToolStripMenuItem;
    }
}