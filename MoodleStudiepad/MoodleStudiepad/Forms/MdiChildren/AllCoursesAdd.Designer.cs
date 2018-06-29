namespace MoodleStudiepad.Forms.MdiChildren {
    partial class AllCoursesAdd {
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "School Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Block Period";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Credits";
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(113, 9);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(154, 20);
            this.tbCourseName.TabIndex = 6;
            // 
            // tbCourseCode
            // 
            this.tbCourseCode.Location = new System.Drawing.Point(113, 36);
            this.tbCourseCode.Name = "tbCourseCode";
            this.tbCourseCode.Size = new System.Drawing.Size(154, 20);
            this.tbCourseCode.TabIndex = 7;
            // 
            // tbSchoolYear
            // 
            this.tbSchoolYear.Location = new System.Drawing.Point(113, 62);
            this.tbSchoolYear.Name = "tbSchoolYear";
            this.tbSchoolYear.Size = new System.Drawing.Size(154, 20);
            this.tbSchoolYear.TabIndex = 8;
            // 
            // tbBlockPeriod
            // 
            this.tbBlockPeriod.Location = new System.Drawing.Point(113, 88);
            this.tbBlockPeriod.Name = "tbBlockPeriod";
            this.tbBlockPeriod.Size = new System.Drawing.Size(154, 20);
            this.tbBlockPeriod.TabIndex = 9;
            // 
            // tbCredits
            // 
            this.tbCredits.Location = new System.Drawing.Point(113, 114);
            this.tbCredits.Name = "tbCredits";
            this.tbCredits.Size = new System.Drawing.Size(154, 20);
            this.tbCredits.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(95, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AllCoursesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(279, 182);
            this.Controls.Add(this.btnAdd);
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
            this.Name = "AllCoursesAdd";
            this.ShowIcon = false;
            this.Text = "Add course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnAdd;
    }
}