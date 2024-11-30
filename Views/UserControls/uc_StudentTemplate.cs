using System;
using System.Drawing;
using System.Windows.Forms;
using UET_Explorer.Models;
using UET_Explorer.Services;

namespace UET_Explorer.Views.UserControls
{
    public partial class uc_StudentTemplate : UserControl
    {
        // Constructor that accepts a Student object
        public uc_StudentTemplate(Student student)
        {
            InitializeComponent();
            InitializeUI(student);
        }

        // Initializes the UI elements based on the Student object
        private void InitializeUI(Student student)
        {
            // Separate and display first and last name
            string lastName = student.Name;
            string firstName = Helper.SeparateFirstWord(ref lastName);
            l_firstname.Text = firstName;
            l_lastName.Text = lastName;

            // Set other properties
            l_rollnumber.Text = student.RollNumber;
            l_fatherName.Text = student.FatherName;
            l_email.Text = student.Email;
            l_contact.Text = student.Contact;
            l_cnic.Text = student.CNIC;

            // Handle CGPA and Gender UI
            HandleCgpaUI(student.CGPA);
            HandleGenderUI(student.Gender);
        }

        // Handles the display of CGPA with color and icons
        private void HandleCgpaUI(string cGPA)
        {
            if (float.TryParse(cGPA, out float cgpa))
            {
                cGPA += " "; // Start with CGPA value
                if (cgpa > 3.65)
                {
                    cGPA += "🔼";
                    l_cgpa.ForeColor = ColorTranslator.FromHtml("#2E85D6");
                }
                else if (cgpa > 3.3)
                {
                    cGPA += "🔼";
                    l_cgpa.ForeColor = ColorTranslator.FromHtml("#7FC341");
                }
                else if (cgpa > 2.5)
                {
                    cGPA += ":)";
                    l_cgpa.ForeColor = ColorTranslator.FromHtml("#DBAF13");
                }
                else
                {
                    cGPA += "🔽";
                    l_cgpa.ForeColor = ColorTranslator.FromHtml("#C60001");
                }

                l_cgpa.Text = cGPA;
            }
            else
            {
                l_cgpa.Text = "N/A"; // Handle invalid CGPA values
                l_cgpa.ForeColor = Color.Gray;
            }
        }

        // Handles the gender icon
        private void HandleGenderUI(string gender)
        {
            if (gender.ToLower() == "female")
            {
                pb_Gender.Image = UET_Explorer.Properties.Resources.icon_female;
            }
            else
            {
                pb_Gender.Image = UET_Explorer.Properties.Resources.icon_male;
            }
        }
    }
}
