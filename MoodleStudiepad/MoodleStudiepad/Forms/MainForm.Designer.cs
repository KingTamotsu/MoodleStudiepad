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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOut2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtOnderwijseenhedenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inschrijvenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitschrijvenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOut2ToolStripMenuItem,
            this.studieToolStripMenuItem,
            this.resultatenToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.tempToolStripMenuItem,
            this.coursesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOut2ToolStripMenuItem
            // 
            this.logOut2ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOut2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOut2ToolStripMenuItem.Image")));
            this.logOut2ToolStripMenuItem.Name = "logOut2ToolStripMenuItem";
            this.logOut2ToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.logOut2ToolStripMenuItem.Text = "Log out";
            this.logOut2ToolStripMenuItem.Click += new System.EventHandler(this.logOut2ToolStripMenuItem_Click);
            this.logOut2ToolStripMenuItem.MouseEnter += new System.EventHandler(this.logOut2ToolStripMenuItem_MouseEnter);
            this.logOut2ToolStripMenuItem.MouseLeave += new System.EventHandler(this.logOut2ToolStripMenuItem_MouseLeave);
            // 
            // studieToolStripMenuItem
            // 
            this.studieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overzichtOnderwijseenhedenToolStripMenuItem,
            this.inschrijvenToolStripMenuItem,
            this.uitschrijvenToolStripMenuItem});
            this.studieToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.studieToolStripMenuItem.Name = "studieToolStripMenuItem";
            this.studieToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.studieToolStripMenuItem.Text = "Study";
            this.studieToolStripMenuItem.DropDownClosed += new System.EventHandler(this.studieToolStripMenuItem_DropDownClosed);
            this.studieToolStripMenuItem.DropDownOpened += new System.EventHandler(this.studieToolStripMenuItem_DropDownOpened);
            this.studieToolStripMenuItem.MouseEnter += new System.EventHandler(this.studieToolStripMenuItem_MouseEnter);
            this.studieToolStripMenuItem.MouseLeave += new System.EventHandler(this.studieToolStripMenuItem_MouseLeave);
            // 
            // overzichtOnderwijseenhedenToolStripMenuItem
            // 
            this.overzichtOnderwijseenhedenToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.overzichtOnderwijseenhedenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.overzichtOnderwijseenhedenToolStripMenuItem.Name = "overzichtOnderwijseenhedenToolStripMenuItem";
            this.overzichtOnderwijseenhedenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.overzichtOnderwijseenhedenToolStripMenuItem.Text = "Module overview";
            this.overzichtOnderwijseenhedenToolStripMenuItem.Click += new System.EventHandler(this.overzichtOnderwijseenhedenToolStripMenuItem_Click);
            this.overzichtOnderwijseenhedenToolStripMenuItem.MouseEnter += new System.EventHandler(this.overzichtOnderwijseenhedenToolStripMenuItem_MouseEnter);
            this.overzichtOnderwijseenhedenToolStripMenuItem.MouseLeave += new System.EventHandler(this.overzichtOnderwijseenhedenToolStripMenuItem_MouseLeave);
            // 
            // inschrijvenToolStripMenuItem
            // 
            this.inschrijvenToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.inschrijvenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inschrijvenToolStripMenuItem.Name = "inschrijvenToolStripMenuItem";
            this.inschrijvenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inschrijvenToolStripMenuItem.Text = "Subscribe to course";
            this.inschrijvenToolStripMenuItem.Click += new System.EventHandler(this.inschrijvenToolStripMenuItem_Click);
            this.inschrijvenToolStripMenuItem.MouseEnter += new System.EventHandler(this.inschrijvenToolStripMenuItem_MouseEnter);
            this.inschrijvenToolStripMenuItem.MouseLeave += new System.EventHandler(this.inschrijvenToolStripMenuItem_MouseLeave);
            // 
            // uitschrijvenToolStripMenuItem
            // 
            this.uitschrijvenToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.uitschrijvenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.uitschrijvenToolStripMenuItem.Name = "uitschrijvenToolStripMenuItem";
            this.uitschrijvenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uitschrijvenToolStripMenuItem.Text = "Stop education";
            this.uitschrijvenToolStripMenuItem.MouseEnter += new System.EventHandler(this.uitschrijvenToolStripMenuItem_MouseEnter);
            this.uitschrijvenToolStripMenuItem.MouseLeave += new System.EventHandler(this.uitschrijvenToolStripMenuItem_MouseLeave);
            // 
            // resultatenToolStripMenuItem
            // 
            this.resultatenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pIToolStripMenuItem,
            this.eCToolStripMenuItem});
            this.resultatenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.resultatenToolStripMenuItem.Name = "resultatenToolStripMenuItem";
            this.resultatenToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.resultatenToolStripMenuItem.Text = "Results";
            this.resultatenToolStripMenuItem.DropDownClosed += new System.EventHandler(this.resultatenToolStripMenuItem_DropDownClosed);
            this.resultatenToolStripMenuItem.DropDownOpened += new System.EventHandler(this.resultatenToolStripMenuItem_DropDownOpened);
            this.resultatenToolStripMenuItem.MouseEnter += new System.EventHandler(this.resultatenToolStripMenuItem_MouseEnter);
            this.resultatenToolStripMenuItem.MouseLeave += new System.EventHandler(this.resultatenToolStripMenuItem_MouseLeave);
            // 
            // pIToolStripMenuItem
            // 
            this.pIToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.pIToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pIToolStripMenuItem.Name = "pIToolStripMenuItem";
            this.pIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pIToolStripMenuItem.Text = "PI";
            this.pIToolStripMenuItem.Click += new System.EventHandler(this.pIToolStripMenuItem_Click);
            this.pIToolStripMenuItem.MouseEnter += new System.EventHandler(this.pIToolStripMenuItem_MouseEnter);
            this.pIToolStripMenuItem.MouseLeave += new System.EventHandler(this.pIToolStripMenuItem_MouseLeave);
            // 
            // eCToolStripMenuItem
            // 
            this.eCToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.eCToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eCToolStripMenuItem.Name = "eCToolStripMenuItem";
            this.eCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eCToolStripMenuItem.Text = "EC";
            this.eCToolStripMenuItem.Click += new System.EventHandler(this.eCToolStripMenuItem_Click);
            this.eCToolStripMenuItem.MouseEnter += new System.EventHandler(this.eCToolStripMenuItem_MouseEnter);
            this.eCToolStripMenuItem.MouseLeave += new System.EventHandler(this.eCToolStripMenuItem_MouseLeave);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.MouseEnter += new System.EventHandler(this.personalToolStripMenuItem_MouseEnter);
            this.personalToolStripMenuItem.MouseLeave += new System.EventHandler(this.personalToolStripMenuItem_MouseLeave);
            // 
            // tempToolStripMenuItem
            // 
            this.tempToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tempToolStripMenuItem.Name = "tempToolStripMenuItem";
            this.tempToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.tempToolStripMenuItem.Text = "Courses";
            this.tempToolStripMenuItem.Click += new System.EventHandler(this.tempToolStripMenuItem_Click);
            this.tempToolStripMenuItem.MouseEnter += new System.EventHandler(this.tempToolStripMenuItem_MouseEnter);
            this.tempToolStripMenuItem.MouseLeave += new System.EventHandler(this.tempToolStripMenuItem_MouseLeave);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(599, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(197, 14);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Username";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MoodleStudiepad.Properties.Resources.Zuyd;
            this.pictureBox1.Location = new System.Drawing.Point(687, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Moodle Studiepad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem overzichtOnderwijseenhedenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}