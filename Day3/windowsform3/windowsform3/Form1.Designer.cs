namespace windowsform3
{
    partial class dialogs_and_forms
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
            this.buttonTextFile = new System.Windows.Forms.Button();
            this.buttoncolour = new System.Windows.Forms.Button();
            this.buttonNextForm = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonTextFile
            // 
            this.buttonTextFile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTextFile.Location = new System.Drawing.Point(69, 77);
            this.buttonTextFile.Name = "buttonTextFile";
            this.buttonTextFile.Size = new System.Drawing.Size(124, 51);
            this.buttonTextFile.TabIndex = 0;
            this.buttonTextFile.Text = "Open a text file";
            this.buttonTextFile.UseVisualStyleBackColor = true;
            // 
            // buttoncolour
            // 
            this.buttoncolour.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncolour.Location = new System.Drawing.Point(69, 193);
            this.buttoncolour.Name = "buttoncolour";
            this.buttoncolour.Size = new System.Drawing.Size(124, 58);
            this.buttoncolour.TabIndex = 1;
            this.buttoncolour.Text = "Change Background Colour";
            this.buttoncolour.UseVisualStyleBackColor = true;
            // 
            // buttonNextForm
            // 
            this.buttonNextForm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextForm.Location = new System.Drawing.Point(69, 304);
            this.buttonNextForm.Name = "buttonNextForm";
            this.buttonNextForm.Size = new System.Drawing.Size(124, 46);
            this.buttonNextForm.TabIndex = 2;
            this.buttonNextForm.Text = "Go To Next Form";
            this.buttonNextForm.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(307, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 174);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // dialogs_and_forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 451);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonNextForm);
            this.Controls.Add(this.buttoncolour);
            this.Controls.Add(this.buttonTextFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "dialogs_and_forms";
            this.Text = "Windows Forms - dialogs & forms sequence";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTextFile;
        private System.Windows.Forms.Button buttoncolour;
        private System.Windows.Forms.Button buttonNextForm;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

