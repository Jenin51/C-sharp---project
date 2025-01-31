namespace Final_Lab_Project
{
    partial class sarker_admin_utiliti
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
            this.date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_textbox = new System.Windows.Forms.TextBox();
            this.bill_textbox = new System.Windows.Forms.TextBox();
            this.comment_textbox = new System.Windows.Forms.TextBox();
            this.utility_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(64, 55);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(61, 26);
            this.date.TabIndex = 0;
            this.date.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Utility";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Coment";
            // 
            // date_textbox
            // 
            this.date_textbox.Location = new System.Drawing.Point(153, 43);
            this.date_textbox.Multiline = true;
            this.date_textbox.Name = "date_textbox";
            this.date_textbox.Size = new System.Drawing.Size(331, 38);
            this.date_textbox.TabIndex = 4;
            // 
            // bill_textbox
            // 
            this.bill_textbox.Location = new System.Drawing.Point(153, 115);
            this.bill_textbox.Multiline = true;
            this.bill_textbox.Name = "bill_textbox";
            this.bill_textbox.Size = new System.Drawing.Size(331, 38);
            this.bill_textbox.TabIndex = 5;
            // 
            // comment_textbox
            // 
            this.comment_textbox.Location = new System.Drawing.Point(153, 237);
            this.comment_textbox.Multiline = true;
            this.comment_textbox.Name = "comment_textbox";
            this.comment_textbox.Size = new System.Drawing.Size(321, 38);
            this.comment_textbox.TabIndex = 6;
            // 
            // utility_textbox
            // 
            this.utility_textbox.Location = new System.Drawing.Point(153, 179);
            this.utility_textbox.Multiline = true;
            this.utility_textbox.Name = "utility_textbox";
            this.utility_textbox.Size = new System.Drawing.Size(331, 38);
            this.utility_textbox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sarker_admin_utiliti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.utility_textbox);
            this.Controls.Add(this.comment_textbox);
            this.Controls.Add(this.bill_textbox);
            this.Controls.Add(this.date_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Name = "sarker_admin_utiliti";
            this.Text = "sarker_admin_utiliti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox date_textbox;
        private System.Windows.Forms.TextBox bill_textbox;
        private System.Windows.Forms.TextBox comment_textbox;
        private System.Windows.Forms.TextBox utility_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}