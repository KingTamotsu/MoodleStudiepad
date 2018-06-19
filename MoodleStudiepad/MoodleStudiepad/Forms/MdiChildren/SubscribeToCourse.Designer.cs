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
            this.SuspendLayout();
            // 
            // cLBNonSubscribedCoureses
            // 
            this.cLBNonSubscribedCoureses.FormattingEnabled = true;
            this.cLBNonSubscribedCoureses.Location = new System.Drawing.Point(12, 108);
            this.cLBNonSubscribedCoureses.Name = "cLBNonSubscribedCoureses";
            this.cLBNonSubscribedCoureses.Size = new System.Drawing.Size(290, 259);
            this.cLBNonSubscribedCoureses.TabIndex = 0;
            this.cLBNonSubscribedCoureses.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cLBNonSubscribedCoureses_ItemCheck);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(12, 391);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 1;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // SubscribeToCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.cLBNonSubscribedCoureses);
            this.Name = "SubscribeToCourse";
            this.Text = "SubscribeToCourse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cLBNonSubscribedCoureses;
        private System.Windows.Forms.Button btnSubscribe;
    }
}