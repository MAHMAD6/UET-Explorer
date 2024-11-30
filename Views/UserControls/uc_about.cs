using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UET_Explorer.Models;

namespace UET_Explorer.Views.UserControls
{
    public partial class uc_about : UserControl
    {
        public uc_about()
        {
            InitializeComponent();
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            Form_Home.formHome.SetMenu(PAGE.HOME);
        }


    }
}
