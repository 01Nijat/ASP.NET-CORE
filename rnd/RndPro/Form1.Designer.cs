namespace RndPro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Btnqeyd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.Btnelave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btnbasla = new System.Windows.Forms.Button();
            this.Btntemizle = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.Ad = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.Btnqeyd);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nece Nefer Yarisci Olacaq?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayi";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(53, 36);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(30, 25);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Btnqeyd
            // 
            this.Btnqeyd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btnqeyd.Location = new System.Drawing.Point(104, 36);
            this.Btnqeyd.Name = "Btnqeyd";
            this.Btnqeyd.Size = new System.Drawing.Size(114, 25);
            this.Btnqeyd.TabIndex = 2;
            this.Btnqeyd.Text = "Qeyd et";
            this.Btnqeyd.UseVisualStyleBackColor = false;
            this.Btnqeyd.Click += new System.EventHandler(this.btnqeyd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.Ad);
            this.groupBox2.Controls.Add(this.Btnelave);
            this.groupBox2.Controls.Add(this.txtadi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yarisci Elave Et";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad";
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(70, 35);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(148, 25);
            this.txtadi.TabIndex = 1;
            // 
            // Btnelave
            // 
            this.Btnelave.Location = new System.Drawing.Point(115, 66);
            this.Btnelave.Name = "Btnelave";
            this.Btnelave.Size = new System.Drawing.Size(103, 30);
            this.Btnelave.TabIndex = 2;
            this.Btnelave.Text = "Elave et";
            this.Btnelave.UseVisualStyleBackColor = true;
            this.Btnelave.Click += new System.EventHandler(this.btnelave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.List);
            this.groupBox3.Controls.Add(this.Btntemizle);
            this.groupBox3.Controls.Add(this.Btnbasla);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(262, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 331);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reqibler siyahsi";
            // 
            // Btnbasla
            // 
            this.Btnbasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btnbasla.Location = new System.Drawing.Point(24, 47);
            this.Btnbasla.Name = "Btnbasla";
            this.Btnbasla.Size = new System.Drawing.Size(104, 31);
            this.Btnbasla.TabIndex = 0;
            this.Btnbasla.Text = "Basla";
            this.Btnbasla.UseVisualStyleBackColor = false;
            this.Btnbasla.Click += new System.EventHandler(this.Btnbasla_Click);
            // 
            // Btntemizle
            // 
            this.Btntemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btntemizle.Location = new System.Drawing.Point(155, 47);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(106, 31);
            this.Btntemizle.TabIndex = 0;
            this.Btntemizle.Text = "Bitir";
            this.Btntemizle.UseVisualStyleBackColor = false;
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 21;
            this.List.Location = new System.Drawing.Point(26, 100);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(235, 214);
            this.List.TabIndex = 1;
            // 
            // Ad
            // 
            this.Ad.FormattingEnabled = true;
            this.Ad.ItemHeight = 17;
            this.Ad.Location = new System.Drawing.Point(6, 102);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(230, 225);
            this.Ad.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(558, 483);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArmWrestling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button Btnqeyd;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private GroupBox groupBox2;
        private Button Btnelave;
        private TextBox txtadi;
        private Label label2;
        private GroupBox groupBox3;
        private ListBox List;
        private Button Btntemizle;
        private Button Btnbasla;
        private ListBox Ad;
    }
}