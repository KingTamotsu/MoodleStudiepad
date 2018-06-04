namespace MoodleStudiepad.GUI {
    partial class MainForm {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOut2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtOnderwijseenhedenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inschrijvenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitschrijvenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debuggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debug1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOut2ToolStripMenuItem,
            this.studieToolStripMenuItem,
            this.resultatenToolStripMenuItem,
            this.debuggingToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOut2ToolStripMenuItem
            // 
            this.logOut2ToolStripMenuItem.Name = "logOut2ToolStripMenuItem";
            this.logOut2ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOut2ToolStripMenuItem.Text = "Log out";
            this.logOut2ToolStripMenuItem.Click += new System.EventHandler(this.logOut2ToolStripMenuItem_Click);
            // 
            // studieToolStripMenuItem
            // 
            this.studieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overzichtOnderwijseenhedenToolStripMenuItem,
            this.inschrijvenToolStripMenuItem,
            this.uitschrijvenToolStripMenuItem});
            this.studieToolStripMenuItem.Name = "studieToolStripMenuItem";
            this.studieToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.studieToolStripMenuItem.Text = "Study";
            // 
            // overzichtOnderwijseenhedenToolStripMenuItem
            // 
            this.overzichtOnderwijseenhedenToolStripMenuItem.Name = "overzichtOnderwijseenhedenToolStripMenuItem";
            this.overzichtOnderwijseenhedenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.overzichtOnderwijseenhedenToolStripMenuItem.Text = "Module overview";
            this.overzichtOnderwijseenhedenToolStripMenuItem.Click += new System.EventHandler(this.overzichtOnderwijseenhedenToolStripMenuItem_Click);
            // 
            // inschrijvenToolStripMenuItem
            // 
            this.inschrijvenToolStripMenuItem.Name = "inschrijvenToolStripMenuItem";
            this.inschrijvenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.inschrijvenToolStripMenuItem.Text = "Subscribe to module";
            // 
            // uitschrijvenToolStripMenuItem
            // 
            this.uitschrijvenToolStripMenuItem.Name = "uitschrijvenToolStripMenuItem";
            this.uitschrijvenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.uitschrijvenToolStripMenuItem.Text = "Stop education";
            // 
            // resultatenToolStripMenuItem
            // 
            this.resultatenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pIToolStripMenuItem,
            this.eCToolStripMenuItem});
            this.resultatenToolStripMenuItem.Name = "resultatenToolStripMenuItem";
            this.resultatenToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.resultatenToolStripMenuItem.Text = "Results";
            // 
            // pIToolStripMenuItem
            // 
            this.pIToolStripMenuItem.Name = "pIToolStripMenuItem";
            this.pIToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.pIToolStripMenuItem.Text = "PI";
            this.pIToolStripMenuItem.Click += new System.EventHandler(this.pIToolStripMenuItem_Click);
            // 
            // eCToolStripMenuItem
            // 
            this.eCToolStripMenuItem.Name = "eCToolStripMenuItem";
            this.eCToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.eCToolStripMenuItem.Text = "EC";
            this.eCToolStripMenuItem.Click += new System.EventHandler(this.eCToolStripMenuItem_Click);
            // 
            // debuggingToolStripMenuItem
            // 
            this.debuggingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debug1ToolStripMenuItem});
            this.debuggingToolStripMenuItem.Name = "debuggingToolStripMenuItem";
            this.debuggingToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.debuggingToolStripMenuItem.Text = "Debugging";
            // 
            // debug1ToolStripMenuItem
            // 
            this.debug1ToolStripMenuItem.Name = "debug1ToolStripMenuItem";
            this.debug1ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.debug1ToolStripMenuItem.Text = "Debug 1";
            this.debug1ToolStripMenuItem.Click += new System.EventHandler(this.debug1ToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Location = new System.Drawing.Point(591, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(197, 14);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Bob Bobberton";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOut2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inschrijvenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitschrijvenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debuggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debug1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overzichtOnderwijseenhedenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
    }
}