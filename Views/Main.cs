using UET_Explorer.Views.UserControls;

namespace UET_Explorer
{
        public enum PAGE
        {
        HOME ,
        STUDENT_INFO,
        SNAKE_FINDER,
        NADRA_DATA,
        ABOUT
        }

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
            UserControl uc = menus[(int)page];
            p_container.Controls.Clear();
            p_container.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            

        }

        private void initializeEvents()
        {
            menus = new List<UserControl>
            {
                new uc_home(),
                new uc_cgpaFinder(),
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
