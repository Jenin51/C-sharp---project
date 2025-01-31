namespace Final_Lab_Project
{
    partial class choice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choice));
            this.label1 = new System.Windows.Forms.Label();
            this.house_radion = new System.Windows.Forms.RadioButton();
            this.support_admin_radio = new System.Windows.Forms.RadioButton();
            this.next_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "You are:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // house_radion
            // 
            this.house_radion.AutoSize = true;
            this.house_radion.BackColor = System.Drawing.Color.Transparent;
            this.house_radion.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.house_radion.ForeColor = System.Drawing.Color.White;
            this.house_radion.Location = new System.Drawing.Point(202, 190);
            this.house_radion.Name = "house_radion";
            this.house_radion.Size = new System.Drawing.Size(255, 31);
            this.house_radion.TabIndex = 1;
            this.house_radion.TabStop = true;
            this.house_radion.Text = " House Owner / Renter";
            this.house_radion.UseVisualStyleBackColor = false;
            this.house_radion.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // support_admin_radio
            // 
            this.support_admin_radio.AutoSize = true;
            this.support_admin_radio.BackColor = System.Drawing.Color.Transparent;
            this.support_admin_radio.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.support_admin_radio.ForeColor = System.Drawing.Color.White;
            this.support_admin_radio.Location = new System.Drawing.Point(202, 244);
            this.support_admin_radio.Name = "support_admin_radio";
            this.support_admin_radio.Size = new System.Drawing.Size(178, 31);
            this.support_admin_radio.TabIndex = 2;
            this.support_admin_radio.TabStop = true;
            this.support_admin_radio.Text = "Support Admin";
            this.support_admin_radio.UseVisualStyleBackColor = false;
            this.support_admin_radio.CheckedChanged += new System.EventHandler(this.support_admin_radio_CheckedChanged);
            // 
            // next_button
            // 
            this.next_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.next_button.Location = new System.Drawing.Point(287, 304);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(93, 39);
            this.next_button.TabIndex = 3;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button1.Location = new System.Drawing.Point(287, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(685, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.support_admin_radio);
            this.Controls.Add(this.house_radion);
            this.Controls.Add(this.label1);
            this.Name = "choice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPJ Bari";
            this.Load += new System.EventHandler(this.choice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton house_radion;
        private System.Windows.Forms.RadioButton support_admin_radio;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button button1;
    }
}