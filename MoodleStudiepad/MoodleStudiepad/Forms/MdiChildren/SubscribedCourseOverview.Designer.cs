namespace MoodleStudiepad.Forms.MdiChildren
{
    partial class SubscribedCourseOverview
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
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.clbSubscriptionList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubscribe.Location = new System.Drawing.Point(221, 128);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 0;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            // 
            // clbSubscriptionList
            // 
            this.clbSubscriptionList.CheckOnClick = true;
            this.clbSubscriptionList.FormattingEnabled = true;
            this.clbSubscriptionList.Items.AddRange(new object[] {
            "A1A1 - Inleiding ICT",
            "A1A2 - Scripting",
            "A1A3 - Professioneel handelen",
            "A1A4",
            "A1A5",
            "A1A6",
            "A1A7",
            "A1A8"});
            this.clbSubscriptionList.Location = new System.Drawing.Point(12, 12);
            this.clbSubscriptionList.Name = "clbSubscriptionList";
            this.clbSubscriptionList.Size = new System.Drawing.Size(203, 139);
            this.clbSubscriptionList.TabIndex = 2;
            // 
            // SubscribedModuleOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 156);
            this.Controls.Add(this.clbSubscriptionList);
            this.Controls.Add(this.btnSubscribe);
            this.Name = "SubscribedModuleOverview";
            this.Text = "SubscribedModuleOverview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.CheckedListBox clbSubscriptionList;
    }
}