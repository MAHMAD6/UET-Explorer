namespace UET_Explorer.Views.UserControls
{
    partial class uc_cgpaStudentTemplate
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
            panel1 = new Panel();
            l_cnic = new Label();
            l_contact = new Label();
            label4 = new Label();
            label2 = new Label();
            l_email = new Label();
            label3 = new Label();
            l_fatherName = new Label();
            label1 = new Label();
            panel2 = new Panel();
            l_cgpa = new Label();
            l_rollnumber = new Label();
            l_firstname = new Label();
            l_lastName = new Label();
            pb_Gender = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Gender).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 25, 24);
            panel1.Controls.Add(l_cnic);
            panel1.Controls.Add(l_contact);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(l_email);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(l_fatherName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(l_cgpa);
            panel1.Controls.Add(l_rollnumber);
            panel1.Controls.Add(l_firstname);
            panel1.Controls.Add(l_lastName);
            panel1.Controls.Add(pb_Gender);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 243);
            panel1.TabIndex = 1;
            // 
            // l_cnic
            // 
            l_cnic.AutoEllipsis = true;
            l_cnic.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_cnic.ForeColor = Color.Silver;
            l_cnic.Location = new Point(660, 148);
            l_cnic.Name = "l_cnic";
            l_cnic.Size = new Size(332, 31);
            l_cnic.TabIndex = 18;
            l_cnic.Text = "123456890123";
            // 
            // l_contact
            // 
            l_contact.AutoEllipsis = true;
            l_contact.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_contact.ForeColor = Color.Silver;
            l_contact.Location = new Point(660, 111);
            l_contact.Name = "l_contact";
            l_contact.Size = new Size(332, 31);
            l_contact.TabIndex = 17;
            l_contact.Text = "03123456789,  03123456789";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(507, 148);
            label4.Name = "label4";
            label4.Size = new Size(69, 31);
            label4.TabIndex = 16;
            label4.Text = "CNIC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(507, 111);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 15;
            label2.Text = "Contact:";
            // 
            // l_email
            // 
            l_email.AutoEllipsis = true;
            l_email.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_email.ForeColor = Color.Silver;
            l_email.Location = new Point(660, 66);
            l_email.Name = "l_email";
            l_email.Size = new Size(332, 31);
            l_email.TabIndex = 14;
            l_email.Text = "hello@gmail.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(507, 73);
            label3.Name = "label3";
            label3.Size = new Size(74, 31);
            label3.TabIndex = 13;
            label3.Text = "Email:";
            // 
            // l_fatherName
            // 
            l_fatherName.AutoEllipsis = true;
            l_fatherName.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_fatherName.ForeColor = Color.Silver;
            l_fatherName.Location = new Point(660, 30);
            l_fatherName.Name = "l_fatherName";
            l_fatherName.Size = new Size(332, 31);
            l_fatherName.TabIndex = 12;
            l_fatherName.Text = "Muhammad Ali";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(507, 33);
            label1.Name = "label1";
            label1.Size = new Size(147, 31);
            label1.TabIndex = 11;
            label1.Text = "Father name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.ForeColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(489, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 180);
            panel2.TabIndex = 10;
            // 
            // l_cgpa
            // 
            l_cgpa.AutoEllipsis = true;
            l_cgpa.Font = new Font("Poppins", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_cgpa.ForeColor = Color.Silver;
            l_cgpa.Location = new Point(199, 103);
            l_cgpa.Name = "l_cgpa";
            l_cgpa.Size = new Size(308, 93);
            l_cgpa.TabIndex = 9;
            l_cgpa.Text = "3.058 *";
            l_cgpa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_rollnumber
            // 
            l_rollnumber.AutoEllipsis = true;
            l_rollnumber.Font = new Font("Quicksand Bold", 9.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_rollnumber.ForeColor = Color.FromArgb(103, 9, 240);
            l_rollnumber.Location = new Point(0, 199);
            l_rollnumber.Name = "l_rollnumber";
            l_rollnumber.Size = new Size(1007, 41);
            l_rollnumber.TabIndex = 7;
            l_rollnumber.Text = "CD/2022-CS-187";
            l_rollnumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_firstname
            // 
            l_firstname.AutoEllipsis = true;
            l_firstname.Font = new Font("a_FuturaRoundDemi", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l_firstname.ForeColor = Color.Silver;
            l_firstname.Location = new Point(199, 30);
            l_firstname.Name = "l_firstname";
            l_firstname.Size = new Size(307, 41);
            l_firstname.TabIndex = 4;
            l_firstname.Text = "Muhammad";
            l_firstname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_lastName
            // 
            l_lastName.AutoEllipsis = true;
            l_lastName.Font = new Font("Freestyle Script", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_lastName.ForeColor = Color.Silver;
            l_lastName.Location = new Point(197, 66);
            l_lastName.Name = "l_lastName";
            l_lastName.Size = new Size(309, 37);
            l_lastName.TabIndex = 6;
            l_lastName.Text = "Rahmat Ali khan Chandio";
            l_lastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pb_Gender
            // 
            pb_Gender.Image = Properties.Resources.icon_female;
            pb_Gender.Location = new Point(7, 21);
            pb_Gender.Name = "pb_Gender";
            pb_Gender.Size = new Size(184, 175);
            pb_Gender.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Gender.TabIndex = 5;
            pb_Gender.TabStop = false;
            // 
            // uc_cgpaStudentTemplate
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(0, 3, 3, 20);
            Name = "uc_cgpaStudentTemplate";
            Size = new Size(1010, 243);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Gender).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label l_cgpa;
        private Label l_rollnumber;
        private Label l_firstname;
        private Label l_lastName;
        private PictureBox pb_Gender;
        private Panel panel2;
        private Label label2;
        private Label l_email;
        private Label label3;
        private Label l_fatherName;
        private Label label1;
        private Label l_cnic;
        private Label l_contact;
        private Label label4;
    }
}
