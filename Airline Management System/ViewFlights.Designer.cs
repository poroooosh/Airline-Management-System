namespace Airline_Management_System
{
    partial class ViewFlights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFlights));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            FDate = new DateTimePicker();
            label7 = new Label();
            DstCb = new ComboBox();
            SrcCb = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Seatnum = new Bunifu.UI.WinForms.BunifuTextBox();
            label3 = new Label();
            FcodeTb = new Bunifu.UI.WinForms.BunifuTextBox();
            FlightDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)FlightDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(279, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(326, 34);
            label2.TabIndex = 5;
            label2.Text = "View Scheduled Flights";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(270, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(360, 34);
            label1.TabIndex = 4;
            label1.Text = "Biman Bangladesh Airline";
            // 
            // FDate
            // 
            FDate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FDate.Location = new Point(224, 238);
            FDate.Margin = new Padding(4, 3, 4, 3);
            FDate.Name = "FDate";
            FDate.Size = new Size(242, 32);
            FDate.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(18, 244);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 23);
            label7.TabIndex = 29;
            label7.Text = "TakeofDate";
            // 
            // DstCb
            // 
            DstCb.Font = new Font("Century Gothic", 12F);
            DstCb.ForeColor = Color.Red;
            DstCb.FormattingEnabled = true;
            DstCb.Items.AddRange(new object[] { "Dhaka", "Chittagong", "Sylhet", "Delhi", "Dubai", "Mumbai", "Barcelona" });
            DstCb.Location = new Point(617, 236);
            DstCb.Margin = new Padding(4, 3, 4, 3);
            DstCb.Name = "DstCb";
            DstCb.Size = new Size(242, 31);
            DstCb.TabIndex = 28;
            // 
            // SrcCb
            // 
            SrcCb.Font = new Font("Century Gothic", 12F);
            SrcCb.ForeColor = Color.Red;
            SrcCb.FormattingEnabled = true;
            SrcCb.Items.AddRange(new object[] { "Dhaka", "Chittagong", "Sylhet", "Delhi", "Dubai", "Mumbai", "Barcelona" });
            SrcCb.Location = new Point(617, 173);
            SrcCb.Margin = new Padding(4, 3, 4, 3);
            SrcCb.Name = "SrcCb";
            SrcCb.Size = new Size(242, 31);
            SrcCb.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(477, 244);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 26;
            label6.Text = "Destination";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(477, 176);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 25;
            label5.Text = "Source";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(247, 304);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 24;
            label4.Text = "Num of Seats";
            // 
            // Seatnum
            // 
            Seatnum.AcceptsReturn = false;
            Seatnum.AcceptsTab = false;
            Seatnum.AnimationSpeed = 200;
            Seatnum.AutoCompleteMode = AutoCompleteMode.None;
            Seatnum.AutoCompleteSource = AutoCompleteSource.None;
            Seatnum.AutoSizeHeight = true;
            Seatnum.BackColor = Color.White;
            Seatnum.BackgroundImage = (Image)resources.GetObject("Seatnum.BackgroundImage");
            Seatnum.BorderColorActive = Color.DodgerBlue;
            Seatnum.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            Seatnum.BorderColorHover = Color.FromArgb(105, 181, 255);
            Seatnum.BorderColorIdle = Color.Silver;
            Seatnum.BorderRadius = 1;
            Seatnum.BorderThickness = 1;
            Seatnum.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            Seatnum.CharacterCasing = CharacterCasing.Normal;
            Seatnum.Cursor = Cursors.IBeam;
            Seatnum.DefaultFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Seatnum.DefaultText = "";
            Seatnum.FillColor = Color.White;
            Seatnum.ForeColor = Color.Red;
            Seatnum.HideSelection = true;
            Seatnum.IconLeft = null;
            Seatnum.IconLeftCursor = Cursors.IBeam;
            Seatnum.IconPadding = 10;
            Seatnum.IconRight = null;
            Seatnum.IconRightCursor = Cursors.IBeam;
            Seatnum.Location = new Point(405, 295);
            Seatnum.Margin = new Padding(4, 3, 4, 3);
            Seatnum.MaxLength = 32767;
            Seatnum.MinimumSize = new Size(2, 1);
            Seatnum.Modified = false;
            Seatnum.Multiline = false;
            Seatnum.Name = "Seatnum";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            Seatnum.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            Seatnum.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            Seatnum.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Red;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            Seatnum.OnIdleState = stateProperties4;
            Seatnum.Padding = new Padding(4, 3, 4, 3);
            Seatnum.PasswordChar = '\0';
            Seatnum.PlaceholderForeColor = Color.Silver;
            Seatnum.PlaceholderText = "Enter text";
            Seatnum.ReadOnly = false;
            Seatnum.ScrollBars = ScrollBars.None;
            Seatnum.SelectedText = "";
            Seatnum.SelectionLength = 0;
            Seatnum.SelectionStart = 0;
            Seatnum.ShortcutsEnabled = true;
            Seatnum.Size = new Size(200, 41);
            Seatnum.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            Seatnum.TabIndex = 23;
            Seatnum.TextAlign = HorizontalAlignment.Left;
            Seatnum.TextMarginBottom = 0;
            Seatnum.TextMarginLeft = 3;
            Seatnum.TextMarginTop = 1;
            Seatnum.TextPlaceholder = "Enter text";
            Seatnum.UseSystemPasswordChar = false;
            Seatnum.WordWrap = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(18, 176);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 22;
            label3.Text = "Flight Code";
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
            FcodeTb.Location = new Point(224, 176);
            FcodeTb.Margin = new Padding(4, 3, 4, 3);
            FcodeTb.MaxLength = 32767;
            FcodeTb.MinimumSize = new Size(2, 1);
            FcodeTb.Modified = false;
            FcodeTb.Multiline = false;
            FcodeTb.Name = "FcodeTb";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            FcodeTb.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            FcodeTb.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            FcodeTb.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Red;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            FcodeTb.OnIdleState = stateProperties8;
            FcodeTb.Padding = new Padding(4, 3, 4, 3);
            FcodeTb.PasswordChar = '\0';
            FcodeTb.PlaceholderForeColor = Color.Silver;
            FcodeTb.PlaceholderText = "Enter text";
            FcodeTb.ReadOnly = false;
            FcodeTb.ScrollBars = ScrollBars.None;
            FcodeTb.SelectedText = "";
            FcodeTb.SelectionLength = 0;
            FcodeTb.SelectionStart = 0;
            FcodeTb.ShortcutsEnabled = true;
            FcodeTb.Size = new Size(244, 41);
            FcodeTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            FcodeTb.TabIndex = 21;
            FcodeTb.TextAlign = HorizontalAlignment.Left;
            FcodeTb.TextMarginBottom = 0;
            FcodeTb.TextMarginLeft = 3;
            FcodeTb.TextMarginTop = 1;
            FcodeTb.TextPlaceholder = "Enter text";
            FcodeTb.UseSystemPasswordChar = false;
            FcodeTb.WordWrap = true;
            // 
            // FlightDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            FlightDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            FlightDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            FlightDGV.ColumnHeadersHeight = 4;
            FlightDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            FlightDGV.DefaultCellStyle = dataGridViewCellStyle3;
            FlightDGV.GridColor = Color.FromArgb(231, 229, 255);
            FlightDGV.Location = new Point(34, 410);
            FlightDGV.Margin = new Padding(4, 3, 4, 3);
            FlightDGV.Name = "FlightDGV";
            FlightDGV.RowHeadersVisible = false;
            FlightDGV.RowHeadersWidth = 51;
            FlightDGV.Size = new Size(856, 213);
            FlightDGV.TabIndex = 31;
            FlightDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            FlightDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            FlightDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            FlightDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            FlightDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            FlightDGV.ThemeStyle.BackColor = Color.White;
            FlightDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            FlightDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            FlightDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            FlightDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            FlightDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            FlightDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            FlightDGV.ThemeStyle.HeaderStyle.Height = 4;
            FlightDGV.ThemeStyle.ReadOnly = false;
            FlightDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            FlightDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            FlightDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            FlightDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            FlightDGV.ThemeStyle.RowsStyle.Height = 29;
            FlightDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            FlightDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            FlightDGV.CellContentClick += FlightDGV_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(477, 359);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(141, 37);
            button2.TabIndex = 33;
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
            button1.Location = new Point(117, 359);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(141, 37);
            button1.TabIndex = 32;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(296, 359);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(141, 37);
            button3.TabIndex = 34;
            button3.Text = "Delete";
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
            button4.Location = new Point(650, 359);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(141, 37);
            button4.TabIndex = 35;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(880, 9);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(28, 27);
            label10.TabIndex = 36;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // ViewFlights
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 635);
            Controls.Add(label10);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(FlightDGV);
            Controls.Add(FDate);
            Controls.Add(label7);
            Controls.Add(DstCb);
            Controls.Add(SrcCb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Seatnum);
            Controls.Add(label3);
            Controls.Add(FcodeTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ViewFlights";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewFlights";
            Load += ViewFlights_Load;
            ((System.ComponentModel.ISupportInitialize)FlightDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DateTimePicker FDate;
        private Label label7;
        private ComboBox DstCb;
        private ComboBox SrcCb;
        private Label label6;
        private Label label5;
        private Label label4;
        private Bunifu.UI.WinForms.BunifuTextBox Seatnum;
        private Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox FcodeTb;
        private Guna.UI2.WinForms.Guna2DataGridView FlightDGV;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label10;
    }
}