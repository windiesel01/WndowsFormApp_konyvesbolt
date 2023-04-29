namespace WndowsFormApp_konyvesbolt
{
    partial class NyitoForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.könyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vásárlóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vásárlásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_konyvek = new System.Windows.Forms.ListBox();
            this.listBox_vasarlok = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.könyvToolStripMenuItem,
            this.vásárlóToolStripMenuItem,
            this.vásárlásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // könyvToolStripMenuItem
            // 
            this.könyvToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.törlésToolStripMenuItem,
            this.módosításToolStripMenuItem});
            this.könyvToolStripMenuItem.Name = "könyvToolStripMenuItem";
            this.könyvToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.könyvToolStripMenuItem.Text = "Könyv";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // vásárlóToolStripMenuItem
            // 
            this.vásárlóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem1,
            this.törlésToolStripMenuItem1,
            this.módosításToolStripMenuItem1});
            this.vásárlóToolStripMenuItem.Name = "vásárlóToolStripMenuItem";
            this.vásárlóToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.vásárlóToolStripMenuItem.Text = "Vásárló";
            // 
            // újToolStripMenuItem1
            // 
            this.újToolStripMenuItem1.Name = "újToolStripMenuItem1";
            this.újToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.újToolStripMenuItem1.Text = "Új";
            this.újToolStripMenuItem1.Click += new System.EventHandler(this.újToolStripMenuItem1_Click);
            // 
            // törlésToolStripMenuItem1
            // 
            this.törlésToolStripMenuItem1.Name = "törlésToolStripMenuItem1";
            this.törlésToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.törlésToolStripMenuItem1.Text = "Törlés";
            this.törlésToolStripMenuItem1.Click += new System.EventHandler(this.törlésToolStripMenuItem1_Click);
            // 
            // módosításToolStripMenuItem1
            // 
            this.módosításToolStripMenuItem1.Name = "módosításToolStripMenuItem1";
            this.módosításToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.módosításToolStripMenuItem1.Text = "Módosítás";
            this.módosításToolStripMenuItem1.Click += new System.EventHandler(this.módosításToolStripMenuItem1_Click);
            // 
            // vásárlásToolStripMenuItem
            // 
            this.vásárlásToolStripMenuItem.Name = "vásárlásToolStripMenuItem";
            this.vásárlásToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.vásárlásToolStripMenuItem.Text = "Vásárlás";
            // 
            // listBox_konyvek
            // 
            this.listBox_konyvek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_konyvek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_konyvek.FormattingEnabled = true;
            this.listBox_konyvek.ItemHeight = 20;
            this.listBox_konyvek.Location = new System.Drawing.Point(0, 29);
            this.listBox_konyvek.Name = "listBox_konyvek";
            this.listBox_konyvek.Size = new System.Drawing.Size(435, 421);
            this.listBox_konyvek.TabIndex = 1;
            // 
            // listBox_vasarlok
            // 
            this.listBox_vasarlok.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_vasarlok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_vasarlok.FormattingEnabled = true;
            this.listBox_vasarlok.ItemHeight = 20;
            this.listBox_vasarlok.Location = new System.Drawing.Point(492, 29);
            this.listBox_vasarlok.Name = "listBox_vasarlok";
            this.listBox_vasarlok.Size = new System.Drawing.Size(308, 421);
            this.listBox_vasarlok.TabIndex = 2;
            // 
            // NyitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_vasarlok);
            this.Controls.Add(this.listBox_konyvek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NyitoForm";
            this.Text = "Könyves Bolt";
            this.Load += new System.EventHandler(this.NyitoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem könyvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vásárlóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vásárlásToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox_konyvek;
        public System.Windows.Forms.ListBox listBox_vasarlok;
    }
}

