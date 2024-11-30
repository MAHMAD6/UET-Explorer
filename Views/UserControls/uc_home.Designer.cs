namespace UET_Explorer.Views.UserControls
{
    partial class uc_home
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
            p_StudentInfo = new Panel();
            pb_fire = new PictureBox();
            l_hot = new Label();
            l_info = new Label();
            l_student = new Label();
            pb_StudentInfo = new PictureBox();
            p_snakeFinder = new Panel();
            l__finder = new Label();
            l__snake = new Label();
            pb__snakeFinder = new PictureBox();
            p_NadraData = new Panel();
            l_cnic = new Label();
            l_data = new Label();
            pb__NadraData = new PictureBox();
            p_about = new Panel();
            l_about = new Label();
            l_us = new Label();
            pb_about = new PictureBox();
            l_appName = new Label();
            p_StudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_fire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_StudentInfo).BeginInit();
            p_snakeFinder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb__snakeFinder).BeginInit();
            p_NadraData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb__NadraData).BeginInit();
            p_about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_about).BeginInit();
            SuspendLayout();
            // 
            // p_StudentInfo
            // 
            p_StudentInfo.BackColor = Color.FromArgb(28, 25, 24);
            p_StudentInfo.Controls.Add(pb_fire);
            p_StudentInfo.Controls.Add(l_hot);
            p_StudentInfo.Controls.Add(l_info);
            p_StudentInfo.Controls.Add(l_student);
            p_StudentInfo.Controls.Add(pb_StudentInfo);
            p_StudentInfo.Cursor = Cursors.Hand;
            p_StudentInfo.Location = new Point(174, 66);
            p_StudentInfo.Name = "p_StudentInfo";
            p_StudentInfo.Size = new Size(313, 227);
            p_StudentInfo.TabIndex = 0;
            p_StudentInfo.Click += P_studentInfo_Click;
            // 
            // pb_fire
            // 
            pb_fire.Image = Properties.Resources.icon_fire;
            pb_fire.Location = new Point(261, 11);
            pb_fire.Name = "pb_fire";
            pb_fire.Size = new Size(49, 48);
            pb_fire.SizeMode = PictureBoxSizeMode.Zoom;
            pb_fire.TabIndex = 5;
            pb_fire.TabStop = false;
            pb_fire.Click += P_studentInfo_Click;
            // 
            // l_hot
            // 
            l_hot.AutoSize = true;
            l_hot.Font = new Font("Freestyle Script", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_hot.ForeColor = Color.Silver;
            l_hot.Location = new Point(262, 51);
            l_hot.Name = "l_hot";
            l_hot.Size = new Size(42, 37);
            l_hot.TabIndex = 6;
            l_hot.Text = "hot";
            l_hot.Click += P_studentInfo_Click;
            // 
            // l_info
            // 
            l_info.AutoSize = true;
            l_info.Font = new Font("Freestyle Script", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_info.ForeColor = Color.Silver;
            l_info.Location = new Point(139, 165);
            l_info.Name = "l_info";
            l_info.Size = new Size(44, 37);
            l_info.TabIndex = 4;
            l_info.Text = "info";
            l_info.Click += P_studentInfo_Click;
            // 
            // l_student
            // 
            l_student.AutoSize = true;
            l_student.Font = new Font("a_FuturaRoundDemi", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l_student.ForeColor = Color.Silver;
            l_student.Location = new Point(87, 133);
            l_student.Name = "l_student";
            l_student.Size = new Size(148, 41);
            l_student.TabIndex = 3;
            l_student.Text = "Student";
            l_student.Click += P_studentInfo_Click;
            // 
            // pb_StudentInfo
            // 
            pb_StudentInfo.Image = Properties.Resources.icon_search1;
            pb_StudentInfo.Location = new Point(61, 11);
            pb_StudentInfo.Name = "pb_StudentInfo";
            pb_StudentInfo.Size = new Size(184, 124);
            pb_StudentInfo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_StudentInfo.TabIndex = 0;
            pb_StudentInfo.TabStop = false;
            pb_StudentInfo.Click += P_studentInfo_Click;
            // 
            // p_snakeFinder
            // 
            p_snakeFinder.BackColor = Color.FromArgb(28, 25, 24);
            p_snakeFinder.Controls.Add(l__finder);
            p_snakeFinder.Controls.Add(l__snake);
            p_snakeFinder.Controls.Add(pb__snakeFinder);
            p_snakeFinder.Cursor = Cursors.Hand;
            p_snakeFinder.Location = new Point(561, 66);
            p_snakeFinder.Name = "p_snakeFinder";
            p_snakeFinder.Size = new Size(313, 227);
            p_snakeFinder.TabIndex = 1;
            p_snakeFinder.Click += p_snakeFinder_Click;
            // 
            // l__finder
            // 
            l__finder.AutoSize = true;
            l__finder.Font = new Font("Freestyle Script", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l__finder.ForeColor = Color.Silver;
            l__finder.Location = new Point(117, 165);
            l__finder.Name = "l__finder";
            l__finder.Size = new Size(68, 37);
            l__finder.TabIndex = 6;
            l__finder.Text = "Finder";
            l__finder.Click += p_snakeFinder_Click;
            // 
            // l__snake
            // 
            l__snake.AutoSize = true;
            l__snake.Font = new Font("a_FuturaRoundDemi", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l__snake.ForeColor = Color.Silver;
            l__snake.Location = new Point(90, 133);
            l__snake.Name = "l__snake";
            l__snake.Size = new Size(121, 41);
            l__snake.TabIndex = 4;
            l__snake.Text = "Snake";
            l__snake.Click += p_snakeFinder_Click;
            // 
            // pb__snakeFinder
            // 
            pb__snakeFinder.Image = Properties.Resources.icon_snake;
            pb__snakeFinder.Location = new Point(57, 11);
            pb__snakeFinder.Name = "pb__snakeFinder";
            pb__snakeFinder.Size = new Size(184, 124);
            pb__snakeFinder.SizeMode = PictureBoxSizeMode.Zoom;
            pb__snakeFinder.TabIndex = 1;
            pb__snakeFinder.TabStop = false;
            pb__snakeFinder.Click += p_snakeFinder_Click;
            // 
            // p_NadraData
            // 
            p_NadraData.BackColor = Color.FromArgb(28, 25, 24);
            p_NadraData.Controls.Add(l_cnic);
            p_NadraData.Controls.Add(l_data);
            p_NadraData.Controls.Add(pb__NadraData);
            p_NadraData.Cursor = Cursors.Hand;
            p_NadraData.Location = new Point(174, 350);
            p_NadraData.Name = "p_NadraData";
            p_NadraData.Size = new Size(313, 227);
            p_NadraData.TabIndex = 2;
            p_NadraData.Click += p_NadraData_Click;
            // 
            // l_cnic
            // 
            l_cnic.AutoSize = true;
            l_cnic.Font = new Font("a_FuturaRoundDemi", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l_cnic.ForeColor = Color.Silver;
            l_cnic.Location = new Point(84, 148);
            l_cnic.Name = "l_cnic";
            l_cnic.Size = new Size(140, 41);
            l_cnic.TabIndex = 8;
            l_cnic.Text = "NADRA";
            l_cnic.Click += p_NadraData_Click;
            // 
            // l_data
            // 
            l_data.AutoSize = true;
            l_data.Font = new Font("Freestyle Script", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_data.ForeColor = Color.Silver;
            l_data.Location = new Point(125, 184);
            l_data.Name = "l_data";
            l_data.Size = new Size(58, 37);
            l_data.TabIndex = 9;
            l_data.Text = "Data";
            l_data.Click += p_NadraData_Click;
            // 
            // pb__NadraData
            // 
            pb__NadraData.Image = Properties.Resources.icon_card;
            pb__NadraData.Location = new Point(61, 18);
            pb__NadraData.Name = "pb__NadraData";
            pb__NadraData.Size = new Size(184, 124);
            pb__NadraData.SizeMode = PictureBoxSizeMode.Zoom;
            pb__NadraData.TabIndex = 7;
            pb__NadraData.TabStop = false;
            pb__NadraData.Click += p_NadraData_Click;
            // 
            // p_about
            // 
            p_about.BackColor = Color.FromArgb(28, 25, 24);
            p_about.Controls.Add(l_about);
            p_about.Controls.Add(l_us);
            p_about.Controls.Add(pb_about);
            p_about.Cursor = Cursors.Hand;
            p_about.Location = new Point(561, 350);
            p_about.Name = "p_about";
            p_about.Size = new Size(313, 227);
            p_about.TabIndex = 3;
            p_about.Click += p_about_Click;
            // 
            // l_about
            // 
            l_about.AutoSize = true;
            l_about.Font = new Font("a_FuturaRoundDemi", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l_about.ForeColor = Color.Silver;
            l_about.Location = new Point(97, 147);
            l_about.Name = "l_about";
            l_about.Size = new Size(120, 41);
            l_about.TabIndex = 9;
            l_about.Text = "About";
            l_about.Click += p_about_Click;
            // 
            // l_us
            // 
            l_us.AutoSize = true;
            l_us.Font = new Font("Freestyle Script", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_us.ForeColor = Color.Silver;
            l_us.Location = new Point(143, 172);
            l_us.Name = "l_us";
            l_us.Size = new Size(33, 37);
            l_us.TabIndex = 10;
            l_us.Text = "us";
            l_us.Click += p_about_Click;
            // 
            // pb_about
            // 
            pb_about.Image = Properties.Resources.icon_about;
            pb_about.Location = new Point(64, 26);
            pb_about.Name = "pb_about";
            pb_about.Size = new Size(184, 124);
            pb_about.SizeMode = PictureBoxSizeMode.Zoom;
            pb_about.TabIndex = 8;
            pb_about.TabStop = false;
            pb_about.Click += p_about_Click;
            // 
            // l_appName
            // 
            l_appName.AutoSize = true;
            l_appName.Font = new Font("Nexa Heavy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_appName.ForeColor = Color.Silver;
            l_appName.Location = new Point(475, 12);
            l_appName.Name = "l_appName";
            l_appName.Size = new Size(89, 31);
            l_appName.TabIndex = 10;
            l_appName.Text = "MENU";
            // 
            // uc_home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(23, 20, 19);
            Controls.Add(l_appName);
            Controls.Add(p_about);
            Controls.Add(p_snakeFinder);
            Controls.Add(p_NadraData);
            Controls.Add(p_StudentInfo);
            Name = "uc_home";
            Size = new Size(1074, 654);
            p_StudentInfo.ResumeLayout(false);
            p_StudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_fire).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_StudentInfo).EndInit();
            p_snakeFinder.ResumeLayout(false);
            p_snakeFinder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb__snakeFinder).EndInit();
            p_NadraData.ResumeLayout(false);
            p_NadraData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb__NadraData).EndInit();
            p_about.ResumeLayout(false);
            p_about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_about).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel p_StudentInfo;
        private Panel p_snakeFinder;
        private Panel p_NadraData;
        private Panel p_about;
        private PictureBox pb_StudentInfo;
        private Label l_info;
        private Label l_student;
        private PictureBox pb_fire;
        private Label l__finder;
        private Label l__snake;
        private PictureBox pb__snakeFinder;
        private Label l_hot;
        private Label l_cnic;
        private Label l_data;
        private PictureBox pb__NadraData;
        private PictureBox pb_about;
        private Label l_about;
        private Label l_us;
        private Label l_appName;
    }
}
