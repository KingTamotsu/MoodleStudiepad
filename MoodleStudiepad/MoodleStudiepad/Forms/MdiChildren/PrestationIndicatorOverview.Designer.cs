namespace MoodleStudiepad.Forms.MdiChildren
{
    partial class PrestationIndicatorOverview
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
            this.bt_indivPi = new System.Windows.Forms.Button();
            this.bt_avgPi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 197);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bt_indivPi
            // 
            this.bt_indivPi.Location = new System.Drawing.Point(328, 12);
            this.bt_indivPi.Name = "bt_indivPi";
            this.bt_indivPi.Size = new System.Drawing.Size(94, 23);
            this.bt_indivPi.TabIndex = 1;
            this.bt_indivPi.Text = "View indiv. PI";
            this.bt_indivPi.UseVisualStyleBackColor = true;
            this.bt_indivPi.Click += new System.EventHandler(this.bt_indivPi_Click);
            // 
            // bt_avgPi
            // 
            this.bt_avgPi.Location = new System.Drawing.Point(328, 41);
            this.bt_avgPi.Name = "bt_avgPi";
            this.bt_avgPi.Size = new System.Drawing.Size(94, 23);
            this.bt_avgPi.TabIndex = 2;
            this.bt_avgPi.Text = "View avg. PI";
            this.bt_avgPi.UseVisualStyleBackColor = true;
            this.bt_avgPi.Click += new System.EventHandler(this.bt_avgPi_Click);
            // 
            // PrestationIndicatorOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 218);
            this.Controls.Add(this.bt_avgPi);
            this.Controls.Add(this.bt_indivPi);
            this.Controls.Add(this.listView1);
            this.Name = "PrestationIndicatorOverview";
            this.Text = "PI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bt_indivPi;
        private System.Windows.Forms.Button bt_avgPi;
    }
}