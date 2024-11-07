namespace PRG282_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddStudent = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.BtnUpdateStudent = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnSummary = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Records";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.Location = new System.Drawing.Point(147, 107);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(115, 47);
            this.BtnAddStudent.TabIndex = 3;
            this.BtnAddStudent.Text = "Add Student";
            this.BtnAddStudent.UseVisualStyleBackColor = true;
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Location = new System.Drawing.Point(279, 168);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(115, 47);
            this.btnViewStudents.TabIndex = 4;
            this.btnViewStudents.Text = "View Student Database";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // BtnUpdateStudent
            // 
            this.BtnUpdateStudent.Location = new System.Drawing.Point(147, 226);
            this.BtnUpdateStudent.Name = "BtnUpdateStudent";
            this.BtnUpdateStudent.Size = new System.Drawing.Size(115, 47);
            this.BtnUpdateStudent.TabIndex = 5;
            this.BtnUpdateStudent.Text = "Update Students Information";
            this.BtnUpdateStudent.UseVisualStyleBackColor = true;
            this.BtnUpdateStudent.Click += new System.EventHandler(this.BtnUpdateStudent_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(423, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 47);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete a Student";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnSummary
            // 
            this.BtnSummary.Location = new System.Drawing.Point(559, 107);
            this.BtnSummary.Name = "BtnSummary";
            this.BtnSummary.Size = new System.Drawing.Size(115, 47);
            this.BtnSummary.TabIndex = 7;
            this.BtnSummary.Text = "Generate Summary Report";
            this.BtnSummary.UseVisualStyleBackColor = true;
            this.BtnSummary.Click += new System.EventHandler(this.BtnSummary_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(559, 226);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(115, 47);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSummary);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnUpdateStudent);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.BtnAddStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button BtnUpdateStudent;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnSummary;
        private System.Windows.Forms.Button BtnClear;
    }
}

