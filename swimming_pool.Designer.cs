namespace Final_Lab_Project
{
    partial class swimming_pool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(swimming_pool));
            this.swimming_label = new System.Windows.Forms.Label();
            this.swim_user_label = new System.Windows.Forms.Label();
            this.swim_username = new System.Windows.Forms.TextBox();
            this.swim_back_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // swimming_label
            // 
            this.swimming_label.BackColor = System.Drawing.Color.Transparent;
            this.swimming_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimming_label.ForeColor = System.Drawing.Color.White;
            this.swimming_label.Location = new System.Drawing.Point(300, 99);
            this.swimming_label.Name = "swimming_label";
            this.swimming_label.Size = new System.Drawing.Size(956, 148);
            this.swimming_label.TabIndex = 0;
            this.swimming_label.Text = "Swimming Pool";
            // 
            // swim_user_label
            // 
            this.swim_user_label.AutoSize = true;
            this.swim_user_label.BackColor = System.Drawing.Color.Transparent;
            this.swim_user_label.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swim_user_label.ForeColor = System.Drawing.Color.White;
            this.swim_user_label.Location = new System.Drawing.Point(581, 407);
            this.swim_user_label.Name = "swim_user_label";
            this.swim_user_label.Size = new System.Drawing.Size(286, 42);
            this.swim_user_label.TabIndex = 1;
            this.swim_user_label.Text = "Enter Username:";
            // 
            // swim_username
            // 
            this.swim_username.Font = new System.Drawing.Font("Arial", 14F);
            this.swim_username.Location = new System.Drawing.Point(538, 470);
            this.swim_username.Name = "swim_username";
            this.swim_username.Size = new System.Drawing.Size(380, 34);
            this.swim_username.TabIndex = 2;
            // 
            // swim_back_button
            // 
            this.swim_back_button.AutoSize = true;
            this.swim_back_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.swim_back_button.Location = new System.Drawing.Point(1234, 891);
            this.swim_back_button.Name = "swim_back_button";
            this.swim_back_button.Size = new System.Drawing.Size(96, 37);
            this.swim_back_button.TabIndex = 3;
            this.swim_back_button.Text = "Login";
            this.swim_back_button.UseVisualStyleBackColor = true;
            this.swim_back_button.Click += new System.EventHandler(this.swim_back_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button1.Location = new System.Drawing.Point(1359, 891);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // swimming_pool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.swim_back_button);
            this.Controls.Add(this.swim_username);
            this.Controls.Add(this.swim_user_label);
            this.Controls.Add(this.swimming_label);
            this.Name = "swimming_pool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPJ Bari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label swimming_label;
        private System.Windows.Forms.Label swim_user_label;
        private System.Windows.Forms.TextBox swim_username;
        private System.Windows.Forms.Button swim_back_button;
        private System.Windows.Forms.Button button1;
    }
}