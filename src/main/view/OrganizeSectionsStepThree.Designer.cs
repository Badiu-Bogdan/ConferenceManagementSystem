
namespace ConferenceManagementSystem.src.main.view
{
    partial class OrganizeSectionsStepThree
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.listbx_rooms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_sections = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_assignedRoom = new System.Windows.Forms.Label();
            this.lbl_capacity = new System.Windows.Forms.Label();
            this.lbl_usersJoined = new System.Windows.Forms.Label();
            this.btn_complete = new System.Windows.Forms.Button();
            this.btn_assignRoom = new System.Windows.Forms.Button();
            this.btn_unassignRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(106, 406);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Step 3/3: Assign the rooms for each section";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(13, 396);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 41);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // listbx_rooms
            // 
            this.listbx_rooms.FormattingEnabled = true;
            this.listbx_rooms.ItemHeight = 16;
            this.listbx_rooms.Location = new System.Drawing.Point(17, 41);
            this.listbx_rooms.Name = "listbx_rooms";
            this.listbx_rooms.Size = new System.Drawing.Size(287, 324);
            this.listbx_rooms.TabIndex = 20;
            this.listbx_rooms.SelectedIndexChanged += new System.EventHandler(this.listbx_rooms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbx_sections
            // 
            this.cmbx_sections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_sections.FormattingEnabled = true;
            this.cmbx_sections.Location = new System.Drawing.Point(408, 9);
            this.cmbx_sections.Name = "cmbx_sections";
            this.cmbx_sections.Size = new System.Drawing.Size(277, 24);
            this.cmbx_sections.TabIndex = 23;
            this.cmbx_sections.SelectedIndexChanged += new System.EventHandler(this.cmbx_sections_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(327, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sections";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_assignedRoom
            // 
            this.lbl_assignedRoom.AutoSize = true;
            this.lbl_assignedRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_assignedRoom.Location = new System.Drawing.Point(327, 57);
            this.lbl_assignedRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_assignedRoom.Name = "lbl_assignedRoom";
            this.lbl_assignedRoom.Size = new System.Drawing.Size(137, 20);
            this.lbl_assignedRoom.TabIndex = 27;
            this.lbl_assignedRoom.Text = "Assigned room: -";
            // 
            // lbl_capacity
            // 
            this.lbl_capacity.AutoSize = true;
            this.lbl_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_capacity.Location = new System.Drawing.Point(327, 94);
            this.lbl_capacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_capacity.Name = "lbl_capacity";
            this.lbl_capacity.Size = new System.Drawing.Size(90, 20);
            this.lbl_capacity.TabIndex = 27;
            this.lbl_capacity.Text = "Capacity: -";
            // 
            // lbl_usersJoined
            // 
            this.lbl_usersJoined.AutoSize = true;
            this.lbl_usersJoined.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_usersJoined.Location = new System.Drawing.Point(327, 132);
            this.lbl_usersJoined.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usersJoined.Name = "lbl_usersJoined";
            this.lbl_usersJoined.Size = new System.Drawing.Size(119, 20);
            this.lbl_usersJoined.TabIndex = 27;
            this.lbl_usersJoined.Text = "Users joined: -";
            // 
            // btn_complete
            // 
            this.btn_complete.Enabled = false;
            this.btn_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_complete.Location = new System.Drawing.Point(530, 396);
            this.btn_complete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(151, 41);
            this.btn_complete.TabIndex = 28;
            this.btn_complete.Text = "Complete";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // btn_assignRoom
            // 
            this.btn_assignRoom.Enabled = false;
            this.btn_assignRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_assignRoom.Location = new System.Drawing.Point(331, 177);
            this.btn_assignRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_assignRoom.Name = "btn_assignRoom";
            this.btn_assignRoom.Size = new System.Drawing.Size(151, 41);
            this.btn_assignRoom.TabIndex = 29;
            this.btn_assignRoom.Text = "Assign Room";
            this.btn_assignRoom.UseVisualStyleBackColor = true;
            this.btn_assignRoom.Click += new System.EventHandler(this.btn_assignRoom_Click);
            // 
            // btn_unassignRoom
            // 
            this.btn_unassignRoom.Enabled = false;
            this.btn_unassignRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_unassignRoom.Location = new System.Drawing.Point(530, 177);
            this.btn_unassignRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_unassignRoom.Name = "btn_unassignRoom";
            this.btn_unassignRoom.Size = new System.Drawing.Size(151, 41);
            this.btn_unassignRoom.TabIndex = 30;
            this.btn_unassignRoom.Text = "Unassign Room";
            this.btn_unassignRoom.UseVisualStyleBackColor = true;
            this.btn_unassignRoom.Click += new System.EventHandler(this.btn_unassignRoom_Click);
            // 
            // OrganizeSectionsStepThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.btn_unassignRoom);
            this.Controls.Add(this.btn_assignRoom);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.lbl_usersJoined);
            this.Controls.Add(this.lbl_capacity);
            this.Controls.Add(this.lbl_assignedRoom);
            this.Controls.Add(this.cmbx_sections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbx_rooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_back);
            this.Name = "OrganizeSectionsStepThree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrganizeSections 3/3 CMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListBox listbx_rooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_sections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_assignedRoom;
        private System.Windows.Forms.Label lbl_capacity;
        private System.Windows.Forms.Label lbl_usersJoined;
        private System.Windows.Forms.Button btn_complete;
        private System.Windows.Forms.Button btn_assignRoom;
        private System.Windows.Forms.Button btn_unassignRoom;
    }
}