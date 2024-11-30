using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UET_Explorer.Models;

namespace UET_Explorer.Views.UserControls
{
    public partial class uc_snakeFinder : UserControl
    {
        private List<Student> students;
        private Panel snakeResult;
        public uc_snakeFinder()
        {
            InitializeComponent();
            students = new List<Student>();
            snakeResult = p_snakeResult;
            flowLayoutPanel1.Controls.Clear();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            Form_Home.formHome.SetMenu(PAGE.HOME);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            students.Clear();
            flowLayoutPanel1.Controls.Clear();
            hideResult();
        }

        private bool IsAlreadyAdded(string registration)
        {
            if (students.Count > 0)
            {
                foreach (Student student in students)
                {
                    if (student.RollNumber == registration)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            hideResult();
            string stringSearch = textBox.Text.Trim().ToLower();
            string filePath = "C:\\Users\\cheeeesee\\source\\repos\\UET-Explorer\\UET-Explorer\\Resources\\MainData.xlsx";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found. Please check the file path.");
                return;
            }

            using (var excelPackage = new ExcelPackage(new FileInfo(filePath)))
            {
                var workbook = excelPackage.Workbook;
                var worksheet = workbook.Worksheets[0];
                for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                {
                    if (stringSearch == worksheet.Cells[row, 2].Text.ToLower())
                    {
                        var student = new Student(
                            worksheet.Cells[row, 3].Text,  // Name
                            worksheet.Cells[row, 10].Text, // CGPA
                            worksheet.Cells[row, 2].Text,  // Roll No
                            worksheet.Cells[row, 6].Text,  // Gender
                            worksheet.Cells[row, 4].Text,  // Father Name
                            worksheet.Cells[row, 7].Text,  // Email
                            worksheet.Cells[row, 8].Text + ", " + worksheet.Cells[row, 9].Text, // Contact
                            worksheet.Cells[row, 5].Text   // CNIC
                        );

                        if (!IsAlreadyAdded(student.RollNumber))
                        {
                            students.Add(student);
                            flowLayoutPanel1.Controls.Add(new uc_StudentTemplate(student));
                        }
                        else
                        {
                            MessageBox.Show($"Student with Roll Number {student.RollNumber} is already added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btn_findSnake_Click(object sender, EventArgs e)
        {
            if (students.Count <= 1)
            {
                MessageBox.Show("No snake found (only one student).","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Sort the students by CGPA in descending order, rounding CGPA to 3 decimal places
            var sortedStudents = students.OrderByDescending(s => Math.Round(double.Parse(s.CGPA), 1)).ToList();

            // If there are more than one student, take the top 2
            var topStudents = sortedStudents.Take(2).ToList();

            // Randomly select one of the top 2 students
            Random random = new Random();
            var selectedStudent = topStudents[random.Next(topStudents.Count)];

            // Display the selected student (the "snake")
            l_firstname.Text = selectedStudent.Name;
            float snakeCGPA = float.Parse(selectedStudent.CGPA);
            if(snakeCGPA < 3.1)
            {
                l_snakeType.Text = "Baby snake";
                pb_snake.Image = UET_Explorer.Properties.Resources.icon_snake_1;
            }
            else if(snakeCGPA > 3.1 && snakeCGPA < 3.4)
            {
                l_snakeType.Text = "Sleeping Anaconda";
                pb_snake.Image = UET_Explorer.Properties.Resources.icon_snake_2;
            }
            else if(snakeCGPA > 3.4 && snakeCGPA < 3.7)
            {
                l_snakeType.Text = "Golder Cobra";
                pb_snake.Image = UET_Explorer.Properties.Resources.icon_snake_3;
            }
            else if(snakeCGPA > 3.7)
            {
                l_snakeType.Text = "Deadly F*k*g Conda";
                pb_snake.Image = UET_Explorer.Properties.Resources.icon_snake_4;
            }
            showResult();
            students.Clear();
            flowLayoutPanel1.Controls.Clear();
        }

        private void showResult()
        {
            flowLayoutPanel1.Controls.Clear();
            p_snakeResult.BringToFront();
        }
        private void hideResult()
        {
            p_snakeResult.SendToBack();
        }


        private void l_fatherName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
