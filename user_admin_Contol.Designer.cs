namespace Final_Lab_Project
{
    partial class user_admin_Contol
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
            this.components = new System.ComponentModel.Container();
            this.select_which_floor = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.statues = new System.Windows.Forms.Label();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.phone_number = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullname_textbox = new System.Windows.Forms.TextBox();
            this.full_name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.colse_button = new System.Windows.Forms.Button();
            this.first_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.last_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.loginDataSet = new Final_Lab_Project.loginDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Final_Lab_Project.loginDataSetTableAdapters.loginTableAdapter();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.loginDataSet1 = new Final_Lab_Project.loginDataSet1();
            this.loginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter1 = new Final_Lab_Project.loginDataSet1TableAdapters.loginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // select_which_floor
            // 
            this.select_which_floor.AutoSize = true;
            this.select_which_floor.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.select_which_floor.Location = new System.Drawing.Point(740, 154);
            this.select_which_floor.Name = "select_which_floor";
            this.select_which_floor.Size = new System.Drawing.Size(129, 27);
            this.select_which_floor.TabIndex = 55;
            this.select_which_floor.Text = "Select Bari: ";
            // 
            // password_textbox
            // 
            this.password_textbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource1, "Password", true));
            this.password_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.password_textbox.Location = new System.Drawing.Point(230, 787);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(240, 34);
            this.password_textbox.TabIndex = 49;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.password.Location = new System.Drawing.Point(114, 794);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(110, 27);
            this.password.TabIndex = 48;
            this.password.Text = "Password:";
            // 
            // username_textbox
            // 
            this.username_textbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource1, "UserName", true));
            this.username_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.username_textbox.Location = new System.Drawing.Point(230, 724);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(240, 34);
            this.username_textbox.TabIndex = 47;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.username.Location = new System.Drawing.Point(110, 724);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(114, 27);
            this.username.TabIndex = 46;
            this.username.Text = "Username:";
            // 
            // statues
            // 
            this.statues.AutoSize = true;
            this.statues.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.statues.Location = new System.Drawing.Point(110, 654);
            this.statues.Name = "statues";
            this.statues.Size = new System.Drawing.Size(76, 27);
            this.statues.TabIndex = 44;
            this.statues.Text = "Status:";
            // 
            // age_textbox
            // 
            this.age_textbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource1, "Age", true));
            this.age_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.age_textbox.Location = new System.Drawing.Point(171, 580);
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(100, 34);
            this.age_textbox.TabIndex = 43;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(110, 584);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(55, 26);
            this.age.TabIndex = 42;
            this.age.Text = "Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(108, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "DOB";
            // 
            // address_text
            // 
            this.address_text.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource1, "Address", true));
            this.address_text.Font = new System.Drawing.Font("Arial", 14F);
            this.address_text.Location = new System.Drawing.Point(307, 364);
            this.address_text.Multiline = true;
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(320, 121);
            this.address_text.TabIndex = 39;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.address.Location = new System.Drawing.Point(96, 364);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(205, 27);
            this.address.TabIndex = 38;
            this.address.Text = "Permenant Address:";
            // 
            // phone_textbox
            // 
            this.phone_textbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource1, "Phone", true));
            this.phone_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.phone_textbox.Location = new System.Drawing.Point(265, 294);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(253, 34);
            this.phone_textbox.TabIndex = 37;
            // 
            // phone_number
            // 
            this.phone_number.AutoSize = true;
            this.phone_number.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.phone_number.Location = new System.Drawing.Point(96, 294);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(163, 27);
            this.phone_number.TabIndex = 36;
            this.phone_number.Text = "Phone Number:";
            // 
            // email_textbox
            // 
            this.email_textbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource1, "Email", true));
            this.email_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.email_textbox.Location = new System.Drawing.Point(230, 224);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(288, 34);
            this.email_textbox.TabIndex = 35;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.email.Location = new System.Drawing.Point(96, 224);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(74, 27);
            this.email.TabIndex = 34;
            this.email.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.label2.Location = new System.Drawing.Point(399, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(722, 57);
            this.label2.TabIndex = 33;
            this.label2.Text = "Home Owner / Renter Registartion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fullname_textbox
            // 
            this.fullname_textbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource1, "Name", true));
            this.fullname_textbox.Font = new System.Drawing.Font("Arial", 14F);
            this.fullname_textbox.Location = new System.Drawing.Point(230, 154);
            this.fullname_textbox.Name = "fullname_textbox";
            this.fullname_textbox.Size = new System.Drawing.Size(288, 34);
            this.fullname_textbox.TabIndex = 32;
            // 
            // full_name
            // 
            this.full_name.AutoSize = true;
            this.full_name.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.full_name.Location = new System.Drawing.Point(96, 154);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(118, 27);
            this.full_name.TabIndex = 31;
            this.full_name.Text = "Full Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(673, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 427);
            this.dataGridView1.TabIndex = 59;
            // 
            // add_button
            // 
            this.add_button.AutoSize = true;
            this.add_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.add_button.Location = new System.Drawing.Point(673, 809);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(96, 39);
            this.add_button.TabIndex = 60;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // savebutton
            // 
            this.savebutton.AutoSize = true;
            this.savebutton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.savebutton.Location = new System.Drawing.Point(907, 809);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(96, 39);
            this.savebutton.TabIndex = 61;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // delete_button
            // 
            this.delete_button.AutoSize = true;
            this.delete_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.delete_button.Location = new System.Drawing.Point(1124, 809);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(96, 39);
            this.delete_button.TabIndex = 62;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // colse_button
            // 
            this.colse_button.AutoSize = true;
            this.colse_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.colse_button.Location = new System.Drawing.Point(1329, 809);
            this.colse_button.Name = "colse_button";
            this.colse_button.Size = new System.Drawing.Size(96, 39);
            this.colse_button.TabIndex = 63;
            this.colse_button.Text = "Close";
            this.colse_button.UseVisualStyleBackColor = true;
            this.colse_button.Click += new System.EventHandler(this.colse_button_Click);
            // 
            // first_button
            // 
            this.first_button.AutoSize = true;
            this.first_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.first_button.Location = new System.Drawing.Point(673, 892);
            this.first_button.Name = "first_button";
            this.first_button.Size = new System.Drawing.Size(96, 39);
            this.first_button.TabIndex = 64;
            this.first_button.Text = "First";
            this.first_button.UseVisualStyleBackColor = true;
            this.first_button.Click += new System.EventHandler(this.first_button_Click);
            // 
            // next_button
            // 
            this.next_button.AutoSize = true;
            this.next_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.next_button.Location = new System.Drawing.Point(1329, 892);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(96, 39);
            this.next_button.TabIndex = 65;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // last_button
            // 
            this.last_button.AutoSize = true;
            this.last_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.last_button.Location = new System.Drawing.Point(907, 892);
            this.last_button.Name = "last_button";
            this.last_button.Size = new System.Drawing.Size(96, 39);
            this.last_button.TabIndex = 65;
            this.last_button.Text = "Last";
            this.last_button.UseVisualStyleBackColor = true;
            this.last_button.Click += new System.EventHandler(this.last_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.AutoSize = true;
            this.previous_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.previous_button.Location = new System.Drawing.Point(1124, 892);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(106, 39);
            this.previous_button.TabIndex = 66;
            this.previous_button.Text = "Previous";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "loginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.loginDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Apartment";
            this.floorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource1, "DOB", true));
            this.textBox1.Font = new System.Drawing.Font("Arial", 14F);
            this.textBox1.Location = new System.Drawing.Point(171, 510);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 34);
            this.textBox1.TabIndex = 67;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource1, "Status", true));
            this.textBox2.Font = new System.Drawing.Font("Arial", 14F);
            this.textBox2.Location = new System.Drawing.Point(192, 650);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 34);
            this.textBox2.TabIndex = 68;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource1, "Floor", true));
            this.textBox3.Font = new System.Drawing.Font("Arial", 14F);
            this.textBox3.Location = new System.Drawing.Point(868, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 34);
            this.textBox3.TabIndex = 69;
            // 
            // loginDataSet1
            // 
            this.loginDataSet1.DataSetName = "loginDataSet1";
            this.loginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource1
            // 
            this.loginBindingSource1.DataMember = "login";
            this.loginBindingSource1.DataSource = this.loginDataSet1;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // user_admin_Contol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.last_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.first_button);
            this.Controls.Add(this.colse_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.select_which_floor);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.username);
            this.Controls.Add(this.statues);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.age);
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
            this.Name = "user_admin_Contol";
            this.Text = "SPJ Bari";
            this.Load += new System.EventHandler(this.user_admin_Contol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label select_which_floor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label statues;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label phone_number;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullname_textbox;
        private System.Windows.Forms.Label full_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button colse_button;
        private System.Windows.Forms.Button first_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button last_button;
        private System.Windows.Forms.Button previous_button;
        private loginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private loginDataSetTableAdapters.loginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private loginDataSet1 loginDataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource1;
        private loginDataSet1TableAdapters.loginTableAdapter loginTableAdapter1;
    }
}