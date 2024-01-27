namespace POS_Pemograman_Lanjut
{
    partial class form_brg_out
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
            tid_out = new TextBox();
            tid_brg = new TextBox();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            dgv1 = new DataGridView();
            tstok_out = new TextBox();
            label5 = new Label();
            tstok = new TextBox();
            tnm_brg = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cb_brg = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            tbarang_1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // tid_out
            // 
            tid_out.Location = new Point(160, 42);
            tid_out.Margin = new Padding(3, 2, 3, 2);
            tid_out.Name = "tid_out";
            tid_out.Size = new Size(110, 23);
            tid_out.TabIndex = 33;
            // 
            // tid_brg
            // 
            tid_brg.Location = new Point(160, 103);
            tid_brg.Margin = new Padding(3, 2, 3, 2);
            tid_brg.Name = "tid_brg";
            tid_brg.ReadOnly = true;
            tid_brg.Size = new Size(222, 23);
            tid_brg.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 108);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 31;
            label6.Text = "ID Barang";
            // 
            // button4
            // 
            button4.Location = new Point(399, 108);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 30;
            button4.Text = "Batal";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(399, 80);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 29;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(399, 44);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 28;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(50, 252);
            dgv1.Margin = new Padding(3, 2, 3, 2);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.RowTemplate.Height = 29;
            dgv1.Size = new Size(517, 141);
            dgv1.TabIndex = 27;
            // 
            // tstok_out
            // 
            tstok_out.Location = new Point(160, 191);
            tstok_out.Margin = new Padding(3, 2, 3, 2);
            tstok_out.Name = "tstok_out";
            tstok_out.Size = new Size(222, 23);
            tstok_out.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 196);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 25;
            label5.Text = "Stok Keluar";
            // 
            // tstok
            // 
            tstok.Location = new Point(160, 159);
            tstok.Margin = new Padding(3, 2, 3, 2);
            tstok.Name = "tstok";
            tstok.ReadOnly = true;
            tstok.Size = new Size(222, 23);
            tstok.TabIndex = 24;
            // 
            // tnm_brg
            // 
            tnm_brg.Location = new Point(160, 132);
            tnm_brg.Margin = new Padding(3, 2, 3, 2);
            tnm_brg.Name = "tnm_brg";
            tnm_brg.ReadOnly = true;
            tnm_brg.Size = new Size(222, 23);
            tnm_brg.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 164);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 22;
            label4.Text = "Stok";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 134);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 21;
            label3.Text = "Nama Barang";
            // 
            // cb_brg
            // 
            cb_brg.FormattingEnabled = true;
            cb_brg.Location = new Point(160, 74);
            cb_brg.Margin = new Padding(3, 2, 3, 2);
            cb_brg.Name = "cb_brg";
            cb_brg.Size = new Size(110, 23);
            cb_brg.TabIndex = 20;
            cb_brg.SelectedIndexChanged += cb_brg_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 80);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 19;
            label2.Text = "Barang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 7);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 18;
            label1.Text = "BARANG KELUAR";
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 51);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 34;
            label7.Text = "ID";
            // 
            // tbarang_1
            // 
            tbarang_1.Location = new Point(276, 74);
            tbarang_1.Name = "tbarang_1";
            tbarang_1.Size = new Size(106, 23);
            tbarang_1.TabIndex = 35;
            // 
            // form_brg_out
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(600, 412);
            Controls.Add(tbarang_1);
            Controls.Add(label7);
            Controls.Add(tid_out);
            Controls.Add(tid_brg);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dgv1);
            Controls.Add(tstok_out);
            Controls.Add(label5);
            Controls.Add(tstok);
            Controls.Add(tnm_brg);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cb_brg);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "form_brg_out";
            Text = "form_brg_out";
            Load += form_brg_out_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tid_out;
        private TextBox tid_brg;
        private Label label6;
        private Button button4;
        private Button button3;
        private Button button1;
        private DataGridView dgv1;
        private TextBox tstok_out;
        private Label label5;
        private TextBox tstok;
        private TextBox tnm_brg;
        private Label label4;
        private Label label3;
        private ComboBox cb_brg;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox tbarang_1;
    }
}