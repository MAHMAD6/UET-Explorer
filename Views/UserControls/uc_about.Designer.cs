namespace UET_Explorer.Views.UserControls
{
    partial class uc_about
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
            l_appName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_back).BeginInit();
            SuspendLayout();
            // 
            // pb_back
            // 
            pb_back.Cursor = Cursors.Hand;
            pb_back.Image = Properties.Resources.icon_back;
            pb_back.Location = new Point(16, 14);
            pb_back.Name = "pb_back";
            pb_back.Size = new Size(49, 55);
            pb_back.SizeMode = PictureBoxSizeMode.Zoom;
            pb_back.TabIndex = 8;
            pb_back.TabStop = false;
            pb_back.Click += pb_back_Click;
            // 
            // l_appName
            // 
            l_appName.AutoSize = true;
            l_appName.Font = new Font("Nexa Heavy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_appName.ForeColor = Color.Silver;
            l_appName.Location = new Point(355, 304);
            l_appName.Name = "l_appName";
            l_appName.Size = new Size(323, 31);
            l_appName.TabIndex = 9;
            l_appName.Text = "Share with your Friends  :)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nexa Heavy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(409, 604);
            label1.Name = "label1";
            label1.Size = new Size(252, 31);
            label1.TabIndex = 10;
            label1.Text = "CS Department UET";
            // 
            // uc_about
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(23, 20, 19);
            Controls.Add(label1);
            Controls.Add(l_appName);
            Controls.Add(pb_back);
            DoubleBuffered = true;
            Name = "uc_about";
            Size = new Size(1074, 654);
            ((System.ComponentModel.ISupportInitialize)pb_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_back;
        private Label l_appName;
        private Label label1;
    }
}
