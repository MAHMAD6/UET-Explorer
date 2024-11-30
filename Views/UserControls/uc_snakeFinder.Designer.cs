namespace UET_Explorer.Views.UserControls
{
    partial class uc_snakeFinder
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
            textBox = new TextBox();
            btn_add = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            p_snakeResult = new Panel();
            l_snakeType = new Label();
            pb_snake = new PictureBox();
            l_firstname = new Label();
            l_fatherName = new Label();
            btn_findSnake = new Button();
            btn_clear = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_back).BeginInit();
            p_snakeResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_snake).BeginInit();
            SuspendLayout();
            // 
            // pb_back
            // 
            pb_back.Cursor = Cursors.Hand;
            pb_back.Image = Properties.Resources.icon_back;
            pb_back.Location = new Point(37, 21);
            pb_back.Name = "pb_back";
            pb_back.Size = new Size(49, 55);
            pb_back.SizeMode = PictureBoxSizeMode.Zoom;
            pb_back.TabIndex = 11;
            pb_back.TabStop = false;
            pb_back.Click += pb_back_Click;
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.InactiveBorder;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Location = new Point(323, 35);
            textBox.Name = "textBox";
            textBox.Size = new Size(230, 31);
            textBox.TabIndex = 9;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(219, 175, 19);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.FromArgb(23, 20, 19);
            btn_add.Location = new Point(591, 33);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(129, 33);
            btn_add.TabIndex = 8;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(109, 37);
            label1.Name = "label1";
            label1.Size = new Size(198, 31);
            label1.TabIndex = 13;
            label1.Text = "Enter Roll Number:";
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
            flowLayoutPanel1.TabIndex = 15;
            flowLayoutPanel1.WrapContents = false;
            // 
            // p_snakeResult
            // 
            p_snakeResult.Controls.Add(l_snakeType);
            p_snakeResult.Controls.Add(pb_snake);
            p_snakeResult.Controls.Add(l_firstname);
            p_snakeResult.Controls.Add(l_fatherName);
            p_snakeResult.Location = new Point(23, 82);
            p_snakeResult.Name = "p_snakeResult";
            p_snakeResult.Size = new Size(1038, 534);
            p_snakeResult.TabIndex = 0;
            p_snakeResult.Paint += panel1_Paint;
            // 
            // l_snakeType
            // 
            l_snakeType.AutoEllipsis = true;
            l_snakeType.Font = new Font("Freestyle Script", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_snakeType.ForeColor = Color.Silver;
            l_snakeType.Location = new Point(-8, 412);
            l_snakeType.Name = "l_snakeType";
            l_snakeType.Size = new Size(1027, 124);
            l_snakeType.TabIndex = 16;
            l_snakeType.Text = "Rahmat Ali khan Chandio";
            l_snakeType.TextAlign = ContentAlignment.TopCenter;
            // 
            // pb_snake
            // 
            pb_snake.Image = Properties.Resources.icon_snake_1;
            pb_snake.Location = new Point(257, 146);
            pb_snake.Name = "pb_snake";
            pb_snake.Size = new Size(430, 280);
            pb_snake.SizeMode = PictureBoxSizeMode.Zoom;
            pb_snake.TabIndex = 15;
            pb_snake.TabStop = false;
            // 
            // l_firstname
            // 
            l_firstname.AutoEllipsis = true;
            l_firstname.Font = new Font("a_FuturaRoundDemi", 22F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l_firstname.ForeColor = Color.Gainsboro;
            l_firstname.Location = new Point(340, 53);
            l_firstname.Name = "l_firstname";
            l_firstname.Size = new Size(679, 58);
            l_firstname.TabIndex = 14;
            l_firstname.Text = "Muhammad";
            l_firstname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_fatherName
            // 
            l_fatherName.AutoEllipsis = true;
            l_fatherName.AutoSize = true;
            l_fatherName.Font = new Font("Poppins Medium", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_fatherName.ForeColor = Color.DarkGray;
            l_fatherName.Location = new Point(28, 46);
            l_fatherName.Name = "l_fatherName";
            l_fatherName.Size = new Size(320, 78);
            l_fatherName.TabIndex = 13;
            l_fatherName.Text = "The Snake is";
            l_fatherName.Click += l_fatherName_Click;
            // 
            // btn_findSnake
            // 
            btn_findSnake.BackColor = Color.FromArgb(127, 195, 65);
            btn_findSnake.FlatStyle = FlatStyle.Flat;
            btn_findSnake.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_findSnake.ForeColor = Color.FromArgb(23, 20, 19);
            btn_findSnake.Location = new Point(899, 33);
            btn_findSnake.Name = "btn_findSnake";
            btn_findSnake.Size = new Size(129, 33);
            btn_findSnake.TabIndex = 16;
            btn_findSnake.Text = "Find Snake";
            btn_findSnake.UseVisualStyleBackColor = false;
            btn_findSnake.Click += btn_findSnake_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(198, 0, 1);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.FromArgb(23, 20, 19);
            btn_clear.Location = new Point(742, 33);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(129, 33);
            btn_clear.TabIndex = 17;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // uc_snakeFinder
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(23, 20, 19);
            Controls.Add(btn_clear);
            Controls.Add(btn_findSnake);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(pb_back);
            Controls.Add(textBox);
            Controls.Add(btn_add);
            Controls.Add(p_snakeResult);
            DoubleBuffered = true;
            Name = "uc_snakeFinder";
            Size = new Size(1074, 654);
            ((System.ComponentModel.ISupportInitialize)pb_back).EndInit();
            p_snakeResult.ResumeLayout(false);
            p_snakeResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_snake).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_back;
        private TextBox textBox;
        private Button btn_add;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_findSnake;
        private Button btn_clear;
        private Panel p_snakeResult;
        private Label l_fatherName;
        private PictureBox pb_snake;
        private Label l_firstname;
        private Label l_snakeType;
    }
}
