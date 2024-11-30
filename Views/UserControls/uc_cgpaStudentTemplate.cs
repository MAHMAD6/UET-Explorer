using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UET_Explorer.Services;

namespace UET_Explorer.Views.UserControls
{
    public partial class uc_cgpaStudentTemplate : UserControl
    {


        public uc_cgpaStudentTemplate(string name, string cGPA, string rollno, string gender, string fatherName, string email, string contact, string cnic)
        {
            InitializeComponent();
            l_firstname.Text = Helper.SeparateFirstWord(ref name);
            l_lastName.Text = name;
            l_rollnumber.Text = rollno;
            l_fatherName.Text = fatherName;
            l_email.Text = email;
            l_contact.Text = contact;
            l_cnic.Text = cnic;
            HandleCgpaUI(cGPA);
            if(gender.ToLower() == "female")
            {
                pb_Gender.Image = UET_Explorer.Properties.Resources.icon_female;
            }
            else
            {
                pb_Gender.Image = UET_Explorer.Properties.Resources.icon_male;
            }
        }

        private void HandleCgpaUI(string cGPA)
        {
            float cgpa = float.Parse(cGPA);
            cGPA += " ";
            if(cgpa > 3.65)
            {
                cGPA += "🔼";
                l_cgpa.ForeColor = ColorTranslator.FromHtml("#2E85D6"); 
            }
            else if(cgpa > 3.3)
            {
                cGPA += "🔼";
                l_cgpa.ForeColor = ColorTranslator.FromHtml("#7FC341"); 

            }
            else if(cgpa > 2.5)
            {

                cGPA += ":)";
                l_cgpa.ForeColor = ColorTranslator.FromHtml("#DBAF13"); 
            }
            else
            { 
                l_cgpa.ForeColor = ColorTranslator.FromHtml("#C60001"); 
                cGPA += "🔽";
            }
            l_cgpa.Text = cGPA;

        }
    }
}
