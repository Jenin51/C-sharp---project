namespace Final_Lab_Project
{
    partial class Jakaria_complaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jakaria_complaint));
            this.button1 = new System.Windows.Forms.Button();
            this.Send_button = new System.Windows.Forms.Button();
            this.complaint_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.subject_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.enter_complaint_label = new System.Windows.Forms.Label();
            this.subject_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button1.Location = new System.Drawing.Point(248, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Send_button
            // 
            this.Send_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Send_button.Location = new System.Drawing.Point(92, 302);
            this.Send_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(77, 32);
            this.Send_button.TabIndex = 19;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // complaint_textbox
            // 
            this.complaint_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.complaint_textbox.DefaultText = "";
            this.complaint_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.complaint_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.complaint_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.complaint_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.complaint_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.complaint_textbox.Font = new System.Drawing.Font("Arial", 10F);
            this.complaint_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.complaint_textbox.Location = new System.Drawing.Point(36, 150);
            this.complaint_textbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.complaint_textbox.Name = "complaint_textbox";
            this.complaint_textbox.PasswordChar = '\0';
            this.complaint_textbox.PlaceholderText = "";
            this.complaint_textbox.SelectedText = "";
            this.complaint_textbox.Size = new System.Drawing.Size(533, 129);
            this.complaint_textbox.TabIndex = 18;
            // 
            // subject_textbox
            // 
            this.subject_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subject_textbox.DefaultText = "";
            this.subject_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.subject_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.subject_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subject_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subject_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subject_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subject_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subject_textbox.Location = new System.Drawing.Point(141, 32);
            this.subject_textbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.subject_textbox.Name = "subject_textbox";
            this.subject_textbox.PasswordChar = '\0';
            this.subject_textbox.PlaceholderText = "";
            this.subject_textbox.SelectedText = "";
            this.subject_textbox.Size = new System.Drawing.Size(221, 39);
            this.subject_textbox.TabIndex = 17;
            // 
            // enter_complaint_label
            // 
            this.enter_complaint_label.AutoSize = true;
            this.enter_complaint_label.BackColor = System.Drawing.Color.Transparent;
            this.enter_complaint_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_complaint_label.Location = new System.Drawing.Point(32, 109);
            this.enter_complaint_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enter_complaint_label.Name = "enter_complaint_label";
            this.enter_complaint_label.Size = new System.Drawing.Size(199, 26);
            this.enter_complaint_label.TabIndex = 16;
            this.enter_complaint_label.Text = "Enter Complaint: ";
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.BackColor = System.Drawing.Color.Transparent;
            this.subject_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_label.Location = new System.Drawing.Point(32, 32);
            this.subject_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(97, 26);
            this.subject_label.TabIndex = 15;
            this.subject_label.Text = "Subject:";
            // 
            // Jakaria_complaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(610, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.complaint_textbox);
            this.Controls.Add(this.subject_textbox);
            this.Controls.Add(this.enter_complaint_label);
            this.Controls.Add(this.subject_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Jakaria_complaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPJ Bari";
            this.Load += new System.EventHandler(this.Jakaria_complaint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Send_button;
        private Guna.UI2.WinForms.Guna2TextBox complaint_textbox;
        private Guna.UI2.WinForms.Guna2TextBox subject_textbox;
        private System.Windows.Forms.Label enter_complaint_label;
        private System.Windows.Forms.Label subject_label;
    }
}