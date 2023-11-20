namespace NilaiMahasiswa
{
    partial class FormNilaiMahasiswa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNilaiAbsen = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nilaiAbsen = new System.Windows.Forms.NumericUpDown();
            this.nilaiTugas = new System.Windows.Forms.NumericUpDown();
            this.nilaiUTS = new System.Windows.Forms.NumericUpDown();
            this.nilaiUAS = new System.Windows.Forms.NumericUpDown();
            this.lbNilaiTugas = new System.Windows.Forms.Label();
            this.lbNilaiUTS = new System.Windows.Forms.Label();
            this.lbNilaiUAS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.keterangan = new System.Windows.Forms.TextBox();
            this.predikat = new System.Windows.Forms.TextBox();
            this.NilaiAkhir = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiAbsen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiTugas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiUTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiUAS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nilai Absensi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nilai Tugas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nilai UTS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nilai UAS";
            // 
            // lbNilaiAbsen
            // 
            this.lbNilaiAbsen.AutoSize = true;
            this.lbNilaiAbsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNilaiAbsen.Location = new System.Drawing.Point(297, 25);
            this.lbNilaiAbsen.Name = "lbNilaiAbsen";
            this.lbNilaiAbsen.Size = new System.Drawing.Size(18, 20);
            this.lbNilaiAbsen.TabIndex = 12;
            this.lbNilaiAbsen.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "INPUT NILAI MAHASISWA";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // nilaiAbsen
            // 
            this.nilaiAbsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nilaiAbsen.Location = new System.Drawing.Point(125, 23);
            this.nilaiAbsen.Name = "nilaiAbsen";
            this.nilaiAbsen.Size = new System.Drawing.Size(120, 26);
            this.nilaiAbsen.TabIndex = 17;
            this.nilaiAbsen.ValueChanged += new System.EventHandler(this.nilaiAbsen_ValueChanged);
            this.nilaiAbsen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nilaiAbsen_KeyUp);
            // 
            // nilaiTugas
            // 
            this.nilaiTugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nilaiTugas.Location = new System.Drawing.Point(125, 55);
            this.nilaiTugas.Name = "nilaiTugas";
            this.nilaiTugas.Size = new System.Drawing.Size(120, 26);
            this.nilaiTugas.TabIndex = 18;
            this.nilaiTugas.ValueChanged += new System.EventHandler(this.nilaiTugas_ValueChanged);
            this.nilaiTugas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nilaiTugas_KeyUp);
            // 
            // nilaiUTS
            // 
            this.nilaiUTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nilaiUTS.Location = new System.Drawing.Point(125, 87);
            this.nilaiUTS.Name = "nilaiUTS";
            this.nilaiUTS.Size = new System.Drawing.Size(120, 26);
            this.nilaiUTS.TabIndex = 19;
            this.nilaiUTS.ValueChanged += new System.EventHandler(this.nilaiUTS_ValueChanged);
            this.nilaiUTS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nilaiUTS_KeyUp);
            // 
            // nilaiUAS
            // 
            this.nilaiUAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nilaiUAS.Location = new System.Drawing.Point(125, 119);
            this.nilaiUAS.Name = "nilaiUAS";
            this.nilaiUAS.Size = new System.Drawing.Size(120, 26);
            this.nilaiUAS.TabIndex = 20;
            this.nilaiUAS.ValueChanged += new System.EventHandler(this.nilaiUAS_ValueChanged);
            this.nilaiUAS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nilaiUAS_KeyUp);
            // 
            // lbNilaiTugas
            // 
            this.lbNilaiTugas.AutoSize = true;
            this.lbNilaiTugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNilaiTugas.Location = new System.Drawing.Point(297, 57);
            this.lbNilaiTugas.Name = "lbNilaiTugas";
            this.lbNilaiTugas.Size = new System.Drawing.Size(18, 20);
            this.lbNilaiTugas.TabIndex = 21;
            this.lbNilaiTugas.Text = "0";
            // 
            // lbNilaiUTS
            // 
            this.lbNilaiUTS.AutoSize = true;
            this.lbNilaiUTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNilaiUTS.Location = new System.Drawing.Point(297, 89);
            this.lbNilaiUTS.Name = "lbNilaiUTS";
            this.lbNilaiUTS.Size = new System.Drawing.Size(18, 20);
            this.lbNilaiUTS.TabIndex = 22;
            this.lbNilaiUTS.Text = "0";
            // 
            // lbNilaiUAS
            // 
            this.lbNilaiUAS.AutoSize = true;
            this.lbNilaiUAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNilaiUAS.Location = new System.Drawing.Point(297, 121);
            this.lbNilaiUAS.Name = "lbNilaiUAS";
            this.lbNilaiUAS.Size = new System.Drawing.Size(18, 20);
            this.lbNilaiUAS.TabIndex = 23;
            this.lbNilaiUAS.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "10% :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(251, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "20% :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(251, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "30% :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(251, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "40% :";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(188, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(10, 10);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbNilaiUAS);
            this.groupBox2.Controls.Add(this.lbNilaiUTS);
            this.groupBox2.Controls.Add(this.lbNilaiTugas);
            this.groupBox2.Controls.Add(this.lbNilaiAbsen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nilaiUAS);
            this.groupBox2.Controls.Add(this.nilaiUTS);
            this.groupBox2.Controls.Add(this.nilaiTugas);
            this.groupBox2.Controls.Add(this.nilaiAbsen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(30, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 161);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INPUT NILAI";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.keterangan);
            this.groupBox3.Controls.Add(this.predikat);
            this.groupBox3.Controls.Add(this.NilaiAkhir);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Location = new System.Drawing.Point(361, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 161);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HASIL NILAI";
            // 
            // keterangan
            // 
            this.keterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keterangan.Location = new System.Drawing.Point(113, 86);
            this.keterangan.Name = "keterangan";
            this.keterangan.Size = new System.Drawing.Size(189, 26);
            this.keterangan.TabIndex = 13;
            // 
            // predikat
            // 
            this.predikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predikat.Location = new System.Drawing.Point(113, 55);
            this.predikat.Name = "predikat";
            this.predikat.Size = new System.Drawing.Size(189, 26);
            this.predikat.TabIndex = 12;
            // 
            // NilaiAkhir
            // 
            this.NilaiAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NilaiAkhir.Location = new System.Drawing.Point(113, 23);
            this.NilaiAkhir.Name = "NilaiAkhir";
            this.NilaiAkhir.Size = new System.Drawing.Size(189, 26);
            this.NilaiAkhir.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(11, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 20);
            this.label22.TabIndex = 10;
            this.label22.Text = "Keterangan";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(11, 57);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 20);
            this.label23.TabIndex = 9;
            this.label23.Text = "Predikat";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(11, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 20);
            this.label24.TabIndex = 8;
            this.label24.Text = "Nilai Akhir";
            // 
            // btnProses
            // 
            this.btnProses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnProses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProses.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnProses.FlatAppearance.BorderSize = 2;
            this.btnProses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btnProses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProses.Location = new System.Drawing.Point(241, 275);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(114, 44);
            this.btnProses.TabIndex = 31;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = false;
            this.btnProses.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(361, 275);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 44);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormNilaiMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(715, 347);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Name = "FormNilaiMahasiswa";
            this.Text = "Input Nilai Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nilaiAbsen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiTugas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiUTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiUAS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNilaiAbsen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nilaiAbsen;
        private System.Windows.Forms.NumericUpDown nilaiTugas;
        private System.Windows.Forms.NumericUpDown nilaiUTS;
        private System.Windows.Forms.NumericUpDown nilaiUAS;
        private System.Windows.Forms.Label lbNilaiTugas;
        private System.Windows.Forms.Label lbNilaiUTS;
        private System.Windows.Forms.Label lbNilaiUAS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox keterangan;
        private System.Windows.Forms.TextBox predikat;
        private System.Windows.Forms.TextBox NilaiAkhir;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnReset;
    }
}

