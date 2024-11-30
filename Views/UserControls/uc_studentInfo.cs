using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UET_Explorer.Models;

namespace UET_Explorer.Views.UserControls
{
    public partial class uc_studentInfo : UserControl
    {
        PictureBox loading;
        Panel notFound;
        private int _itemsPerPage = 8;
        private int _currentPage = 0;
        private List<Student> _allStudents; // List of Student objects
        private bool _isLoading = false;    // Prevent multiple loads

        public uc_studentInfo()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            cb.SelectedIndex = 0;
            loading = pb_loading;
            notFound = p_notFound;
            flowLayoutPanel1.Scroll += FlowLayoutPanel1_Scroll;
            flowLayoutPanel1.MouseWheel += FlowLayoutPanel1_MouseWheel; // Detect mouse wheel scroll
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadDataWithLoadingIndicator("C:\\Users\\cheeeesee\\source\\repos\\UET-Explorer\\UET-Explorer\\Resources\\MainData.xlsx");
        }

        private async void LoadDataWithLoadingIndicator(string filePath)
        {
            flowLayoutPanel1.Controls.Add(loading);

            try
            {
                _allStudents = await Task.Run(() => LoadDataFromExcelFile(filePath)); // Load data into Student objects
                _currentPage = 0;
                LoadNextPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                flowLayoutPanel1.Controls.Remove(loading);
            }
        }

        private void LoadNextPage()
        {
            if (_allStudents == null || _currentPage * _itemsPerPage >= _allStudents.Count || _isLoading)
            {
                if (_currentPage == 0) flowLayoutPanel1.Controls.Add(notFound); // Show not found only if no data
                return;
            }

            _isLoading = true; // Prevent multiple triggering while loading

            int startIndex = _currentPage * _itemsPerPage;
            int endIndex = Math.Min(startIndex + _itemsPerPage, _allStudents.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                // Create uc_StudentTemplate only when needed
                var studentTemplate = new uc_StudentTemplate(_allStudents[i]);
                flowLayoutPanel1.Controls.Add(studentTemplate);
            }

            _currentPage++;
            _isLoading = false;
        }

        private void FlowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            int buffer = 10; // Buffer for triggering scroll event

            // Check if the user has scrolled near the bottom
            if (flowLayoutPanel1.VerticalScroll.Value + flowLayoutPanel1.ClientSize.Height >= flowLayoutPanel1.VerticalScroll.Maximum - buffer)
            {
                LoadNextPage(); // Trigger loading of next set of items
            }
        }

        private void FlowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
            // Detect mouse wheel scroll: If scrolling down and near the bottom, load next page
            if (e.Delta < 0 && flowLayoutPanel1.VerticalScroll.Value + flowLayoutPanel1.ClientSize.Height >= flowLayoutPanel1.VerticalScroll.Maximum - 10)
            {
                LoadNextPage();
            }
        }

        private List<Student> LoadDataFromExcelFile(string filePath)
        {
            List<Student> students = new List<Student>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var workbook = package.Workbook;
                var worksheet = workbook.Worksheets[0];

                string searchString = textBox.Text.Trim();
                int columnNoToCompare = SelectSearchTypeComboBox();

                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    string columnValue = worksheet.Cells[row, columnNoToCompare].Text;

                    if (!cb_exact.Checked && (columnValue.ToLower().Contains(searchString.ToLower()) ||
                        (columnNoToCompare == 8 && worksheet.Cells[row, 9].Text.ToLower().Contains(searchString.ToLower()))))
                    {
                        students.Add(CreateStudentFromRow(worksheet, row));
                    }
                    else if (cb_exact.Checked && (columnValue.ToLower() == searchString.ToLower() ||
                             (columnNoToCompare == 8 && worksheet.Cells[row, 9].Text.ToLower() == searchString.ToLower())))
                    {
                        students.Add(CreateStudentFromRow(worksheet, row));
                    }
                }
            }

            return students;
        }

        private Student CreateStudentFromRow(ExcelWorksheet worksheet, int row)
        {
            return new Student(
                worksheet.Cells[row, 3].Text,  // Name
                worksheet.Cells[row, 10].Text, // CGPA
                worksheet.Cells[row, 2].Text,  // Roll No
                worksheet.Cells[row, 6].Text,  // Gender
                worksheet.Cells[row, 4].Text,  // Father Name
                worksheet.Cells[row, 7].Text,  // Email
                worksheet.Cells[row, 8].Text + ", " + worksheet.Cells[row, 9].Text, // Contact
                worksheet.Cells[row, 5].Text   // CNIC
            );
        }

        private int ComboIndexToExcelFileIndex(int index)
        {
            switch (index)
            {
                case 0: return 3; // Name
                case 1: return 4; // Father Name
                case 2: return 2; // Roll Number
                case 3: return 5; // CNIC
                case 4: return 8; // Contact
                case 5: return 7; // Email
                default: return 3;
            }
        }

        private int SelectSearchTypeComboBox()
        {
            if (cb.InvokeRequired)
            {
                return (int)cb.Invoke(new Func<int>(() => ComboIndexToExcelFileIndex(cb.SelectedIndex)));
            }
            else
            {
                return ComboIndexToExcelFileIndex(cb.SelectedIndex);
            }
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            Form_Home.formHome.SetMenu(PAGE.HOME);
        }
    }
}
