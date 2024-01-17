namespace POS_Pemograman_Lanjut
{
    partial class form_barang
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
            label3 = new Label();
            label4 = new Label();
            dgv1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tid = new TextBox();
            label5 = new Label();
            tnm_brg = new TextBox();
            tstok = new TextBox();
            tharga = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 18);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "BARANG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 114);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 153);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Stok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 190);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Harga";
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(81, 250);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.RowTemplate.Height = 29;
            dgv1.Size = new Size(693, 188);
            dgv1.TabIndex = 7;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(606, 52);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(606, 92);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(606, 130);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Ubah";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(606, 165);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Batal";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tid
            // 
            tid.Location = new Point(237, 78);
            tid.Name = "tid";
            tid.Size = new Size(172, 27);
            tid.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 81);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 14;
            label5.Text = "ID Barang";
            // 
            // tnm_brg
            // 
            tnm_brg.Location = new Point(237, 114);
            tnm_brg.Name = "tnm_brg";
            tnm_brg.Size = new Size(172, 27);
            tnm_brg.TabIndex = 15;
            // 
            // tstok
            // 
            tstok.Location = new Point(237, 153);
            tstok.Name = "tstok";
            tstok.Size = new Size(172, 27);
            tstok.TabIndex = 16;
            // 
            // tharga
            // 
            tharga.Location = new Point(237, 190);
            tharga.Name = "tharga";
            tharga.Size = new Size(172, 27);
            tharga.TabIndex = 17;
            // 
            // form_barang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tharga);
            Controls.Add(tstok);
            Controls.Add(tnm_brg);
            Controls.Add(label5);
            Controls.Add(tid);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgv1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "form_barang";
            Text = "form_barang";
            Load += form_barang_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dgv1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox tid;
        private Label label5;
        private TextBox tnm_brg;
        private TextBox tstok;
        private TextBox tharga;
    }
}