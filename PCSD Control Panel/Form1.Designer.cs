namespace PCSD_Control_Panel_2._0
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label5 = new Label();
            button1 = new Button();
            panelSystem = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            panelTopBar = new Panel();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelSetting = new Panel();
            label15 = new Label();
            numericUpDown1 = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            button6 = new Button();
            button5 = new Button();
            panelUSBDisplay = new Panel();
            button8 = new Button();
            label14 = new Label();
            label13 = new Label();
            button7 = new Button();
            label12 = new Label();
            label11 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelSystem.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelTopBar.SuspendLayout();
            panelSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panelUSBDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(123, 40);
            label5.Margin = new Padding(3, 40, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 43);
            label5.TabIndex = 3;
            label5.Text = "0 °C";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 20, 20);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(9, 45);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(196, 29);
            button1.TabIndex = 0;
            button1.Text = "System";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelSystem
            // 
            panelSystem.BackColor = Color.FromArgb(20, 20, 20);
            panelSystem.Controls.Add(tableLayoutPanel1);
            panelSystem.Location = new Point(208, 45);
            panelSystem.Name = "panelSystem";
            panelSystem.Size = new Size(377, 212);
            panelSystem.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6885242F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.31148F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 159F));
            tableLayoutPanel1.Controls.Add(label8, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(371, 206);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(290, 40);
            label8.Margin = new Padding(3, 40, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 43);
            label8.TabIndex = 5;
            label8.Text = "0 %";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 12F);
            label4.Location = new Point(3, 103);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 2;
            label4.Text = "GPU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 1;
            label3.Text = "CPU";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(290, 143);
            label7.Margin = new Padding(3, 40, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 43);
            label7.TabIndex = 6;
            label7.Text = "0 %";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(123, 143);
            label6.Margin = new Padding(3, 40, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 43);
            label6.TabIndex = 4;
            label6.Text = "0 °C";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelTopBar
            // 
            panelTopBar.BackgroundImageLayout = ImageLayout.None;
            panelTopBar.Controls.Add(label1);
            panelTopBar.Controls.Add(button2);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Padding = new Padding(5);
            panelTopBar.Size = new Size(597, 37);
            panelTopBar.TabIndex = 3;
            panelTopBar.MouseDown += panel2_MouseDown;
            panelTopBar.MouseMove += panel2_MouseMove;
            panelTopBar.MouseUp += panel2_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 5;
            label1.Text = "PCSD Control Panel";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(567, 5);
            button2.Margin = new Padding(10, 10, 30, 10);
            button2.Name = "button2";
            button2.Size = new Size(25, 27);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 20, 20);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(9, 74);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(196, 29);
            button3.TabIndex = 4;
            button3.Text = "USB Display";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(20, 20, 20);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(9, 103);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(196, 29);
            button4.TabIndex = 5;
            button4.Text = "Setting";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panelSetting
            // 
            panelSetting.BackColor = Color.FromArgb(20, 20, 20);
            panelSetting.Controls.Add(label15);
            panelSetting.Controls.Add(numericUpDown1);
            panelSetting.Controls.Add(label10);
            panelSetting.Controls.Add(label9);
            panelSetting.Controls.Add(label2);
            panelSetting.Controls.Add(button6);
            panelSetting.Controls.Add(button5);
            panelSetting.Location = new Point(208, 45);
            panelSetting.Name = "panelSetting";
            panelSetting.Size = new Size(377, 212);
            panelSetting.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(37, 115);
            label15.Name = "label15";
            label15.Size = new Size(148, 19);
            label15.TabIndex = 8;
            label15.Text = "Update speed (ms) :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(64, 64, 64);
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            numericUpDown1.ForeColor = SystemColors.Window;
            numericUpDown1.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Location = new Point(239, 111);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(123, 29);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 78);
            label10.Name = "label10";
            label10.Size = new Size(177, 19);
            label10.TabIndex = 6;
            label10.Text = "Start on system startup :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 37);
            label9.Name = "label9";
            label9.Size = new Size(72, 19);
            label9.TabIndex = 5;
            label9.Text = "Console :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 37);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 4;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(239, 70);
            button6.Name = "button6";
            button6.Size = new Size(123, 35);
            button6.TabIndex = 3;
            button6.Text = "Enable";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(239, 29);
            button5.Name = "button5";
            button5.Size = new Size(123, 35);
            button5.TabIndex = 0;
            button5.Text = "Show";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panelUSBDisplay
            // 
            panelUSBDisplay.BackColor = Color.FromArgb(20, 20, 20);
            panelUSBDisplay.Controls.Add(button8);
            panelUSBDisplay.Controls.Add(label14);
            panelUSBDisplay.Controls.Add(label13);
            panelUSBDisplay.Controls.Add(button7);
            panelUSBDisplay.Controls.Add(label12);
            panelUSBDisplay.Controls.Add(label11);
            panelUSBDisplay.Controls.Add(comboBox2);
            panelUSBDisplay.Controls.Add(comboBox1);
            panelUSBDisplay.Location = new Point(208, 45);
            panelUSBDisplay.Name = "panelUSBDisplay";
            panelUSBDisplay.Size = new Size(377, 212);
            panelUSBDisplay.TabIndex = 1;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(64, 64, 64);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(161, 167);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 7;
            button8.Text = "Run";
            button8.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(169, 120);
            label14.Name = "label14";
            label14.Size = new Size(62, 19);
            label14.TabIndex = 6;
            label14.Text = "inactive";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 120);
            label13.Name = "label13";
            label13.Size = new Size(59, 19);
            label13.TabIndex = 5;
            label13.Text = "Status :";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(64, 64, 64);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(261, 167);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 4;
            button7.Text = "Apply";
            button7.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 76);
            label12.Name = "label12";
            label12.Size = new Size(83, 19);
            label12.TabIndex = 3;
            label12.Text = "Baud rate :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 34);
            label11.Name = "label11";
            label11.Size = new Size(45, 19);
            label11.TabIndex = 2;
            label11.Text = "Port :";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(64, 64, 64);
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.ForeColor = Color.Snow;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(169, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(186, 27);
            comboBox2.Sorted = true;
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(64, 64, 64);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.Snow;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 27);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(597, 269);
            Controls.Add(button4);
            Controls.Add(panelSetting);
            Controls.Add(button3);
            Controls.Add(panelTopBar);
            Controls.Add(panelSystem);
            Controls.Add(panelUSBDisplay);
            Controls.Add(button1);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowIcon = false;
            Text = "Form1";
            Load += Form1_Load;
            panelSystem.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelSetting.ResumeLayout(false);
            panelSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panelUSBDisplay.ResumeLayout(false);
            panelUSBDisplay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panelSystem;
        private Panel panelTopBar;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelSetting;
        private Panel panelUSBDisplay;
        private Button button5;
        private Label label2;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label12;
        private Label label14;
        private Label label13;
        private Button button7;
        private Button button8;
        private Label label15;
        private NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
        public Label label6;
        public Label label7;
        public Label label8;
        public Label label5;
        public Button button6;
    }
}
