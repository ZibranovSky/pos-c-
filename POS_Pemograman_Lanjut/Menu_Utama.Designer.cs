namespace POS_Pemograman_Lanjut
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            barangToolStripMenuItem = new ToolStripMenuItem();
            barangToolStripMenuItem1 = new ToolStripMenuItem();
            barangMasukToolStripMenuItem = new ToolStripMenuItem();
            barangKeluarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 113);
            label1.Name = "label1";
            label1.Size = new Size(390, 30);
            label1.TabIndex = 0;
            label1.Text = "SISTEM INVENTORY POINT OF SALES ";
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { barangToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(742, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // barangToolStripMenuItem
            // 
            barangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { barangToolStripMenuItem1, barangMasukToolStripMenuItem, barangKeluarToolStripMenuItem });
            barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            barangToolStripMenuItem.Size = new Size(82, 20);
            barangToolStripMenuItem.Text = "Data Master";
            barangToolStripMenuItem.Click += barangToolStripMenuItem_Click;
            // 
            // barangToolStripMenuItem1
            // 
            barangToolStripMenuItem1.Name = "barangToolStripMenuItem1";
            barangToolStripMenuItem1.Size = new Size(180, 22);
            barangToolStripMenuItem1.Text = "Barang";
            barangToolStripMenuItem1.Click += barangToolStripMenuItem1_Click;
            // 
            // barangMasukToolStripMenuItem
            // 
            barangMasukToolStripMenuItem.Name = "barangMasukToolStripMenuItem";
            barangMasukToolStripMenuItem.Size = new Size(180, 22);
            barangMasukToolStripMenuItem.Text = "Barang Masuk";
            barangMasukToolStripMenuItem.Click += barangMasukToolStripMenuItem_Click;
            // 
            // barangKeluarToolStripMenuItem
            // 
            barangKeluarToolStripMenuItem.Name = "barangKeluarToolStripMenuItem";
            barangKeluarToolStripMenuItem.Size = new Size(180, 22);
            barangKeluarToolStripMenuItem.Text = "Barang Keluar";
            barangKeluarToolStripMenuItem.Click += barangKeluarToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(742, 338);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem barangToolStripMenuItem;
        private ToolStripMenuItem barangToolStripMenuItem1;
        private ToolStripMenuItem barangMasukToolStripMenuItem;
        private ToolStripMenuItem barangKeluarToolStripMenuItem;
    }
}