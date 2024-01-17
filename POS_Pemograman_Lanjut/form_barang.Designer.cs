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
            label4 = new Label();
            dgv1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tid = new TextBox();
            label5 = new Label();
            tnm_brg = new TextBox();
            tharga = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "BARANG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 86);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 115);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Harga";
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(71, 188);
            dgv1.Margin = new Padding(3, 2, 3, 2);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.RowTemplate.Height = 29;
            dgv1.Size = new Size(606, 141);
            dgv1.TabIndex = 7;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(530, 39);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 8;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(530, 69);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 9;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(530, 98);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 10;
            button3.Text = "Ubah";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(530, 124);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 11;
            button4.Text = "Batal";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tid
            // 
            tid.Location = new Point(207, 58);
            tid.Margin = new Padding(3, 2, 3, 2);
            tid.Name = "tid";
            tid.Size = new Size(151, 23);
            tid.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 61);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 14;
            label5.Text = "ID Barang";
            // 
            // tnm_brg
            // 
            tnm_brg.Location = new Point(207, 86);
            tnm_brg.Margin = new Padding(3, 2, 3, 2);
            tnm_brg.Name = "tnm_brg";
            tnm_brg.Size = new Size(151, 23);
            tnm_brg.TabIndex = 15;
            // 
            // tharga
            // 
            tharga.Location = new Point(207, 123);
            tharga.Margin = new Padding(3, 2, 3, 2);
            tharga.Name = "tharga";
            tharga.Size = new Size(151, 23);
            tharga.TabIndex = 17;
            // 
            // form_barang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tharga);
            Controls.Add(tnm_brg);
            Controls.Add(label5);
            Controls.Add(tid);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgv1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox tharga;
    }
}