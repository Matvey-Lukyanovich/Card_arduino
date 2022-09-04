namespace Uczet_kadrow
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolbox = new System.Windows.Forms.ToolStrip();
            this.savefile = new System.Windows.Forms.ToolStripButton();
            this.openfile = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.user = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 28);
            this.panel1.TabIndex = 7;
            // 
            // toolbox
            // 
            this.toolbox.BackColor = System.Drawing.Color.White;
            this.toolbox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savefile,
            this.openfile});
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(353, 27);
            this.toolbox.TabIndex = 3;
            // 
            // savefile
            // 
            this.savefile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savefile.Enabled = false;
            this.savefile.Image = ((System.Drawing.Image)(resources.GetObject("savefile.Image")));
            this.savefile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(24, 24);
            this.savefile.Text = "Сохранить";
            this.savefile.Click += new System.EventHandler(this.Savefile_Click);
            // 
            // openfile
            // 
            this.openfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openfile.Image = ((System.Drawing.Image)(resources.GetObject("openfile.Image")));
            this.openfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(24, 24);
            this.openfile.Text = "Открыть";
            this.openfile.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 312);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(334, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 312);
            this.panel4.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 28);
            this.panel2.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.user);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(16, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(318, 312);
            this.panel5.TabIndex = 13;
            // 
            // user
            // 
            this.user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(0, 0);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(318, 312);
            this.user.TabIndex = 0;
            this.user.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 368);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление доступом";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolbox;
        private System.Windows.Forms.ToolStripButton savefile;
        private System.Windows.Forms.ToolStripButton openfile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox user;
    }
}