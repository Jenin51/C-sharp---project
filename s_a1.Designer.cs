namespace Final_Lab_Project
{
    partial class s_a1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(s_a1));
            this.welcoming_label = new System.Windows.Forms.Label();
            this.s_a1_panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.complaints = new Guna.UI2.WinForms.Guna2Button();
            this.guest_button = new Guna.UI2.WinForms.Guna2Button();
            this.utility_bill = new Guna.UI2.WinForms.Guna2Button();
            this.add_family_button = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.s_a1_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcoming_label
            // 
            this.welcoming_label.AutoSize = true;
            this.welcoming_label.BackColor = System.Drawing.Color.Transparent;
            this.welcoming_label.Font = new System.Drawing.Font("Showcard Gothic", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcoming_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.welcoming_label.Location = new System.Drawing.Point(339, 31);
            this.welcoming_label.Name = "welcoming_label";
            this.welcoming_label.Size = new System.Drawing.Size(1131, 102);
            this.welcoming_label.TabIndex = 0;
            this.welcoming_label.Text = "Welcome to Sarker Bari";
            this.welcoming_label.Click += new System.EventHandler(this.welcoming_label_Click);
            // 
            // s_a1_panel
            // 
            this.s_a1_panel.Controls.Add(this.complaints);
            this.s_a1_panel.Controls.Add(this.guest_button);
            this.s_a1_panel.Controls.Add(this.utility_bill);
            this.s_a1_panel.Controls.Add(this.add_family_button);
            this.s_a1_panel.FillColor = System.Drawing.Color.SkyBlue;
            this.s_a1_panel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(167)))));
            this.s_a1_panel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(106)))));
            this.s_a1_panel.FillColor4 = System.Drawing.Color.MidnightBlue;
            this.s_a1_panel.Location = new System.Drawing.Point(0, 0);
            this.s_a1_panel.Name = "s_a1_panel";
            this.s_a1_panel.Size = new System.Drawing.Size(326, 959);
            this.s_a1_panel.TabIndex = 8;
            // 
            // complaints
            // 
            this.complaints.BackColor = System.Drawing.Color.Transparent;
            this.complaints.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.complaints.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.complaints.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.complaints.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.complaints.FillColor = System.Drawing.Color.Transparent;
            this.complaints.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.complaints.ForeColor = System.Drawing.Color.White;
            this.complaints.Location = new System.Drawing.Point(0, 586);
            this.complaints.Name = "complaints";
            this.complaints.Size = new System.Drawing.Size(326, 107);
            this.complaints.TabIndex = 3;
            this.complaints.Text = "Complaintes";
            this.complaints.Click += new System.EventHandler(this.complaints_Click);
            // 
            // guest_button
            // 
            this.guest_button.BackColor = System.Drawing.Color.Transparent;
            this.guest_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guest_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guest_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guest_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guest_button.FillColor = System.Drawing.Color.Transparent;
            this.guest_button.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.guest_button.ForeColor = System.Drawing.Color.White;
            this.guest_button.Location = new System.Drawing.Point(-3, 473);
            this.guest_button.Name = "guest_button";
            this.guest_button.Size = new System.Drawing.Size(326, 107);
            this.guest_button.TabIndex = 2;
            this.guest_button.Text = "Guest";
            this.guest_button.Click += new System.EventHandler(this.guest_button_Click);
            // 
            // utility_bill
            // 
            this.utility_bill.BackColor = System.Drawing.Color.Transparent;
            this.utility_bill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.utility_bill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.utility_bill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.utility_bill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.utility_bill.FillColor = System.Drawing.Color.Transparent;
            this.utility_bill.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.utility_bill.ForeColor = System.Drawing.Color.White;
            this.utility_bill.Location = new System.Drawing.Point(-3, 360);
            this.utility_bill.Name = "utility_bill";
            this.utility_bill.Size = new System.Drawing.Size(326, 107);
            this.utility_bill.TabIndex = 1;
            this.utility_bill.Text = "Utility Bills";
            this.utility_bill.Click += new System.EventHandler(this.utility_bill_Click);
            // 
            // add_family_button
            // 
            this.add_family_button.BackColor = System.Drawing.Color.Transparent;
            this.add_family_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_family_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_family_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_family_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_family_button.FillColor = System.Drawing.Color.Transparent;
            this.add_family_button.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.add_family_button.ForeColor = System.Drawing.Color.White;
            this.add_family_button.Location = new System.Drawing.Point(3, 247);
            this.add_family_button.Name = "add_family_button";
            this.add_family_button.Size = new System.Drawing.Size(326, 107);
            this.add_family_button.TabIndex = 0;
            this.add_family_button.Text = "Family Member";
            this.add_family_button.Click += new System.EventHandler(this.add_family_button_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Transparent;
            this.time_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.time_label.Location = new System.Drawing.Point(666, 168);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(534, 123);
            this.time_label.TabIndex = 9;
            this.time_label.Text = "00:00:00";
            this.time_label.Click += new System.EventHandler(this.time_label_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(727, 782);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 73);
            this.button2.TabIndex = 15;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // s_a1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.s_a1_panel);
            this.Controls.Add(this.welcoming_label);
            this.Name = "s_a1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPJ Bari";
            this.Load += new System.EventHandler(this.s_a1_Load);
            this.s_a1_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcoming_label;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel s_a1_panel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_label;
        private Guna.UI2.WinForms.Guna2Button add_family_button;
        private Guna.UI2.WinForms.Guna2Button complaints;
        private Guna.UI2.WinForms.Guna2Button guest_button;
        private Guna.UI2.WinForms.Guna2Button utility_bill;
        private System.Windows.Forms.Button button2;
    }
}