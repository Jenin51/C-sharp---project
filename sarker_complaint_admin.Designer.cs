namespace Final_Lab_Project
{
    partial class sarker_complaint_admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.insert_notice_label = new System.Windows.Forms.Label();
            this.write_textbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Send_notice_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Add your notes:";
            // 
            // insert_notice_label
            // 
            this.insert_notice_label.AutoSize = true;
            this.insert_notice_label.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_notice_label.Location = new System.Drawing.Point(70, -35);
            this.insert_notice_label.Name = "insert_notice_label";
            this.insert_notice_label.Size = new System.Drawing.Size(132, 37);
            this.insert_notice_label.TabIndex = 22;
            this.insert_notice_label.Text = "Notices:";
            // 
            // write_textbox
            // 
            this.write_textbox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.write_textbox.Location = new System.Drawing.Point(36, 105);
            this.write_textbox.Multiline = true;
            this.write_textbox.Name = "write_textbox";
            this.write_textbox.Size = new System.Drawing.Size(736, 120);
            this.write_textbox.TabIndex = 21;
            this.write_textbox.TextChanged += new System.EventHandler(this.write_textbox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(539, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 54);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 214);
            this.dataGridView1.TabIndex = 19;
            // 
            // Send_notice_button
            // 
            this.Send_notice_button.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_notice_button.Location = new System.Drawing.Point(36, 248);
            this.Send_notice_button.Name = "Send_notice_button";
            this.Send_notice_button.Size = new System.Drawing.Size(176, 59);
            this.Send_notice_button.TabIndex = 18;
            this.Send_notice_button.Text = "Send";
            this.Send_notice_button.UseVisualStyleBackColor = true;
            this.Send_notice_button.Click += new System.EventHandler(this.Send_notice_button_Click);
            // 
            // sarker_complaint_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert_notice_label);
            this.Controls.Add(this.write_textbox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Send_notice_button);
            this.Name = "sarker_complaint_admin";
            this.Text = "sarker_complaint_admin";
            this.Load += new System.EventHandler(this.sarker_complaint_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label insert_notice_label;
        private System.Windows.Forms.TextBox write_textbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Send_notice_button;
    }
}