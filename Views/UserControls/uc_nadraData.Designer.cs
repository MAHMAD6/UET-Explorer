namespace UET_Explorer.Views.UserControls
{
    partial class uc_nadraData
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
            pb_back = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pb_back
            // 
            pb_back.Cursor = Cursors.Hand;
            pb_back.Image = Properties.Resources.icon_back;
            pb_back.Location = new Point(24, 17);
            pb_back.Name = "pb_back";
            pb_back.Size = new Size(49, 55);
            pb_back.SizeMode = PictureBoxSizeMode.Zoom;
            pb_back.TabIndex = 8;
            pb_back.TabStop = false;
            pb_back.Click += pb_back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.comingsoon;
            pictureBox1.Location = new Point(17, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1057, 556);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // uc_nadraData
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(23, 20, 19);
            Controls.Add(pictureBox1);
            Controls.Add(pb_back);
            DoubleBuffered = true;
            Name = "uc_nadraData";
            Size = new Size(1074, 654);
            ((System.ComponentModel.ISupportInitialize)pb_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb_back;
        private PictureBox pictureBox1;
    }
}
