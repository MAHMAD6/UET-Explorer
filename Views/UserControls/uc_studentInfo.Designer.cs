namespace UET_Explorer.Views.UserControls
{
    partial class uc_studentInfo
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
            btn_search = new Button();
            textBox = new TextBox();
            cb = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            p_notFound = new Panel();
            cb_exact = new CheckBox();
            pb_loading = new PictureBox();
            pb_back = new PictureBox();
            pictureBox1 = new PictureBox();
            p_notFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_loading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(127, 195, 65);
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.FromArgb(23, 20, 19);
            btn_search.Location = new Point(793, 34);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(129, 33);
            btn_search.TabIndex = 1;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.InactiveBorder;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Location = new Point(364, 37);
            textBox.Name = "textBox";
            textBox.Size = new Size(255, 31);
            textBox.TabIndex = 2;
            // 
            // cb
            // 
            cb.BackColor = SystemColors.MenuBar;
            cb.FlatStyle = FlatStyle.Popup;
            cb.FormattingEnabled = true;
            cb.Items.AddRange(new object[] { "Student Name", "Father Name", "Registration", "CNIC", "Contact", "Email" });
            cb.Location = new Point(78, 36);
            cb.Name = "cb";
            cb.Size = new Size(241, 33);
            cb.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 104);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(30, 10, 30, 40);
            flowLayoutPanel1.Size = new Size(1074, 550);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // p_notFound
            // 
            p_notFound.Controls.Add(pictureBox1);
            p_notFound.Location = new Point(33, 89);
            p_notFound.Name = "p_notFound";
            p_notFound.Size = new Size(1009, 521);
            p_notFound.TabIndex = 0;
            // 
            // cb_exact
            // 
            cb_exact.AutoSize = true;
            cb_exact.BackColor = Color.Transparent;
            cb_exact.Font = new Font("Nexa Heavy", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_exact.ForeColor = SystemColors.Control;
            cb_exact.Location = new Point(667, 39);
            cb_exact.Name = "cb_exact";
            cb_exact.Size = new Size(86, 27);
            cb_exact.TabIndex = 5;
            cb_exact.Text = "Exact";
            cb_exact.UseVisualStyleBackColor = false;
            // 
            // pb_loading
            // 
            pb_loading.Image = Properties.Resources.loading;
            pb_loading.Location = new Point(32, 233);
            pb_loading.Margin = new Padding(3, 170, 3, 3);
            pb_loading.Name = "pb_loading";
            pb_loading.Size = new Size(1010, 188);
            pb_loading.SizeMode = PictureBoxSizeMode.Zoom;
            pb_loading.TabIndex = 6;
            pb_loading.TabStop = false;
            // 
            // pb_back
            // 
            pb_back.Cursor = Cursors.Hand;
            pb_back.Image = Properties.Resources.icon_back;
            pb_back.Location = new Point(13, 25);
            pb_back.Name = "pb_back";
            pb_back.Size = new Size(49, 55);
            pb_back.SizeMode = PictureBoxSizeMode.Zoom;
            pb_back.TabIndex = 7;
            pb_back.TabStop = false;
            pb_back.Click += pb_back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.not_found;
            pictureBox1.Location = new Point(303, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // uc_studentInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(23, 20, 19);
            Controls.Add(pb_back);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pb_loading);
            Controls.Add(cb_exact);
            Controls.Add(cb);
            Controls.Add(textBox);
            Controls.Add(btn_search);
            Controls.Add(p_notFound);
            Name = "uc_studentInfo";
            Size = new Size(1074, 654);
            p_notFound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_loading).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_search;
        private TextBox textBox;
        private ComboBox cb;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox cb_exact;
        private PictureBox pb_loading;
        private Panel p_notFound;
        private PictureBox pb_back;
        private PictureBox pictureBox1;
    }
}
