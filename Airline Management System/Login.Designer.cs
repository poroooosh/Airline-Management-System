namespace Airline_Management_System
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            PassTb = new Bunifu.UI.WinForms.BunifuTextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            UidTb = new Bunifu.UI.WinForms.BunifuTextBox();
            label6 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 585);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(78, 295);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 175);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 188);
            label5.Name = "label5";
            label5.Size = new Size(243, 27);
            label5.TabIndex = 4;
            label5.Text = "Your Home In The Air";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(307, 27);
            label4.TabIndex = 3;
            label4.Text = "Biman Bangladesh Airlines";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(389, 39);
            label1.Name = "label1";
            label1.Size = new Size(398, 37);
            label1.TabIndex = 2;
            label1.Text = "Biman Bangladesh Airlines";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(356, 241);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 3;
            label2.Text = "User Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(356, 301);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(472, 387);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 46);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(609, 387);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 46);
            button2.TabIndex = 6;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // PassTb
            // 
            PassTb.AcceptsReturn = false;
            PassTb.AcceptsTab = false;
            PassTb.AnimationSpeed = 200;
            PassTb.AutoCompleteMode = AutoCompleteMode.None;
            PassTb.AutoCompleteSource = AutoCompleteSource.None;
            PassTb.AutoSizeHeight = true;
            PassTb.BackColor = Color.White;
            PassTb.BackgroundImage = (Image)resources.GetObject("PassTb.BackgroundImage");
            PassTb.BorderColorActive = Color.DodgerBlue;
            PassTb.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            PassTb.BorderColorHover = Color.FromArgb(105, 181, 255);
            PassTb.BorderColorIdle = Color.Silver;
            PassTb.BorderRadius = 1;
            PassTb.BorderThickness = 1;
            PassTb.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            PassTb.CharacterCasing = CharacterCasing.Normal;
            PassTb.Cursor = Cursors.IBeam;
            PassTb.DefaultFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PassTb.DefaultText = "";
            PassTb.FillColor = Color.White;
            PassTb.ForeColor = Color.Red;
            PassTb.HideSelection = true;
            PassTb.IconLeft = null;
            PassTb.IconLeftCursor = Cursors.IBeam;
            PassTb.IconPadding = 10;
            PassTb.IconRight = null;
            PassTb.IconRightCursor = Cursors.IBeam;
            PassTb.Location = new Point(487, 301);
            PassTb.Margin = new Padding(3, 4, 3, 4);
            PassTb.MaxLength = 32767;
            PassTb.MinimumSize = new Size(1, 1);
            PassTb.Modified = false;
            PassTb.Multiline = false;
            PassTb.Name = "PassTb";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            PassTb.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            PassTb.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            PassTb.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Red;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            PassTb.OnIdleState = stateProperties8;
            PassTb.Padding = new Padding(3, 4, 3, 4);
            PassTb.PasswordChar = '\0';
            PassTb.PlaceholderForeColor = Color.Silver;
            PassTb.PlaceholderText = "Enter text";
            PassTb.ReadOnly = false;
            PassTb.ScrollBars = ScrollBars.None;
            PassTb.SelectedText = "";
            PassTb.SelectionLength = 0;
            PassTb.SelectionStart = 0;
            PassTb.ShortcutsEnabled = true;
            PassTb.Size = new Size(251, 29);
            PassTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            PassTb.TabIndex = 8;
            PassTb.TextAlign = HorizontalAlignment.Left;
            PassTb.TextMarginBottom = 0;
            PassTb.TextMarginLeft = 3;
            PassTb.TextMarginTop = 1;
            PassTb.TextPlaceholder = "Enter text";
            PassTb.UseSystemPasswordChar = true;
            PassTb.WordWrap = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(780, 11);
            label7.Name = "label7";
            label7.Size = new Size(28, 27);
            label7.TabIndex = 9;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(465, 580);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(481, 455);
            label9.Name = "label9";
            label9.Size = new Size(222, 37);
            label9.TabIndex = 11;
            label9.Text = "Developed By";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(553, 96);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // UidTb
            // 
            UidTb.AcceptsReturn = false;
            UidTb.AcceptsTab = false;
            UidTb.AnimationSpeed = 200;
            UidTb.AutoCompleteMode = AutoCompleteMode.None;
            UidTb.AutoCompleteSource = AutoCompleteSource.None;
            UidTb.AutoSizeHeight = true;
            UidTb.BackColor = Color.White;
            UidTb.BackgroundImage = (Image)resources.GetObject("UidTb.BackgroundImage");
            UidTb.BorderColorActive = Color.DodgerBlue;
            UidTb.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            UidTb.BorderColorHover = Color.FromArgb(105, 181, 255);
            UidTb.BorderColorIdle = Color.Silver;
            UidTb.BorderRadius = 1;
            UidTb.BorderThickness = 1;
            UidTb.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            UidTb.CharacterCasing = CharacterCasing.Normal;
            UidTb.Cursor = Cursors.IBeam;
            UidTb.DefaultFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UidTb.DefaultText = "";
            UidTb.FillColor = Color.White;
            UidTb.ForeColor = Color.Red;
            UidTb.HideSelection = true;
            UidTb.IconLeft = null;
            UidTb.IconLeftCursor = Cursors.IBeam;
            UidTb.IconPadding = 10;
            UidTb.IconRight = null;
            UidTb.IconRightCursor = Cursors.IBeam;
            UidTb.Location = new Point(487, 241);
            UidTb.Margin = new Padding(3, 4, 3, 4);
            UidTb.MaxLength = 32767;
            UidTb.MinimumSize = new Size(1, 1);
            UidTb.Modified = false;
            UidTb.Multiline = false;
            UidTb.Name = "UidTb";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            UidTb.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            UidTb.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            UidTb.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Red;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            UidTb.OnIdleState = stateProperties4;
            UidTb.Padding = new Padding(3, 4, 3, 4);
            UidTb.PasswordChar = '\0';
            UidTb.PlaceholderForeColor = Color.Silver;
            UidTb.PlaceholderText = "Enter text";
            UidTb.ReadOnly = false;
            UidTb.ScrollBars = ScrollBars.None;
            UidTb.SelectedText = "";
            UidTb.SelectionLength = 0;
            UidTb.SelectionStart = 0;
            UidTb.ShortcutsEnabled = true;
            UidTb.Size = new Size(251, 29);
            UidTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            UidTb.TabIndex = 15;
            UidTb.TextAlign = HorizontalAlignment.Left;
            UidTb.TextMarginBottom = 0;
            UidTb.TextMarginLeft = 3;
            UidTb.TextMarginTop = 1;
            UidTb.TextPlaceholder = "Enter text";
            UidTb.UseSystemPasswordChar = false;
            UidTb.WordWrap = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(473, 503);
            label6.Name = "label6";
            label6.Size = new Size(230, 19);
            label6.TabIndex = 16;
            label6.Text = "hasnatzadid13@gmail.com";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(473, 522);
            label10.Name = "label10";
            label10.Size = new Size(224, 23);
            label10.TabIndex = 17;
            label10.Text = "Talukder Hasnat Zadid";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(820, 585);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(UidTb);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(PassTb);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Bunifu.UI.WinForms.BunifuTextBox PassTb;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox UidTb;
        private Label label6;
        private Label label10;
    }
}


