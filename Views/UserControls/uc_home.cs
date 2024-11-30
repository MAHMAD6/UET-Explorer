using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UET_Explorer.Views.UserControls
{
    public partial class uc_home : UserControl
    {

        public uc_home()
        {
            InitializeComponent();
        }

        

        private void P_studentInfo_Click(object? sender, EventArgs e)
        {
            Form_Home.formHome.SetMenu(PAGE.STUDENT_INFO);
        }

        private void p_snakeFinder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yes");

        }

        private void p_NadraData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yes");

        }

        private void p_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yes");

        }
    }
}
