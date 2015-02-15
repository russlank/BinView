namespace BinView1
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NormalizeChk = new System.Windows.Forms.CheckBox();
            this.ScaleChk = new System.Windows.Forms.CheckBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.FullViewChk = new System.Windows.Forms.CheckBox();
            this.BlockSizeBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.BlockSizeBox);
            this.panel1.Controls.Add(this.FullViewChk);
            this.panel1.Controls.Add(this.NormalizeChk);
            this.panel1.Controls.Add(this.ScaleChk);
            this.panel1.Controls.Add(this.OpenBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 30);
            this.panel1.TabIndex = 0;
            // 
            // NormalizeChk
            // 
            this.NormalizeChk.AutoSize = true;
            this.NormalizeChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalizeChk.Location = new System.Drawing.Point(183, 7);
            this.NormalizeChk.Name = "NormalizeChk";
            this.NormalizeChk.Size = new System.Drawing.Size(69, 17);
            this.NormalizeChk.TabIndex = 2;
            this.NormalizeChk.Text = "Normalize";
            this.NormalizeChk.UseVisualStyleBackColor = true;
            this.NormalizeChk.CheckedChanged += new System.EventHandler(this.NormalizeChk_CheckedChanged);
            // 
            // ScaleChk
            // 
            this.ScaleChk.AutoSize = true;
            this.ScaleChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScaleChk.Location = new System.Drawing.Point(96, 7);
            this.ScaleChk.Name = "ScaleChk";
            this.ScaleChk.Size = new System.Drawing.Size(48, 17);
            this.ScaleChk.TabIndex = 1;
            this.ScaleChk.Text = "Scale";
            this.ScaleChk.UseVisualStyleBackColor = true;
            this.ScaleChk.CheckedChanged += new System.EventHandler(this.Scale_CheckedChanged);
            // 
            // OpenBtn
            // 
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.Location = new System.Drawing.Point(3, 3);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Open File";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 472);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(128, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(569, 472);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 472);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.DataPictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 472);
            this.panel3.TabIndex = 0;
            // 
            // DataPictureBox
            // 
            this.DataPictureBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.DataPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPictureBox.Location = new System.Drawing.Point(0, 0);
            this.DataPictureBox.Name = "DataPictureBox";
            this.DataPictureBox.Size = new System.Drawing.Size(128, 472);
            this.DataPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DataPictureBox.TabIndex = 0;
            this.DataPictureBox.TabStop = false;
            this.DataPictureBox.Click += new System.EventHandler(this.DataPictureBox_Click);
            this.DataPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataPictureBox_MouseDown);
            this.DataPictureBox.MouseHover += new System.EventHandler(this.DataPictureBox_MouseHover);
            this.DataPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataPictureBox_MouseMove);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "*.*";
            this.openFileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FullViewChk
            // 
            this.FullViewChk.AutoSize = true;
            this.FullViewChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullViewChk.Location = new System.Drawing.Point(277, 7);
            this.FullViewChk.Name = "FullViewChk";
            this.FullViewChk.Size = new System.Drawing.Size(64, 17);
            this.FullViewChk.TabIndex = 3;
            this.FullViewChk.Text = "Full View";
            this.FullViewChk.UseVisualStyleBackColor = true;
            this.FullViewChk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BlockSizeBox
            // 
            this.BlockSizeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlockSizeBox.Location = new System.Drawing.Point(374, 4);
            this.BlockSizeBox.Name = "BlockSizeBox";
            this.BlockSizeBox.Size = new System.Drawing.Size(100, 20);
            this.BlockSizeBox.TabIndex = 4;
            this.BlockSizeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.BlockSizeBox.Leave += new System.EventHandler(this.BlockSizeBox_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "BinView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ScaleChk;
        private System.Windows.Forms.CheckBox NormalizeChk;
        private System.Windows.Forms.PictureBox DataPictureBox;
        private System.Windows.Forms.CheckBox FullViewChk;
        private System.Windows.Forms.TextBox BlockSizeBox;
    }
}

