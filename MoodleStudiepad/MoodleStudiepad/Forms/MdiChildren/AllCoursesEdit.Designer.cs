namespace MoodleStudiepad.Forms.MdiChildren {
    partial class AllCoursesEdit {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.tbCourseCode = new System.Windows.Forms.TextBox();
            this.tbSchoolYear = new System.Windows.Forms.TextBox();
            this.tbBlockPeriod = new System.Windows.Forms.TextBox();
            this.tbCredits = new System.Windows.Forms.TextBox();
            this.lbCourseId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(69, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "School Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Block Period";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Credits";
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(95, 13);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(100, 20);
            this.tbCourseName.TabIndex = 6;
            // 
            // tbCourseCode
            // 
            this.tbCourseCode.Location = new System.Drawing.Point(95, 40);
            this.tbCourseCode.Name = "tbCourseCode";
            this.tbCourseCode.Size = new System.Drawing.Size(100, 20);
            this.tbCourseCode.TabIndex = 7;
            // 
            // tbSchoolYear
            // 
            this.tbSchoolYear.Location = new System.Drawing.Point(95, 67);
            this.tbSchoolYear.Name = "tbSchoolYear";
            this.tbSchoolYear.Size = new System.Drawing.Size(100, 20);
            this.tbSchoolYear.TabIndex = 8;
            // 
            // tbBlockPeriod
            // 
            this.tbBlockPeriod.Location = new System.Drawing.Point(95, 93);
            this.tbBlockPeriod.Name = "tbBlockPeriod";
            this.tbBlockPeriod.Size = new System.Drawing.Size(100, 20);
            this.tbBlockPeriod.TabIndex = 9;
            // 
            // tbCredits
            // 
            this.tbCredits.Location = new System.Drawing.Point(95, 119);
            this.tbCredits.Name = "tbCredits";
            this.tbCredits.Size = new System.Drawing.Size(100, 20);
            this.tbCredits.TabIndex = 10;
            // 
            // lbCourseId
            // 
            this.lbCourseId.AutoSize = true;
            this.lbCourseId.Location = new System.Drawing.Point(177, 160);
            this.lbCourseId.Name = "lbCourseId";
            this.lbCourseId.Size = new System.Drawing.Size(18, 13);
            this.lbCourseId.TabIndex = 11;
            this.lbCourseId.Text = "ID";
            this.lbCourseId.Visible = false;
            // 
            // AllCoursesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(215, 188);
            this.Controls.Add(this.lbCourseId);
            this.Controls.Add(this.tbCredits);
            this.Controls.Add(this.tbBlockPeriod);
            this.Controls.Add(this.tbSchoolYear);
            this.Controls.Add(this.tbCourseCode);
            this.Controls.Add(this.tbCourseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AllCoursesEdit";
            this.ShowIcon = false;
            this.Text = "Edit course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.TextBox tbCourseCode;
        private System.Windows.Forms.TextBox tbSchoolYear;
        private System.Windows.Forms.TextBox tbBlockPeriod;
        private System.Windows.Forms.TextBox tbCredits;
        private System.Windows.Forms.Label lbCourseId;
    }
}