namespace UET_Explorer
{
    partial class Form_Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            p_top = new Panel();
            pb_close = new PictureBox();
            panel1 = new Panel();
            p_container = new Panel();
            l_appName = new Label();
            p_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_close).BeginInit();
            SuspendLayout();
            // 
            // p_top
            // 
            p_top.BackColor = Color.FromArgb(23, 20, 19);
            p_top.Controls.Add(l_appName);
            p_top.Controls.Add(pb_close);
            p_top.Controls.Add(panel1);
            p_top.Dock = DockStyle.Top;
            p_top.Location = new Point(0, 0);
            p_top.Name = "p_top";
            p_top.Size = new Size(1074, 53);
            p_top.TabIndex = 0;
            // 
            // pb_close
            // 
            pb_close.Cursor = Cursors.Hand;
            pb_close.Image = (Image)resources.GetObject("pb_close.Image");
            pb_close.Location = new Point(1028, 11);
            pb_close.Name = "pb_close";
            pb_close.Size = new Size(35, 41);
            pb_close.SizeMode = PictureBoxSizeMode.Zoom;
            pb_close.TabIndex = 0;
            pb_close.TabStop = false;
            pb_close.Click += pb_close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(127, 195, 65);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 10);
            panel1.TabIndex = 1;
            // 
            // p_container
            // 
            p_container.Dock = DockStyle.Fill;
            p_container.Location = new Point(0, 53);
            p_container.Name = "p_container";
            p_container.Size = new Size(1074, 654);
            p_container.TabIndex = 1;
            // 
            // l_appName
            // 
            l_appName.AutoSize = true;
            l_appName.Font = new Font("Nexa Heavy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_appName.ForeColor = Color.Silver;
            l_appName.Location = new Point(12, 16);
            l_appName.Name = "l_appName";
            l_appName.Size = new Size(170, 31);
            l_appName.TabIndex = 2;
            l_appName.Text = "UET Explorer";
            // 
            // Form_Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(23, 20, 19);
            ClientSize = new Size(1074, 707);
            Controls.Add(p_container);
            Controls.Add(p_top);
            Font = new Font("Nexa Heavy", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UET Explorer";
            p_top.ResumeLayout(false);
            p_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel p_top;
        private Panel p_container;
        private Panel panel1;
        private PictureBox pb_close;
        private Label l_appName;
    }
}
