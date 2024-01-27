namespace POS_Pemograman_Lanjut
{
    partial class form_brg_msk
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
            label1 = new Label();
            label2 = new Label();
            cb_brg = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            tnm_brg = new TextBox();
            tstok = new TextBox();
            label5 = new Label();
            tstok_msk = new TextBox();
            dgv1 = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            tid_brg = new TextBox();
            label7 = new Label();
            tid_msk = new TextBox();
            tbarang_1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 16);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "BARANG MASUK";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 88);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Barang";
            label2.Click += label2_Click;
            // 
            // cb_brg
            // 
            cb_brg.FormattingEnabled = true;
            cb_brg.Location = new Point(150, 80);
            cb_brg.Margin = new Padding(3, 2, 3, 2);
            cb_brg.Name = "cb_brg";
            cb_brg.Size = new Size(110, 23);
            cb_brg.TabIndex = 2;
            cb_brg.SelectedIndexChanged += cb_brg_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 143);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama Barang";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 173);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 4;
            label4.Text = "Stok";
            label4.Click += label4_Click;
            // 
            // tnm_brg
            // 
            tnm_brg.Location = new Point(150, 141);
            tnm_brg.Margin = new Padding(3, 2, 3, 2);
            tnm_brg.Name = "tnm_brg";
            tnm_brg.ReadOnly = true;
            tnm_brg.Size = new Size(191, 23);
            tnm_brg.TabIndex = 5;
            tnm_brg.TextChanged += tnm_brg_TextChanged;
            // 
            // tstok
            // 
            tstok.Location = new Point(150, 168);
            tstok.Margin = new Padding(3, 2, 3, 2);
            tstok.Name = "tstok";
            tstok.ReadOnly = true;
            tstok.Size = new Size(191, 23);
            tstok.TabIndex = 6;
            tstok.TextChanged += tstok_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 206);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 7;
            label5.Text = "Stok Masuk";
            label5.Click += label5_Click;
            // 
            // tstok_msk
            // 
            tstok_msk.Location = new Point(150, 200);
            tstok_msk.Margin = new Padding(3, 2, 3, 2);
            tstok_msk.Name = "tstok_msk";
            tstok_msk.Size = new Size(191, 23);
            tstok_msk.TabIndex = 8;
            tstok_msk.TextChanged += tstok_msk_TextChanged;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(39, 261);
            dgv1.Margin = new Padding(3, 2, 3, 2);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.RowTemplate.Height = 29;
            dgv1.Size = new Size(517, 141);
            dgv1.TabIndex = 9;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(388, 53);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 10;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(388, 88);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 12;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(388, 117);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 13;
            button4.Text = "Batal";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 117);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 14;
            label6.Text = "ID Barang";
            label6.Click += label6_Click;
            // 
            // tid_brg
            // 
            tid_brg.Location = new Point(150, 112);
            tid_brg.Margin = new Padding(3, 2, 3, 2);
            tid_brg.Name = "tid_brg";
            tid_brg.ReadOnly = true;
            tid_brg.Size = new Size(191, 23);
            tid_brg.TabIndex = 15;
            tid_brg.TextChanged += tid_brg_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 53);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 16;
            label7.Text = "ID";
            // 
            // tid_msk
            // 
            tid_msk.Location = new Point(150, 51);
            tid_msk.Margin = new Padding(3, 2, 3, 2);
            tid_msk.Name = "tid_msk";
            tid_msk.Size = new Size(110, 23);
            tid_msk.TabIndex = 17;
            tid_msk.TextChanged += tid_msk_TextChanged;
            // 
            // tbarang_1
            // 
            tbarang_1.Location = new Point(266, 80);
            tbarang_1.Name = "tbarang_1";
            tbarang_1.Size = new Size(75, 23);
            tbarang_1.TabIndex = 18;
            // 
            // form_brg_msk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(590, 438);
            Controls.Add(tbarang_1);
            Controls.Add(tid_msk);
            Controls.Add(label7);
            Controls.Add(tid_brg);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dgv1);
            Controls.Add(tstok_msk);
            Controls.Add(label5);
            Controls.Add(tstok);
            Controls.Add(tnm_brg);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cb_brg);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "form_brg_msk";
            Text = "Barang Masuk";
            Load += form_brg_msk_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cb_brg;
        private Label label3;
        private Label label4;
        private TextBox tnm_brg;
        private TextBox tstok;
        private Label label5;
        private TextBox tstok_msk;
        private DataGridView dgv1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label6;
        private TextBox tid_brg;
        private Label label7;
        private TextBox tid_msk;
        private TextBox tbarang_1;
    }
}