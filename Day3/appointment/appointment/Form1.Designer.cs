namespace appointment
{
    partial class Form1
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
            this.Name = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.DrName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name.Location = new System.Drawing.Point(56, 53);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(183, 16);
            this.Name.TabIndex = 0;
            this.Name.Text = "Please Enter Your Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(261, 49);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(141, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // DrName
            // 
            this.DrName.AutoSize = true;
            this.DrName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrName.Location = new System.Drawing.Point(25, 96);
            this.DrName.Name = "DrName";
            this.DrName.Size = new System.Drawing.Size(214, 16);
            this.DrName.TabIndex = 2;
            this.DrName.Text = "Please Enter Doctor`s Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 352);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DrName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label DrName;
        private System.Windows.Forms.TextBox textBox1;
    }
}

