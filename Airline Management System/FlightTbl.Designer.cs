namespace Airline_Management_System
{
    partial class FlightTbl
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTbl));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            label1 = new Label();
            label2 = new Label();
            FcodeTb = new Bunifu.UI.WinForms.BunifuTextBox();
            label3 = new Label();
            label4 = new Label();
            SeatNum = new Bunifu.UI.WinForms.BunifuTextBox();
            label5 = new Label();
            label6 = new Label();
            Fsrc = new ComboBox();
            FDest = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            FDate = new DateTimePicker();
            panel3 = new Panel();
            label10 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(132, 39);
            label1.Name = "label1";
            label1.Size = new Size(372, 34);
            label1.TabIndex = 2;
            label1.Text = "Biman Bangladesh Airlines";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(168, 73);
            label2.Name = "label2";
            label2.Size = new Size(271, 34);
            label2.TabIndex = 3;
            label2.Text = "Record New Flights";
            label2.Click += label2_Click;
            // 
            // FcodeTb
            // 
            FcodeTb.AcceptsReturn = false;
            FcodeTb.AcceptsTab = false;
            FcodeTb.AnimationSpeed = 200;
            FcodeTb.AutoCompleteMode = AutoCompleteMode.None;
            FcodeTb.AutoCompleteSource = AutoCompleteSource.None;
            FcodeTb.AutoSizeHeight = true;
            FcodeTb.BackColor = Color.White;
            FcodeTb.BackgroundImage = (Image)resources.GetObject("FcodeTb.BackgroundImage");
            FcodeTb.BorderColorActive = Color.DodgerBlue;
            FcodeTb.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            FcodeTb.BorderColorHover = Color.FromArgb(105, 181, 255);
            FcodeTb.BorderColorIdle = Color.Silver;
            FcodeTb.BorderRadius = 1;
            FcodeTb.BorderThickness = 1;
            FcodeTb.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            FcodeTb.CharacterCasing = CharacterCasing.Normal;
            FcodeTb.Cursor = Cursors.IBeam;
            FcodeTb.DefaultFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FcodeTb.DefaultText = "";
            FcodeTb.FillColor = Color.White;
            FcodeTb.ForeColor = Color.Red;
            FcodeTb.HideSelection = true;
            FcodeTb.IconLeft = null;
            FcodeTb.IconLeftCursor = Cursors.IBeam;
            FcodeTb.IconPadding = 10;
            FcodeTb.IconRight = null;
            FcodeTb.IconRightCursor = Cursors.IBeam;
            FcodeTb.Location = new Point(153, 214);
            FcodeTb.MaxLength = 32767;
            FcodeTb.MinimumSize = new Size(1, 1);
            FcodeTb.Modified = false;
            FcodeTb.Multiline = false;
            FcodeTb.Name = "FcodeTb";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            FcodeTb.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            FcodeTb.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            FcodeTb.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Red;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            FcodeTb.OnIdleState = stateProperties4;
            FcodeTb.Padding = new Padding(3);
            FcodeTb.PasswordChar = '\0';
            FcodeTb.PlaceholderForeColor = Color.Silver;
            FcodeTb.PlaceholderText = "Enter text";
            FcodeTb.ReadOnly = false;
            FcodeTb.ScrollBars = ScrollBars.None;
            FcodeTb.SelectedText = "";
            FcodeTb.SelectionLength = 0;
            FcodeTb.SelectionStart = 0;
            FcodeTb.ShortcutsEnabled = true;
            FcodeTb.Size = new Size(163, 23);
            FcodeTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            FcodeTb.TabIndex = 8;
            FcodeTb.TextAlign = HorizontalAlignment.Left;
            FcodeTb.TextMarginBottom = 0;
            FcodeTb.TextMarginLeft = 3;
            FcodeTb.TextMarginTop = 1;
            FcodeTb.TextPlaceholder = "Enter text";
            FcodeTb.UseSystemPasswordChar = false;
            FcodeTb.WordWrap = true;
            FcodeTb.TextChanged += bunifuTextBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(13, 214);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 9;
            label3.Text = "Flight Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(12, 434);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 11;
            label4.Text = "Num of Seats";
            // 
            // SeatNum
            // 
            SeatNum.AcceptsReturn = false;
            SeatNum.AcceptsTab = false;
            SeatNum.AnimationSpeed = 200;
            SeatNum.AutoCompleteMode = AutoCompleteMode.None;
            SeatNum.AutoCompleteSource = AutoCompleteSource.None;
            SeatNum.AutoSizeHeight = true;
            SeatNum.BackColor = Color.White;
            SeatNum.BackgroundImage = (Image)resources.GetObject("SeatNum.BackgroundImage");
            SeatNum.BorderColorActive = Color.DodgerBlue;
            SeatNum.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            SeatNum.BorderColorHover = Color.FromArgb(105, 181, 255);
            SeatNum.BorderColorIdle = Color.Silver;
            SeatNum.BorderRadius = 1;
            SeatNum.BorderThickness = 1;
            SeatNum.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            SeatNum.CharacterCasing = CharacterCasing.Normal;
            SeatNum.Cursor = Cursors.IBeam;
            SeatNum.DefaultFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SeatNum.DefaultText = "";
            SeatNum.FillColor = Color.White;
            SeatNum.ForeColor = Color.Red;
            SeatNum.HideSelection = true;
            SeatNum.IconLeft = null;
            SeatNum.IconLeftCursor = Cursors.IBeam;
            SeatNum.IconPadding = 10;
            SeatNum.IconRight = null;
            SeatNum.IconRightCursor = Cursors.IBeam;
            SeatNum.Location = new Point(153, 434);
            SeatNum.MaxLength = 32767;
            SeatNum.MinimumSize = new Size(1, 1);
            SeatNum.Modified = false;
            SeatNum.Multiline = false;
            SeatNum.Name = "SeatNum";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            SeatNum.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            SeatNum.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            SeatNum.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Red;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            SeatNum.OnIdleState = stateProperties8;
            SeatNum.Padding = new Padding(3);
            SeatNum.PasswordChar = '\0';
            SeatNum.PlaceholderForeColor = Color.Silver;
            SeatNum.PlaceholderText = "Enter text";
            SeatNum.ReadOnly = false;
            SeatNum.ScrollBars = ScrollBars.None;
            SeatNum.SelectedText = "";
            SeatNum.SelectionLength = 0;
            SeatNum.SelectionStart = 0;
            SeatNum.ShortcutsEnabled = true;
            SeatNum.Size = new Size(163, 23);
            SeatNum.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            SeatNum.TabIndex = 10;
            SeatNum.TextAlign = HorizontalAlignment.Left;
            SeatNum.TextMarginBottom = 0;
            SeatNum.TextMarginLeft = 3;
            SeatNum.TextMarginTop = 1;
            SeatNum.TextPlaceholder = "Enter text";
            SeatNum.UseSystemPasswordChar = false;
            SeatNum.WordWrap = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(13, 271);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 12;
            label5.Text = "Source";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(13, 333);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 13;
            label6.Text = "Destination";
            // 
            // Fsrc
            // 
            Fsrc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fsrc.ForeColor = Color.Red;
            Fsrc.FormattingEnabled = true;
            Fsrc.Items.AddRange(new object[] { "Dhaka", "Chittagong", "Sylhet", "Delhi", "Dubai", "Mumbai", "Barcelona" });
            Fsrc.Location = new Point(153, 268);
            Fsrc.Name = "Fsrc";
            Fsrc.Size = new Size(163, 31);
            Fsrc.TabIndex = 14;
            // 
            // FDest
            // 
            FDest.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FDest.ForeColor = Color.Red;
            FDest.FormattingEnabled = true;
            FDest.Items.AddRange(new object[] { "Dhaka", "Chittagong", "Sylhet", "Delhi", "Dubai", "Mumbai", "Barcelona" });
            FDest.Location = new Point(153, 330);
            FDest.Name = "FDest";
            FDest.Size = new Size(163, 31);
            FDest.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(239, 478);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 17;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(101, 478);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 16;
            button1.Text = "Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(333, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(13, 388);
            label7.Name = "label7";
            label7.Size = new Size(121, 23);
            label7.TabIndex = 19;
            label7.Text = "TakeofDate";
            // 
            // FDate
            // 
            FDate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FDate.Location = new Point(153, 386);
            FDate.Name = "FDate";
            FDate.Size = new Size(163, 32);
            FDate.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(565, 24);
            panel3.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(537, 0);
            label10.Name = "label10";
            label10.Size = new Size(28, 27);
            label10.TabIndex = 51;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(212, 516);
            button3.Name = "button3";
            button3.Size = new Size(137, 32);
            button3.TabIndex = 44;
            button3.Text = "View Flights";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(369, 478);
            button4.Name = "button4";
            button4.Size = new Size(94, 32);
            button4.TabIndex = 45;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FlightTbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 552);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel3);
            Controls.Add(FDate);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(FDest);
            Controls.Add(Fsrc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(SeatNum);
            Controls.Add(label3);
            Controls.Add(FcodeTb);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlightTbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlightTbl";
            Load += FlightTbl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox FcodeTb;
        private Label label3;
        private Label label4;
        private Bunifu.UI.WinForms.BunifuTextBox SeatNum;
        private Label label5;
        private Label label6;
        private ComboBox Fsrc;
        private ComboBox FDest;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label7;
        private DateTimePicker FDate;
        private Panel panel3;
        private Button button3;
        private Button button4;
        private Label label10;
    }
}