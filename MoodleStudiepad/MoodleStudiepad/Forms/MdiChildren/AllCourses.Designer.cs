namespace MoodleStudiepad.Forms.MdiChildren {
    partial class AllCourses {
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
            this.dGV_Courses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Courses)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Courses
            // 
            this.dGV_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Courses.Location = new System.Drawing.Point(12, 12);
            this.dGV_Courses.Name = "dGV_Courses";
            this.dGV_Courses.Size = new System.Drawing.Size(776, 426);
            this.dGV_Courses.TabIndex = 0;
            // 
            // AllCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGV_Courses);
            this.Name = "AllCourses";
            this.Text = "AllCourses";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Courses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Courses;
    }
}