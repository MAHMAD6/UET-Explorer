using UET_Explorer.Models;
using UET_Explorer.Views.UserControls;

namespace UET_Explorer
{


    public partial class Form_Home : Form
    {
        public static Form_Home formHome;
        private List<UserControl> menus;

        public Form_Home()
        {
            InitializeComponent();
            formHome = this;
            initializeEvents();
            SetMenu(PAGE.HOME);
        }


        public void SetMenu(PAGE page)
        {
            UserControl? uc = null;
            switch (page)
            {
                case PAGE.HOME:
                    uc = new uc_home();
                    break;
                case PAGE.STUDENT_INFO:
                    uc = new uc_studentInfo();
                    break;
                case PAGE.SNAKE_FINDER:  
                    uc = new uc_snakeFinder();  
                    break;
                case PAGE.NADRA_DATA:
                    uc = new uc_nadraData();  
                    break;
                case PAGE.ABOUT:
                    uc = new uc_about();  
                    break;
            }

            p_container.Controls.Clear();  // Clear existing controls
            p_container.Controls.Add(uc);  // Add new UserControl to the container
            uc.Dock = DockStyle.Fill;  // Set UserControl to fill the container
            uc.BringToFront();  // Ensure the new UserControl is at the front
        }


        private void initializeEvents()
        {
            menus = new List<UserControl>
            {
                new uc_home(),
                new uc_studentInfo(),
                new uc_snakeFinder(),
                new uc_nadraData(),
                new uc_about()
            };

        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
