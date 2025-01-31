namespace Final_Lab_Project
{
    partial class Home_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Registration));
            this.full_name = new System.Windows.Forms.Label();
            this.fullname_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.phone_number = new System.Windows.Forms.Label();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.Label();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.statues = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.username = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmed_password_textbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.register_button = new System.Windows.Forms.Button();
            this.select_which_floor = new System.Windows.Forms.Label();
            this.save_but = new System.Windows.Forms.Button();
            this.please_select = new System.Windows.Forms.Label();
            this.flat_selection_combobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // full_name
            // 
            this.full_name.AutoSize = true;
            this.full_name.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.full_name.Location = new System.Drawing.Point(46, 130);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(118, 27);
            this.full_name.TabIndex = 0;
            this.full_name.Text = "Full Name:";
            this.full_name.Click += new System.EventHandler(this.full_name_Click);
            // 
            // fullname_textbox
            // 
            this.fullname_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.fullname_textbox.Location = new System.Drawing.Point(180, 130);
            this.fullname_textbox.Name = "fullname_textbox";
            this.fullname_textbox.Size = new System.Drawing.Size(288, 34);
            this.fullname_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.label2.Location = new System.Drawing.Point(349, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(722, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "Home Owner / Renter Registartion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.email.Location = new System.Drawing.Point(46, 200);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(74, 27);
            this.email.TabIndex = 3;
            this.email.Text = "Email:";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // email_textbox
            // 
            this.email_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.email_textbox.Location = new System.Drawing.Point(180, 200);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(288, 34);
            this.email_textbox.TabIndex = 4;
            // 
            // phone_number
            // 
            this.phone_number.AutoSize = true;
            this.phone_number.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.phone_number.Location = new System.Drawing.Point(46, 270);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(163, 27);
            this.phone_number.TabIndex = 5;
            this.phone_number.Text = "Phone Number:";
            this.phone_number.Click += new System.EventHandler(this.phone_number_Click);
            // 
            // phone_textbox
            // 
            this.phone_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.phone_textbox.Location = new System.Drawing.Point(215, 270);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(253, 34);
            this.phone_textbox.TabIndex = 6;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.address.Location = new System.Drawing.Point(46, 340);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(205, 27);
            this.address.TabIndex = 7;
            this.address.Text = "Permenant Address:";
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // address_text
            // 
            this.address_text.Font = new System.Drawing.Font("Arial", 14F);
            this.address_text.Location = new System.Drawing.Point(257, 340);
            this.address_text.Multiline = true;
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(320, 121);
            this.address_text.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(58, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "DOB";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(399, 489);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(95, 26);
            this.save_button.TabIndex = 11;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(60, 560);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(55, 26);
            this.age.TabIndex = 12;
            this.age.Text = "Age:";
            // 
            // age_textbox
            // 
            this.age_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.age_textbox.Location = new System.Drawing.Point(121, 556);
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(100, 34);
            this.age_textbox.TabIndex = 13;
            this.age_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // statues
            // 
            this.statues.AutoSize = true;
            this.statues.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.statues.Location = new System.Drawing.Point(60, 630);
            this.statues.Name = "statues";
            this.statues.Size = new System.Drawing.Size(76, 27);
            this.statues.TabIndex = 14;
            this.statues.Text = "Status:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Owner",
            "Renter"});
            this.comboBox1.Location = new System.Drawing.Point(142, 626);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 34);
            this.comboBox1.TabIndex = 15;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.username.Location = new System.Drawing.Point(60, 700);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(114, 27);
            this.username.TabIndex = 16;
            this.username.Text = "Username:";
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.username_textbox.Location = new System.Drawing.Point(180, 700);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(240, 34);
            this.username_textbox.TabIndex = 17;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.password.Location = new System.Drawing.Point(64, 770);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(110, 27);
            this.password.TabIndex = 18;
            this.password.Text = "Password:";
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.password_textbox.Location = new System.Drawing.Point(180, 763);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(240, 34);
            this.password_textbox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(64, 840);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "Confirm Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // confirmed_password_textbox
            // 
            this.confirmed_password_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.confirmed_password_textbox.Location = new System.Drawing.Point(266, 837);
            this.confirmed_password_textbox.Name = "confirmed_password_textbox";
            this.confirmed_password_textbox.Size = new System.Drawing.Size(240, 34);
            this.confirmed_password_textbox.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 489);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 27);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(695, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 388);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // register_button
            // 
            this.register_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.register_button.Location = new System.Drawing.Point(980, 270);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(112, 45);
            this.register_button.TabIndex = 26;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // select_which_floor
            // 
            this.select_which_floor.AutoSize = true;
            this.select_which_floor.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.select_which_floor.Location = new System.Drawing.Point(690, 151);
            this.select_which_floor.Name = "select_which_floor";
            this.select_which_floor.Size = new System.Drawing.Size(129, 27);
            this.select_which_floor.TabIndex = 27;
            this.select_which_floor.Text = "Select Bari: ";
            // 
            // save_but
            // 
            this.save_but.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.save_but.Location = new System.Drawing.Point(1047, 144);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(82, 34);
            this.save_but.TabIndex = 28;
            this.save_but.Text = "Save";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.Selection_button_Click);
            // 
            // please_select
            // 
            this.please_select.AutoSize = true;
            this.please_select.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.please_select.Location = new System.Drawing.Point(839, 219);
            this.please_select.Name = "please_select";
            this.please_select.Size = new System.Drawing.Size(342, 33);
            this.please_select.TabIndex = 29;
            this.please_select.Text = "Please Press The Button";
            this.please_select.Click += new System.EventHandler(this.please_select_Click);
            // 
            // flat_selection_combobox
            // 
            this.flat_selection_combobox.Font = new System.Drawing.Font("Arial", 14F);
            this.flat_selection_combobox.FormattingEnabled = true;
            this.flat_selection_combobox.Items.AddRange(new object[] {
            "SARKER",
            "PRAMANIK",
            "JAKARIA"});
            this.flat_selection_combobox.Location = new System.Drawing.Point(845, 147);
            this.flat_selection_combobox.Name = "flat_selection_combobox";
            this.flat_selection_combobox.Size = new System.Drawing.Size(184, 34);
            this.flat_selection_combobox.TabIndex = 30;
            this.flat_selection_combobox.SelectedIndexChanged += new System.EventHandler(this.flat_selection_combobox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button1.Location = new System.Drawing.Point(830, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flat_selection_combobox);
            this.Controls.Add(this.please_select);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.select_which_floor);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.confirmed_password_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.username);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statues);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.age);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullname_textbox);
            this.Controls.Add(this.full_name);
            this.Name = "Home_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPJ Bari";
            this.Load += new System.EventHandler(this.Home_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label full_name;
        private System.Windows.Forms.TextBox fullname_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label phone_number;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.Label statues;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox password_textbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmed_password_textbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label select_which_floor;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.Label please_select;
        private System.Windows.Forms.ComboBox flat_selection_combobox;
        private System.Windows.Forms.Button button1;
    }
}