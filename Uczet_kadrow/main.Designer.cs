namespace Uczet_kadrow
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.картаСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.штатноеРасписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.детиСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаОПредприятииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.презентацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеДоступомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.found = new System.Windows.Forms.TextBox();
            this.poisk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.add1 = new System.Windows.Forms.Button();
            this.print1 = new System.Windows.Forms.Button();
            this.load1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.data = new System.Windows.Forms.DataGridView();
            this.cbyear = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.картаСотрудниковToolStripMenuItem,
            this.отделToolStripMenuItem,
            this.штатноеРасписаниеToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.детиСотрудниковToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // картаСотрудниковToolStripMenuItem
            // 
            this.картаСотрудниковToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.картаСотрудниковToolStripMenuItem.Name = "картаСотрудниковToolStripMenuItem";
            this.картаСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.картаСотрудниковToolStripMenuItem.Text = "Карточки сотрудников";
            this.картаСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.КартаСотрудниковToolStripMenuItem_Click);
            // 
            // отделToolStripMenuItem
            // 
            this.отделToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.отделToolStripMenuItem.Name = "отделToolStripMenuItem";
            this.отделToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.отделToolStripMenuItem.Text = "Отдел";
            this.отделToolStripMenuItem.Click += new System.EventHandler(this.ОтделToolStripMenuItem_Click);
            // 
            // штатноеРасписаниеToolStripMenuItem
            // 
            this.штатноеРасписаниеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.штатноеРасписаниеToolStripMenuItem.Name = "штатноеРасписаниеToolStripMenuItem";
            this.штатноеРасписаниеToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.штатноеРасписаниеToolStripMenuItem.Text = "Штатное расписание";
            this.штатноеРасписаниеToolStripMenuItem.Click += new System.EventHandler(this.ШтатноеРасписаниеToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.СотрудникиToolStripMenuItem_Click);
            // 
            // детиСотрудниковToolStripMenuItem
            // 
            this.детиСотрудниковToolStripMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.детиСотрудниковToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.детиСотрудниковToolStripMenuItem.Name = "детиСотрудниковToolStripMenuItem";
            this.детиСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.детиСотрудниковToolStripMenuItem.Text = "Дети сотрудников";
            this.детиСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.ДетиСотрудниковToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаОПредприятииToolStripMenuItem,
            this.презентацияToolStripMenuItem,
            this.управлениеДоступомToolStripMenuItem,
            this.разработалToolStripMenuItem});
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.СправкаToolStripMenuItem_Click);
            // 
            // справкаОПредприятииToolStripMenuItem
            // 
            this.справкаОПредприятииToolStripMenuItem.Name = "справкаОПредприятииToolStripMenuItem";
            this.справкаОПредприятииToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.справкаОПредприятииToolStripMenuItem.Text = "Справка о предприятии";
            this.справкаОПредприятииToolStripMenuItem.Click += new System.EventHandler(this.СправкаОПредприятииToolStripMenuItem_Click);
            // 
            // презентацияToolStripMenuItem
            // 
            this.презентацияToolStripMenuItem.Name = "презентацияToolStripMenuItem";
            this.презентацияToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.презентацияToolStripMenuItem.Text = "Презентация диплома";
            this.презентацияToolStripMenuItem.Click += new System.EventHandler(this.ПрезентацияToolStripMenuItem_Click);
            // 
            // управлениеДоступомToolStripMenuItem
            // 
            this.управлениеДоступомToolStripMenuItem.Name = "управлениеДоступомToolStripMenuItem";
            this.управлениеДоступомToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.управлениеДоступомToolStripMenuItem.Text = "Управление доступом";
            this.управлениеДоступомToolStripMenuItem.Click += new System.EventHandler(this.УправлениеДоступомToolStripMenuItem_Click);
            // 
            // разработалToolStripMenuItem
            // 
            this.разработалToolStripMenuItem.Name = "разработалToolStripMenuItem";
            this.разработалToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.разработалToolStripMenuItem.Text = "Разработал";
            this.разработалToolStripMenuItem.Click += new System.EventHandler(this.РазработалToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.cbyear);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.found);
            this.panel1.Controls.Add(this.poisk);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.delete1);
            this.panel1.Controls.Add(this.add1);
            this.panel1.Controls.Add(this.print1);
            this.panel1.Controls.Add(this.load1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 36);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.BackgroundImage = global::Uczet_kadrow.Properties.Resources.upload1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(152, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // found
            // 
            this.found.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.found.Location = new System.Drawing.Point(229, 5);
            this.found.Name = "found";
            this.found.Size = new System.Drawing.Size(175, 23);
            this.found.TabIndex = 9;
            this.found.Visible = false;
            this.found.TextChanged += new System.EventHandler(this.Found_TextChanged);
            this.found.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Found_KeyUp);
            // 
            // poisk
            // 
            this.poisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.poisk.BackgroundImage = global::Uczet_kadrow.Properties.Resources.search1;
            this.poisk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.poisk.Location = new System.Drawing.Point(186, 5);
            this.poisk.Name = "poisk";
            this.poisk.Size = new System.Drawing.Size(28, 25);
            this.poisk.TabIndex = 8;
            this.poisk.Text = " ";
            this.poisk.UseVisualStyleBackColor = false;
            this.poisk.Click += new System.EventHandler(this.Poisk_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.BackgroundImage = global::Uczet_kadrow.Properties.Resources.arrow36;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1089, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // delete1
            // 
            this.delete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delete1.BackgroundImage = global::Uczet_kadrow.Properties.Resources.trash;
            this.delete1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete1.Location = new System.Drawing.Point(119, 5);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(28, 25);
            this.delete1.TabIndex = 7;
            this.delete1.Text = " ";
            this.delete1.UseVisualStyleBackColor = false;
            this.delete1.Click += new System.EventHandler(this.Delete1_Click);
            // 
            // add1
            // 
            this.add1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add1.BackgroundImage = global::Uczet_kadrow.Properties.Resources.user2;
            this.add1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add1.Location = new System.Drawing.Point(84, 5);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(28, 25);
            this.add1.TabIndex = 6;
            this.add1.Text = " ";
            this.add1.UseVisualStyleBackColor = false;
            this.add1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // print1
            // 
            this.print1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.print1.BackgroundImage = global::Uczet_kadrow.Properties.Resources.printer;
            this.print1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.print1.Location = new System.Drawing.Point(50, 5);
            this.print1.Name = "print1";
            this.print1.Size = new System.Drawing.Size(28, 25);
            this.print1.TabIndex = 5;
            this.print1.Text = " ";
            this.print1.UseVisualStyleBackColor = false;
            this.print1.Click += new System.EventHandler(this.Button3_Click);
            // 
            // load1
            // 
            this.load1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.load1.BackgroundImage = global::Uczet_kadrow.Properties.Resources.arrow19;
            this.load1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.load1.Location = new System.Drawing.Point(15, 5);
            this.load1.Name = "load1";
            this.load1.Size = new System.Drawing.Size(28, 25);
            this.load1.TabIndex = 4;
            this.load1.Text = " ";
            this.load1.UseVisualStyleBackColor = false;
            this.load1.Click += new System.EventHandler(this.Button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.PrintPreviewDialog1_Load);
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.Color.Silver;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(0, 64);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(1129, 534);
            this.data.TabIndex = 4;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellClick);
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellContentClick);
            // 
            // cbyear
            // 
            this.cbyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cbyear.FormattingEnabled = true;
            this.cbyear.Items.AddRange(new object[] {
            "Старше",
            "Младше"});
            this.cbyear.Location = new System.Drawing.Point(520, 5);
            this.cbyear.Name = "cbyear";
            this.cbyear.Size = new System.Drawing.Size(96, 23);
            this.cbyear.TabIndex = 11;
            this.cbyear.Visible = false;
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.year.Location = new System.Drawing.Point(622, 5);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(40, 23);
            this.year.TabIndex = 12;
            this.year.Text = "0";
            this.year.Visible = false;
            this.year.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Показать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1129, 598);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление кадрами";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem картаСотрудниковToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button load1;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Button print1;
        private System.Windows.Forms.Button poisk;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.ToolStripMenuItem штатноеРасписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem детиСотрудниковToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox found;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаОПредприятииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem презентацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеДоступомToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.ComboBox cbyear;
        private System.Windows.Forms.Button button3;
    }
}