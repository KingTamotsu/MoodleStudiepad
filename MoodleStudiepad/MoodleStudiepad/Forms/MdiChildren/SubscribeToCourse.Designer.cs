namespace MoodleStudiepad.Forms.MdiChildren {
    partial class SubscribeToCourse {
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
            this.cLBNonSubscribedCoureses = new System.Windows.Forms.CheckedListBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.lb_available = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cLBNonSubscribedCoureses
            // 
            this.cLBNonSubscribedCoureses.FormattingEnabled = true;
            this.cLBNonSubscribedCoureses.Location = new System.Drawing.Point(12, 28);
            this.cLBNonSubscribedCoureses.Name = "cLBNonSubscribedCoureses";
            this.cLBNonSubscribedCoureses.Size = new System.Drawing.Size(290, 259);
            this.cLBNonSubscribedCoureses.TabIndex = 0;
            this.cLBNonSubscribedCoureses.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cLBNonSubscribedCoureses_ItemCheck);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(12, 293);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(290, 23);
            this.btnSubscribe.TabIndex = 1;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // lb_available
            // 
            this.lb_available.AutoSize = true;
            this.lb_available.ForeColor = System.Drawing.Color.White;
            this.lb_available.Location = new System.Drawing.Point(12, 12);
            this.lb_available.Name = "lb_available";
            this.lb_available.Size = new System.Drawing.Size(93, 13);
            this.lb_available.TabIndex = 2;
            this.lb_available.Text = "Available courses:";
            // 
            // SubscribeToCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(316, 326);
            this.Controls.Add(this.lb_available);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.cLBNonSubscribedCoureses);
            this.Name = "SubscribeToCourse";
            this.ShowIcon = false;
            this.Text = "Course subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cLBNonSubscribedCoureses;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label lb_available;
    }
}