namespace Final_Lab_Project
{
    partial class pramanik_admin_dashboard
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
            this.familymember_button = new System.Windows.Forms.Button();
            this.guest_button = new System.Windows.Forms.Button();
            this.utility_button = new System.Windows.Forms.Button();
            this.complaint_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // familymember_button
            // 
            this.familymember_button.AutoSize = true;
            this.familymember_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.familymember_button.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familymember_button.Location = new System.Drawing.Point(207, 57);
            this.familymember_button.Name = "familymember_button";
            this.familymember_button.Size = new System.Drawing.Size(413, 63);
            this.familymember_button.TabIndex = 0;
            this.familymember_button.Text = "Family Member Control";
            this.familymember_button.UseVisualStyleBackColor = true;
            // 
            // guest_button
            // 
            this.guest_button.AutoSize = true;
            this.guest_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.guest_button.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_button.Location = new System.Drawing.Point(207, 357);
            this.guest_button.Name = "guest_button";
            this.guest_button.Size = new System.Drawing.Size(413, 63);
            this.guest_button.TabIndex = 4;
            this.guest_button.Text = "Guest Info";
            this.guest_button.UseVisualStyleBackColor = true;
            // 
            // utility_button
            // 
            this.utility_button.AutoSize = true;
            this.utility_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.utility_button.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utility_button.Location = new System.Drawing.Point(207, 254);
            this.utility_button.Name = "utility_button";
            this.utility_button.Size = new System.Drawing.Size(413, 63);
            this.utility_button.TabIndex = 5;
            this.utility_button.Text = "Utilities";
            this.utility_button.UseVisualStyleBackColor = true;
            // 
            // complaint_button
            // 
            this.complaint_button.AutoSize = true;
            this.complaint_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.complaint_button.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaint_button.Location = new System.Drawing.Point(207, 153);
            this.complaint_button.Name = "complaint_button";
            this.complaint_button.Size = new System.Drawing.Size(413, 63);
            this.complaint_button.TabIndex = 6;
            this.complaint_button.Text = "Complaint";
            this.complaint_button.UseVisualStyleBackColor = true;
            this.complaint_button.Click += new System.EventHandler(this.complaint_button_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(351, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pramanik_admin_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.complaint_button);
            this.Controls.Add(this.utility_button);
            this.Controls.Add(this.guest_button);
            this.Controls.Add(this.familymember_button);
            this.Name = "pramanik_admin_dashboard";
            this.Text = "SPJ Bari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button familymember_button;
        private System.Windows.Forms.Button guest_button;
        private System.Windows.Forms.Button utility_button;
        private System.Windows.Forms.Button complaint_button;
        private System.Windows.Forms.Button button2;
    }
}