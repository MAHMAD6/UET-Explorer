using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace UET_Explorer.Views.UserControls
{
    public partial class uc_cgpaFinder : UserControl
    {
        PictureBox loading;
        Panel notFound;
        private int _itemsPerPage = 8;
        private int _currentPage = 0;
        private List<uc_cgpaStudentTemplate> _allItems;
        private bool _isLoading = false; // Prevent multiple loads

        public uc_cgpaFinder()
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
                _allItems = await Task.Run(() => LoadDataFromExcelFile(filePath));
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
            if (_allItems == null || _currentPage * _itemsPerPage >= _allItems.Count || _isLoading)
            {
                flowLayoutPanel1.Controls.Add(notFound);
                return;
            }

            _isLoading = true; // Prevent multiple triggering while loading

            int startIndex = _currentPage * _itemsPerPage;
            int endIndex = Math.Min(startIndex + _itemsPerPage, _allItems.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                flowLayoutPanel1.Controls.Add(_allItems[i]);
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

        private List<uc_cgpaStudentTemplate> LoadDataFromExcelFile(string filePath)
        {
            List<uc_cgpaStudentTemplate> list = new List<uc_cgpaStudentTemplate>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var workbook = package.Workbook;
                var worksheet = workbook.Worksheets[0];

                string searchString = textBox.Text.Trim();
                int columnNoToCompare = SelectSearchTypeComboBox();

                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    string columnBValue = worksheet.Cells[row, columnNoToCompare].Text;

                    if (!cb_exact.Checked && (columnBValue.ToLower().Contains(searchString.ToLower()) ||
                        (columnNoToCompare == 8 && worksheet.Cells[row, 9].Text.ToLower().Contains(searchString.ToLower()))))
                    {
                        list.Add(new uc_cgpaStudentTemplate(
                            worksheet.Cells[row, 3].Text,  // Name
                            worksheet.Cells[row, 10].Text, // CGPA
                            worksheet.Cells[row, 2].Text,  // Roll No
                            worksheet.Cells[row, 6].Text,   // Gender
                            worksheet.Cells[row, 4].Text, // Father name
                            worksheet.Cells[row, 7].Text, // Email
                            (worksheet.Cells[row, 8].Text + ", " + worksheet.Cells[row, 9].Text), // Contact
                            worksheet.Cells[row, 5].Text // CNIC
                        ));
                    }
                    else if (cb_exact.Checked && (columnBValue.ToLower() == searchString.ToLower() ||
                            (columnNoToCompare == 8 && worksheet.Cells[row, 9].Text.ToLower() == searchString.ToLower())))
                    {
                        list.Add(new uc_cgpaStudentTemplate(
                            worksheet.Cells[row, 3].Text,  // Name
                            worksheet.Cells[row, 10].Text, // CGPA
                            worksheet.Cells[row, 2].Text,  // Roll No
                            worksheet.Cells[row, 6].Text,   // Gender
                            worksheet.Cells[row, 4].Text, // Father name
                            worksheet.Cells[row, 7].Text, // Email
                            (worksheet.Cells[row, 8].Text + ", " + worksheet.Cells[row, 9].Text), // Contact
                            worksheet.Cells[row, 5].Text // CNIC
                        ));
                    }
                }
            }

            return list;
        }

        /*
        Student Name
        Father Name
        Registration
        CNIC
        Contact
        Email
        */


        private int ComboIndexToExcelFileIndex(int index)
        {
            switch (index)
            {
                case 0:
                    return 3;
                case 1:
                    return 4;
                case 2:
                    return 2;
                case 3:
                    return 5;
                case 4:
                    return 8;
                case 5:
                    return 7;
            }
            return 3;
        }

        private int SelectSearchTypeComboBox()
        {
            // Check if we are on the UI thread, if not, invoke the operation on the UI thread
            if (cb.InvokeRequired)
            {
                return (int)cb.Invoke(new Func<int>(() =>
                {
                    return ComboIndexToExcelFileIndex(cb.SelectedIndex);
                }));
            }
            else
            {
                return ComboIndexToExcelFileIndex(cb.SelectedIndex);
            }
        }

        
    }
}
