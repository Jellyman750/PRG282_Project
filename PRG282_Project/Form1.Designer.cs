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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddStudent = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.BtnUpdateStudent = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(69, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Records";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStudent.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAddStudent.Location = new System.Drawing.Point(38, 107);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(138, 55);
            this.BtnAddStudent.TabIndex = 3;
            this.BtnAddStudent.Text = "Add Student";
            this.BtnAddStudent.UseVisualStyleBackColor = false;
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnViewStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudents.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewStudents.Location = new System.Drawing.Point(38, 271);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(138, 60);
            this.btnViewStudents.TabIndex = 4;
            this.btnViewStudents.Text = "View Student Database";
            this.btnViewStudents.UseVisualStyleBackColor = false;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // BtnUpdateStudent
            // 
            this.BtnUpdateStudent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateStudent.ForeColor = System.Drawing.Color.Transparent;
            this.BtnUpdateStudent.Location = new System.Drawing.Point(213, 107);
            this.BtnUpdateStudent.Name = "BtnUpdateStudent";
            this.BtnUpdateStudent.Size = new System.Drawing.Size(125, 55);
            this.BtnUpdateStudent.TabIndex = 5;
            this.BtnUpdateStudent.Text = "Update Students Information";
            this.BtnUpdateStudent.UseVisualStyleBackColor = false;
            this.BtnUpdateStudent.Click += new System.EventHandler(this.BtnUpdateStudent_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(213, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete a Student";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnSummary
            // 
            this.BtnSummary.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSummary.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSummary.Location = new System.Drawing.Point(125, 188);
            this.BtnSummary.Name = "BtnSummary";
            this.BtnSummary.Size = new System.Drawing.Size(128, 58);
            this.BtnSummary.TabIndex = 7;
            this.BtnSummary.Text = "Generate Summary Report";
            this.BtnSummary.UseVisualStyleBackColor = false;
            this.BtnSummary.Click += new System.EventHandler(this.BtnSummary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(390, 399);
            this.Controls.Add(this.BtnSummary);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnUpdateStudent);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.BtnAddStudent);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button BtnUpdateStudent;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnSummary;
    }
}

