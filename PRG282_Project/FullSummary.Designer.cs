namespace PRG282_Project
{
    partial class FullSummary
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btndiplayInsert = new System.Windows.Forms.Button();
            this.btnDiplayDeleted = new System.Windows.Forms.Button();
            this.BtnDiplayDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(109, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(605, 530);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "StudentID";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Student Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Age";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Course";
            this.columnHeader4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Summary Report of all changes made to the Database";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.MintCream;
            this.btnDisplay.Location = new System.Drawing.Point(241, 665);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(160, 59);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display All Updated Data";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btndiplayInsert
            // 
            this.btndiplayInsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btndiplayInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiplayInsert.ForeColor = System.Drawing.Color.MintCream;
            this.btndiplayInsert.Location = new System.Drawing.Point(57, 665);
            this.btndiplayInsert.Name = "btndiplayInsert";
            this.btndiplayInsert.Size = new System.Drawing.Size(160, 59);
            this.btndiplayInsert.TabIndex = 5;
            this.btndiplayInsert.Text = "Display All Inserted Data";
            this.btndiplayInsert.UseVisualStyleBackColor = false;
            this.btndiplayInsert.Click += new System.EventHandler(this.btndiplayInsert_Click);
            // 
            // btnDiplayDeleted
            // 
            this.btnDiplayDeleted.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDiplayDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiplayDeleted.ForeColor = System.Drawing.Color.MintCream;
            this.btnDiplayDeleted.Location = new System.Drawing.Point(424, 665);
            this.btnDiplayDeleted.Name = "btnDiplayDeleted";
            this.btnDiplayDeleted.Size = new System.Drawing.Size(160, 59);
            this.btnDiplayDeleted.TabIndex = 6;
            this.btnDiplayDeleted.Text = "Display All Deleted Data";
            this.btnDiplayDeleted.UseVisualStyleBackColor = false;
            this.btnDiplayDeleted.Click += new System.EventHandler(this.btnDiplayDeleted_Click);
            // 
            // BtnDiplayDatabase
            // 
            this.BtnDiplayDatabase.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDiplayDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiplayDatabase.ForeColor = System.Drawing.Color.MintCream;
            this.BtnDiplayDatabase.Location = new System.Drawing.Point(605, 665);
            this.BtnDiplayDatabase.Name = "BtnDiplayDatabase";
            this.BtnDiplayDatabase.Size = new System.Drawing.Size(160, 59);
            this.BtnDiplayDatabase.TabIndex = 7;
            this.BtnDiplayDatabase.Text = "Display Updated Database\r\n";
            this.BtnDiplayDatabase.UseVisualStyleBackColor = false;
            this.BtnDiplayDatabase.Click += new System.EventHandler(this.BtnDiplayDatabase_Click);
            // 
            // FullSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(812, 745);
            this.Controls.Add(this.BtnDiplayDatabase);
            this.Controls.Add(this.btnDiplayDeleted);
            this.Controls.Add(this.btndiplayInsert);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "FullSummary";
            this.Text = "FullSummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btndiplayInsert;
        private System.Windows.Forms.Button btnDiplayDeleted;
        private System.Windows.Forms.Button BtnDiplayDatabase;
    }
}